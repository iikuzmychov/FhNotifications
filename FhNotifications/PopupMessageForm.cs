using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FhNotifications
{
    public partial class PopupMessageForm : Form
    {
        private Action onClick;
        private bool linkClicked = false;

        public static PopupMessageForm PopUp(string message, int totalMessagesCount, TimeSpan showingTime, Action onClick)
        {
            if (message is null)
                throw new ArgumentNullException(nameof(message));

            var form = new PopupMessageForm(message, totalMessagesCount, showingTime, onClick);
            form.Show();

            return form;
        }

        private PopupMessageForm(string message, int totalMessagesCount, TimeSpan showingTime, Action onClick)
        {
            InitializeComponent();

            var workingArea = Screen.GetWorkingArea(this);
            Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);

            MessageText.Text = message;
            HelpClass.SetLinksInLinkLabelFromHtmlTags(MessageText);

            if (totalMessagesCount > 1)
                this.Text += $" (и ещё {totalMessagesCount - 1})";

            ShowingTimer.Interval = (int)showingTime.TotalMilliseconds;
            this.onClick = onClick;
        }

        private void PopupMessageForm_Load(object sender, EventArgs e)
        {
            ShowingTimer.Start();
            SystemSounds.Beep.Play();
        }

        private void ShowingTimer_Tick(object sender, EventArgs e)
        {
            ShowingTimer.Stop();
            Close();
        }

        private void OnClick()
        {
            onClick?.Invoke();
            Close();
        }

        private void PopupMessageForm_MouseDown(object sender, MouseEventArgs e)
        {
            OnClick();
        }

        private async void MessageText_Click(object sender, EventArgs e)
        {
            await Task.Delay(1).ContinueWith(task =>
            {
                if (!linkClicked)
                    Invoke(new Action(OnClick));
            });
        }

        private void MessageText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                linkClicked = true;
                Process.Start((string)e.Link.LinkData);
                Close();
            }
        }
    }
}
