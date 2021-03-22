using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FhNotifications
{
    public partial class FeedMessage : UserControl
    {
        private Size oldSize;
        private Color formStartColor;

        public FeedMessage(string text, TimeSpan time, bool isNew)
        {
            InitializeComponent();

            oldSize         = Size;
            formStartColor  = BackColor;
            TimeText.Text   = time.ToString(@"hh\:mm");

            if (isNew)
                BackColor = Color.FromArgb(255, 229, 168);

            MessageText.Text = text;
            HelpClass.SetLinksInLinkLabelFromHtmlTags(MessageText);
        }

        private void FeedMessage_Resize(object sender, EventArgs e)
        {
            MessageText.MaximumSize = new Size(
                MessageText.MaximumSize.Width + Size.Width - oldSize.Width,
                MessageText.MaximumSize.Height);

            oldSize = Size;
        }

        private void MessageText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Process.Start((string)e.Link.LinkData);
        }

        private void FeedMessage_MouseEnter(object sender, EventArgs e)
        {
            var r = BackColor.R + (Color.FromKnownColor(KnownColor.DarkGray).R - BackColor.R) * 100 / 255;
            var g = BackColor.G + (Color.FromKnownColor(KnownColor.DarkGray).G - BackColor.G) * 100 / 255;
            var b = BackColor.B + (Color.FromKnownColor(KnownColor.DarkGray).B - BackColor.B) * 100 / 255;
            BackColor = Color.FromArgb(r, g, b);
        }

        private void FeedMessage_MouseLeave(object sender, EventArgs e)
        {
            BackColor = formStartColor;
        }
    }
}
