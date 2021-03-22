
namespace FhNotifications
{
    partial class FeedMessage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageText = new System.Windows.Forms.LinkLabel();
            this.TimeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Font = new System.Drawing.Font("Montserrat", 12F);
            this.MessageText.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.MessageText.Location = new System.Drawing.Point(3, 3);
            this.MessageText.Margin = new System.Windows.Forms.Padding(3);
            this.MessageText.MaximumSize = new System.Drawing.Size(700, 0);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(193, 27);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "Текст сообщения";
            this.MessageText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MessageText_LinkClicked);
            this.MessageText.MouseEnter += new System.EventHandler(this.FeedMessage_MouseEnter);
            this.MessageText.MouseLeave += new System.EventHandler(this.FeedMessage_MouseLeave);
            // 
            // TimeText
            // 
            this.TimeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeText.AutoSize = true;
            this.TimeText.Font = new System.Drawing.Font("Montserrat", 12F);
            this.TimeText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TimeText.Location = new System.Drawing.Point(727, 3);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(58, 27);
            this.TimeText.TabIndex = 1;
            this.TimeText.Text = "15:30";
            this.TimeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeText.MouseEnter += new System.EventHandler(this.FeedMessage_MouseEnter);
            this.TimeText.MouseLeave += new System.EventHandler(this.FeedMessage_MouseLeave);
            // 
            // FeedMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.MessageText);
            this.MinimumSize = new System.Drawing.Size(800, 2);
            this.Name = "FeedMessage";
            this.Size = new System.Drawing.Size(798, 36);
            this.MouseEnter += new System.EventHandler(this.FeedMessage_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FeedMessage_MouseLeave);
            this.Resize += new System.EventHandler(this.FeedMessage_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel MessageText;
        private System.Windows.Forms.Label TimeText;
    }
}
