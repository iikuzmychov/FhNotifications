using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FhNotifications
{
    public partial class FeedMessage : UserControl
    {
        private Size oldSize;

        public FeedMessage(string text, TimeSpan time, bool isNew)
        {
            InitializeComponent();

            oldSize         = Size;
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
    }
}
