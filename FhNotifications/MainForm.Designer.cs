
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
            this.label1 = new System.Windows.Forms.Label();
            this.RetryLoadFeedButton = new System.Windows.Forms.Button();
            this.AppNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SettingsNotifyIconContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitNotifyIconContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.YoutubeLink = new System.Windows.Forms.LinkLabel();
            this.TelegramLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.FeedPanel.SuspendLayout();
            this.NotifyIconContextMenu.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
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
            this.FeedPanel.Size = new System.Drawing.Size(842, 437);
            this.FeedPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(839, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Не удалось загрузить данные";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RetryLoadFeedButton
            // 
            this.RetryLoadFeedButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RetryLoadFeedButton.Font = new System.Drawing.Font("Montserrat", 12F);
            this.RetryLoadFeedButton.Location = new System.Drawing.Point(211, 276);
            this.RetryLoadFeedButton.Margin = new System.Windows.Forms.Padding(200, 3, 200, 80);
            this.RetryLoadFeedButton.Name = "RetryLoadFeedButton";
            this.RetryLoadFeedButton.Size = new System.Drawing.Size(442, 50);
            this.RetryLoadFeedButton.TabIndex = 0;
            this.RetryLoadFeedButton.Text = "Поробовать загрузить заново";
            this.RetryLoadFeedButton.UseVisualStyleBackColor = true;
            this.RetryLoadFeedButton.Click += new System.EventHandler(this.RetryLoadFeedButton_Click);
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
            // LogoPanel
            // 
            this.LogoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoPanel.Controls.Add(this.YoutubeLink);
            this.LogoPanel.Controls.Add(this.TelegramLink);
            this.LogoPanel.Controls.Add(this.label2);
            this.LogoPanel.Controls.Add(this.LogoPicture);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoPanel.Location = new System.Drawing.Point(0, 437);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(842, 102);
            this.LogoPanel.TabIndex = 1;
            // 
            // YoutubeLink
            // 
            this.YoutubeLink.AutoSize = true;
            this.YoutubeLink.Font = new System.Drawing.Font("Montserrat", 12F);
            this.YoutubeLink.LinkArea = new System.Windows.Forms.LinkArea(12, 33);
            this.YoutubeLink.Location = new System.Drawing.Point(11, 39);
            this.YoutubeLink.Name = "YoutubeLink";
            this.YoutubeLink.Size = new System.Drawing.Size(521, 30);
            this.YoutubeLink.TabIndex = 3;
            this.YoutubeLink.TabStop = true;
            this.YoutubeLink.Text = "Ютуб-канал: https://www.youtube.com/c/kuzcode";
            this.YoutubeLink.UseCompatibleTextRendering = true;
            this.YoutubeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.YoutubeLink_LinkClicked);
            // 
            // TelegramLink
            // 
            this.TelegramLink.AutoSize = true;
            this.TelegramLink.Font = new System.Drawing.Font("Montserrat", 12F);
            this.TelegramLink.LinkArea = new System.Windows.Forms.LinkArea(16, 10);
            this.TelegramLink.Location = new System.Drawing.Point(11, 69);
            this.TelegramLink.Name = "TelegramLink";
            this.TelegramLink.Size = new System.Drawing.Size(323, 30);
            this.TelegramLink.TabIndex = 2;
            this.TelegramLink.TabStop = true;
            this.TelegramLink.Text = "Телеграм-канал: @kuzcodech";
            this.TelegramLink.UseCompatibleTextRendering = true;
            this.TelegramLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TelegramLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 27);
            this.label2.TabIndex = 1;
            this.label2.TabStop = true;
            this.label2.Text = "Автор программы: KuzCode\r\n";
            // 
            // LogoPicture
            // 
            this.LogoPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPicture.BackColor = System.Drawing.Color.Black;
            this.LogoPicture.Image = global::FhNotifications.Properties.Resources.kuzcode_logo;
            this.LogoPicture.Location = new System.Drawing.Point(653, 3);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(184, 94);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 539);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.FeedPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(860, 586);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уведомления";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.FeedPanel.ResumeLayout(false);
            this.NotifyIconContextMenu.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
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
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel TelegramLink;
        private System.Windows.Forms.LinkLabel YoutubeLink;
    }
}