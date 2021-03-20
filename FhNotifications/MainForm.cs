using FhNotifications.Properties;
using FreelancehuntApiClient;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FhNotifications
{
    public partial class MainForm : Form
    {
        private FhClient fhCient;
        private PopupMessageForm ActivePopupMessage;
        private FhFeedObject[] LastShownFeed;

        public MainForm()
        {
            //Settings.Default.Reset();
            InitializeComponent();

            Opacity = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Settings.Default.ApiToken))
            {
                var settingsForm = new SettingsForm();
                var dialogResult = settingsForm.ShowDialog();

                if (dialogResult != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
            }

            fhCient = new FhClient(Settings.Default.ApiToken);

            FeedUpdateTimer.Interval = Settings.Default.SecondsBeforeUpdateFeed * 1000;
            FeedUpdateTimer.Start();
            FeedUpdateTimer_Tick(this, null);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Hide();
            Opacity = 1;
            AppNotifyIcon.Visible = true;
            AppNotifyIcon.ShowBalloonTip(500);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                AppNotifyIcon.Visible = true;
                AppNotifyIcon.ShowBalloonTip(500);
                Hide();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Visible && Opacity != 0)
            {
                e.Cancel = true;
                AppNotifyIcon.ShowBalloonTip(500);
                Hide();
            }
        }

        private DateHeader CreateDateHeaderControl(DateTime date)
        {
            var control = new DateHeader(date)
            {
                Dock = DockStyle.Top,
                Parent = FeedPanel,
                AutoSize = true
            };

            return control;
        }

        private FeedMessage CreateFeedMessageControl(string text, TimeSpan time, bool isNew)
        {
            var control = new FeedMessage(text, time, isNew)
            {
                Dock = DockStyle.Top,
                Parent = FeedPanel,
                AutoSize = true
            };

            return control;
        }

        private void GenerateFeed(FhFeedObject[] feed, FhFeedObject[] newFeed)
        {
            if (feed != null && LastShownFeed != null && Enumerable.SequenceEqual(feed, LastShownFeed))
                return;

            FeedPanel.SuspendLayout();
            FeedPanel.Controls.Clear();

            var feedByDates = feed
                .OrderBy(feedObject => feedObject.CreatedAt.Date)
                .GroupBy(feedObject => feedObject.CreatedAt.Date);

            foreach (var group in feedByDates)
            {
                var groupByTime = group.OrderBy(feedObject => feedObject.CreatedAt.TimeOfDay);

                foreach (var feedObject in groupByTime)
                    CreateFeedMessageControl(feedObject.Message, feedObject.CreatedAt.TimeOfDay, newFeed.Contains(feedObject));

                CreateDateHeaderControl(group.Key);
            }

            FeedPanel.ResumeLayout();
            
            if (FeedPanel.Controls.Count > 0)
                FeedPanel.Controls.Cast<Control>().Last().Select();

            LastShownFeed = feed;
        }

        private async void FeedUpdateTimer_Tick(object sender, EventArgs e)
        {
            FhFeedObject[] feed;

            try
            {
                feed = await fhCient.GetFeed();
            }
            catch (FhRequestException exception)
            {
                var requestsLimitCount = int.Parse(exception.Error.OwnerResponse.Message.Headers.GetValues("X-Ratelimit-Remaining").First()); // отладка
                return;
            }
            catch (Exception exception) // ignore
            {
                return;
            }

            var newFeed = feed
                .Where(feedObject => feedObject.IsNew)
                .OrderByDescending(feedObject => feedObject.CreatedAt);

            GenerateFeed(feed, newFeed.ToArray());            

            if (newFeed.Count() == 0)
                return;

            if (newFeed.First().OwnerDataObject.Id == Settings.Default.LastShownMessageId)
                return;

            if (Visible)
                return;

            ActivePopupMessage = PopupMessageForm.PopUp(newFeed.First().Message, newFeed.Count(),
                TimeSpan.FromSeconds(Settings.Default.MessageShowingSeconds),
                onClick: async () =>
                {
                    await fhCient.MarkFeedAsRead();
                    Invoke(new Action(Show));                
                });

            Settings.Default.LastShownMessageId = newFeed.First().OwnerDataObject.Id;
            Settings.Default.Save();
        }
        
        private async void AppNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (ActivePopupMessage != null)
            {
                ActivePopupMessage.Close();
                ActivePopupMessage = null;
            }

            Show();
            TopMost = true;
            TopMost = false;

            try
            {
                await fhCient.MarkFeedAsRead();
            }
            catch (Exception exception) { } // ignore
        }

        private void NotifyIconContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == SettingsNotifyIconContextMenuItem)
            {
                var settingsForm = new SettingsForm();
                var dialogResult = settingsForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                    FeedUpdateTimer_Tick(this, null);
            }
            else if (e.ClickedItem == ExitNotifyIconContextMenuItem)
            {
                AppNotifyIcon.Visible = false;
                Application.Exit();
            }
        }

        private async void RetryLoadFeedButton_Click(object sender, EventArgs e)
        {
            FeedPanel.Enabled = false;
            FeedUpdateTimer_Tick(this, null);
            await Task.Delay(1000);
            FeedPanel.Enabled = true;

            try
            {
                await fhCient.MarkFeedAsRead();
            }
            catch (Exception exception) { } // ignore
        }
    }
}
