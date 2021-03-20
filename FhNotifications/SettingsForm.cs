using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using FhNotifications.Properties;
using FreelancehuntApiClient;
using Microsoft.Win32;

namespace FhNotifications
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            ApiTokenText.Text = Settings.Default.ApiToken;
            LaunchOnSystemStartCheckBox.Checked = Settings.Default.LaunchOnSystemStart;
        }

        private async Task<bool> IsApiTokenCorrect(string token)
        {
            using (var client = new FhClient(token))
            {
                try
                {
                    await client.GetFeed();
                }
                catch (FhRequestException exception)
                {
                    if (exception.Error.Status == 401)
                        return false;
                }
            }

            return true;
        }

        private void ApiTokenTextClearButton_Click(object sender, EventArgs e)
        {
            ApiTokenText.Clear();
        }

        private async Task<DialogResult> SaveChanges()
        {
            if (!string.IsNullOrWhiteSpace(Settings.Default.ApiToken) && ApiTokenText.Text == Settings.Default.ApiToken &&
                LaunchOnSystemStartCheckBox.Checked == Settings.Default.LaunchOnSystemStart)
            {
                return DialogResult.None;
            }

            if (string.IsNullOrWhiteSpace(ApiTokenText.Text))
            {
                MessageBox.Show("Необходимо заполнить поле \"API токен\"", "Заполните поле", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return DialogResult.Cancel;
            }

            if (!HelpClass.CheckForInternetConnection())
            {
                MessageBox.Show("Нет подключения к интернету", "Ошибка доступа к сети", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Cancel;
            }

            if (!(await IsApiTokenCorrect(ApiTokenText.Text)))
            {
                MessageBox.Show("Некорректный API токен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Cancel;
            }

            Settings.Default.ApiToken = ApiTokenText.Text;

            if (Settings.Default.LaunchOnSystemStart != LaunchOnSystemStartCheckBox.Checked)
            {
                if (LaunchOnSystemStartCheckBox.Checked)
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    key.SetValue(ProductName, Application.ExecutablePath);
                }
                else
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    key.DeleteValue(ProductName, false);
                }

                Settings.Default.LaunchOnSystemStart = LaunchOnSystemStartCheckBox.Checked;
            }

            Settings.Default.Save();

            return DialogResult.OK;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            var result = await SaveChanges();
            Invoke(new Action(() =>
            {
                Enabled = true;                

                if (result == DialogResult.OK || result == DialogResult.None)
                {
                    DialogResult = result;
                    Close();
                }
            }));
        }

        private async void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ApiTokenText.Text != Settings.Default.ApiToken ||
                LaunchOnSystemStartCheckBox.Checked != Settings.Default.LaunchOnSystemStart)
            {
                var dialogResult = MessageBox.Show("Вы изменили некоторые поля. Сохранить изменения?", "Вы не сохранили данные", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    Enabled = false;
                    var result = await SaveChanges();
                    Enabled = true;

                    if (result == DialogResult.OK || result == DialogResult.None)
                        DialogResult = result;
                    else
                        e.Cancel = true;
                }
            }
        }

        private void ApiTokenText_TextChanged(object sender, EventArgs e)
        {
            ApiTokenText.Text = ApiTokenText.Text.Trim();
        }
    }
}
