
namespace FhNotifications
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FeedUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.FeedPanel = new System.Windows.Forms.Panel();
            this.AppNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SettingsNotifyIconContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitNotifyIconContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RetryLoadFeedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FeedPanel.SuspendLayout();
            this.NotifyIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // FeedUpdateTimer
            // 
            this.FeedUpdateTimer.Interval = 10000;
            this.FeedUpdateTimer.Tick += new System.EventHandler(this.FeedUpdateTimer_Tick);
            // 
            // FeedPanel
            // 
            this.FeedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FeedPanel.AutoScroll = true;
            this.FeedPanel.Controls.Add(this.label1);
            this.FeedPanel.Controls.Add(this.RetryLoadFeedButton);
            this.FeedPanel.Location = new System.Drawing.Point(0, 0);
            this.FeedPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FeedPanel.Name = "FeedPanel";
            this.FeedPanel.Size = new System.Drawing.Size(842, 452);
            this.FeedPanel.TabIndex = 0;
            // 
            // AppNotifyIcon
            // 
            this.AppNotifyIcon.BalloonTipText = "Приложение свёрнуто в трей";
            this.AppNotifyIcon.ContextMenuStrip = this.NotifyIconContextMenu;
            this.AppNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("AppNotifyIcon.Icon")));
            this.AppNotifyIcon.Text = "FhNotifications";
            this.AppNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AppNotifyIcon_MouseClick);
            // 
            // NotifyIconContextMenu
            // 
            this.NotifyIconContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NotifyIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsNotifyIconContextMenuItem,
            this.ExitNotifyIconContextMenuItem});
            this.NotifyIconContextMenu.Name = "NotifyIconContextMenu";
            this.NotifyIconContextMenu.Size = new System.Drawing.Size(154, 52);
            this.NotifyIconContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.NotifyIconContextMenu_ItemClicked);
            // 
            // SettingsNotifyIconContextMenuItem
            // 
            this.SettingsNotifyIconContextMenuItem.Name = "SettingsNotifyIconContextMenuItem";
            this.SettingsNotifyIconContextMenuItem.Size = new System.Drawing.Size(153, 24);
            this.SettingsNotifyIconContextMenuItem.Text = "Настройки";
            // 
            // ExitNotifyIconContextMenuItem
            // 
            this.ExitNotifyIconContextMenuItem.Name = "ExitNotifyIconContextMenuItem";
            this.ExitNotifyIconContextMenuItem.Size = new System.Drawing.Size(153, 24);
            this.ExitNotifyIconContextMenuItem.Text = "Выйти";
            // 
            // RetryLoadFeedButton
            // 
            this.RetryLoadFeedButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RetryLoadFeedButton.Font = new System.Drawing.Font("Montserrat", 12F);
            this.RetryLoadFeedButton.Location = new System.Drawing.Point(200, 314);
            this.RetryLoadFeedButton.Margin = new System.Windows.Forms.Padding(200, 3, 200, 80);
            this.RetryLoadFeedButton.Name = "RetryLoadFeedButton";
            this.RetryLoadFeedButton.Size = new System.Drawing.Size(442, 50);
            this.RetryLoadFeedButton.TabIndex = 0;
            this.RetryLoadFeedButton.Text = "Поробовать загрузить заново";
            this.RetryLoadFeedButton.UseVisualStyleBackColor = true;
            this.RetryLoadFeedButton.Click += new System.EventHandler(this.RetryLoadFeedButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(818, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Не удалось загрузить данные";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 453);
            this.Controls.Add(this.FeedPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(860, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уведомления";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.FeedPanel.ResumeLayout(false);
            this.NotifyIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer FeedUpdateTimer;
        private System.Windows.Forms.Panel FeedPanel;
        private System.Windows.Forms.NotifyIcon AppNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotifyIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SettingsNotifyIconContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitNotifyIconContextMenuItem;
        private System.Windows.Forms.Button RetryLoadFeedButton;
        private System.Windows.Forms.Label label1;
    }
}