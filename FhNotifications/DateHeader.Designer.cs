
namespace FhNotifications
{
    partial class DateHeader
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
            this.DateText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateText
            // 
            this.DateText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateText.Font = new System.Drawing.Font("Montserrat", 12F);
            this.DateText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DateText.Location = new System.Drawing.Point(0, 0);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(800, 36);
            this.DateText.TabIndex = 2;
            this.DateText.Text = "23.02.2021";
            this.DateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.DateText);
            this.MinimumSize = new System.Drawing.Size(0, 36);
            this.Name = "DateHeader";
            this.Size = new System.Drawing.Size(800, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DateText;
    }
}
