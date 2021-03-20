using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FhNotifications
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var mutex = new Mutex(true, Application.ProductName, out bool createdNew))
            {
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
                else
                {
                    MessageBox.Show("Приложение уже было запущенно, возможно оно свёрнуто в трей", "Попытка повторного запуска", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
