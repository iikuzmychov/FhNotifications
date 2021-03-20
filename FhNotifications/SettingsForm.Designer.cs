
namespace FhNotifications
{
    partial class SettingsForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ApiTokenText = new System.Windows.Forms.TextBox();
            this.ApiTokenTextClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LaunchOnSystemStartCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "API токен:";
            // 
            // ApiTokenText
            // 
            this.ApiTokenText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApiTokenText.Font = new System.Drawing.Font("Montserrat", 12F);
            this.ApiTokenText.Location = new System.Drawing.Point(133, 12);
            this.ApiTokenText.Name = "ApiTokenText";
            this.ApiTokenText.Size = new System.Drawing.Size(476, 32);
            this.ApiTokenText.TabIndex = 1;
            this.ApiTokenText.TabStop = false;
            this.ApiTokenText.TextChanged += new System.EventHandler(this.ApiTokenText_TextChanged);
            // 
            // ApiTokenTextClearButton
            // 
            this.ApiTokenTextClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApiTokenTextClearButton.Font = new System.Drawing.Font("Montserrat", 12F);
            this.ApiTokenTextClearButton.Location = new System.Drawing.Point(615, 11);
            this.ApiTokenTextClearButton.Name = "ApiTokenTextClearButton";
            this.ApiTokenTextClearButton.Size = new System.Drawing.Size(34, 34);
            this.ApiTokenTextClearButton.TabIndex = 2;
            this.ApiTokenTextClearButton.Text = "X";
            this.ApiTokenTextClearButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ApiTokenTextClearButton.UseVisualStyleBackColor = true;
            this.ApiTokenTextClearButton.Click += new System.EventHandler(this.ApiTokenTextClearButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Font = new System.Drawing.Font("Montserrat", 12F);
            this.SaveButton.Location = new System.Drawing.Point(506, 87);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(143, 50);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.TabStop = false;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LaunchOnSystemStartCheckBox
            // 
            this.LaunchOnSystemStartCheckBox.AutoSize = true;
            this.LaunchOnSystemStartCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LaunchOnSystemStartCheckBox.Font = new System.Drawing.Font("Montserrat", 12F);
            this.LaunchOnSystemStartCheckBox.Location = new System.Drawing.Point(12, 54);
            this.LaunchOnSystemStartCheckBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.LaunchOnSystemStartCheckBox.Name = "LaunchOnSystemStartCheckBox";
            this.LaunchOnSystemStartCheckBox.Size = new System.Drawing.Size(350, 31);
            this.LaunchOnSystemStartCheckBox.TabIndex = 4;
            this.LaunchOnSystemStartCheckBox.Text = "Запускать при старте системы";
            this.LaunchOnSystemStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 149);
            this.Controls.Add(this.LaunchOnSystemStartCheckBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ApiTokenTextClearButton);
            this.Controls.Add(this.ApiTokenText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ApiTokenText;
        private System.Windows.Forms.Button ApiTokenTextClearButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox LaunchOnSystemStartCheckBox;
    }
}

