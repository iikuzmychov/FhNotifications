using System;
using System.Globalization;
using System.Windows.Forms;

namespace FhNotifications
{
    public partial class DateHeader : UserControl
    {
        public DateHeader(DateTime date)
        {
            InitializeComponent();

            DateText.Text = DateToString(date);
        }

        private string DateToString(DateTime date)
        {
            if (date.Date == DateTime.Today)
                return "Сегодня";
            else if (date.Date.AddDays(1) == DateTime.Today)
                return "Вчера";
            else if (date.Date.AddDays(5) >= DateTime.Today)
                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName(date.DayOfWeek));
            else if (date.Year == DateTime.Today.Year)
                return date.ToString(@"dd\.MM");
            else
                return date.ToString(@"dd\.MM\.yyyy");
        }
    }
}
