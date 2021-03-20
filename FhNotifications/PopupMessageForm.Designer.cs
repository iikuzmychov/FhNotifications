
namespace FhNotifications
{
    partial class PopupMessageForm
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
            this.MessageText = new System.Windows.Forms.LinkLabel();
            this.ShowingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MessageText
            // 
            this.MessageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageText.AutoEllipsis = true;
            this.MessageText.Font = new System.Drawing.Font("Montserrat", 12F);
            this.MessageText.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.MessageText.Location = new System.Drawing.Point(12, 9);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(349, 80);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "Текст";
            this.MessageText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MessageText_LinkClicked);
            this.MessageText.Click += new System.EventHandler(this.MessageText_Click);
            // 
            // ShowingTimer
            // 
            this.ShowingTimer.Tick += new System.EventHandler(this.ShowingTimer_Tick);
            // 
            // PopupMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 98);
            this.Controls.Add(this.MessageText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopupMessageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Новое сообщение";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PopupMessageForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PopupMessageForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel MessageText;
        private System.Windows.Forms.Timer ShowingTimer;
    }
}