using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ALMIS.Viewer
{
    public partial class DateFilterForm : Telerik.WinControls.UI.RadForm
    {
        public DateFilterForm()
        {
            InitializeComponent();
        }


        private void DateFilterForm_Load(object sender, EventArgs e)
        {
            lblCurrentYear.Text = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture);
            lblCurrentMonth.Text = DateTime.Now.Month.ToString(CultureInfo.InvariantCulture);
            lblCurrentWeek.Text =
                CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek,
                    DayOfWeek.Monday).ToString(CultureInfo.InvariantCulture);
            lblDayOfMonth.Text = DateTime.Now.Day.ToString(CultureInfo.InvariantCulture);
            lblDayOfWeek.Text = DateTime.Now.DayOfWeek.ToString();
            lblDayOfYear.Text = DateTime.Now.DayOfYear.ToString(CultureInfo.InvariantCulture);
            nupFromWeek.Text = (Convert.ToInt32(lblCurrentWeek.Text) - 1).ToString(CultureInfo.InvariantCulture);
            nupToWeek.Text = nupFromWeek.Text;
            nupFromYear.Text = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture);
            nupToYear.Text = nupFromYear.Text;
        }

        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }

        public void SetFromDateTime(DateTime from)
        {
            FromDateTime = from;
        }

        public void SetToDateTime(DateTime to)
        {
            ToDateTime = to;
        }

        private void rbWeek_CheckedChanged(object sender, EventArgs e)
        {
            lblFromWeek.Text = "From Week:";
            lblToWeek.Text = "To Week:";
            nupFromWeek.Text = (Convert.ToInt32(lblCurrentWeek.Text) - 1).ToString(CultureInfo.InvariantCulture);
            nupToWeek.Text = nupFromWeek.Text;
            nupFromYear.Text = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture);
            nupToYear.Text = nupFromYear.Text;
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            lblFromWeek.Text = "From Month:";
            lblToWeek.Text = "To Month:";
            nupFromWeek.Text = (Convert.ToInt32(lblCurrentMonth.Text) - 1).ToString(CultureInfo.InvariantCulture);
            nupToWeek.Text = nupFromWeek.Text;
            nupFromYear.Text = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture);
            nupToYear.Text = nupFromYear.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbWeek.Checked)
            {
                FromDateTime = FirstDateOfWeek(int.Parse(nupFromWeek.Text), int.Parse(nupFromYear.Text));
                ToDateTime = FirstDateOfWeek(int.Parse(nupToWeek.Text), int.Parse(nupToYear.Text)).AddDays(6);
            }
            else if (rbMonth.Checked)
            {
                FromDateTime = new DateTime(int.Parse(nupFromYear.Text), int.Parse(nupFromWeek.Text), 1);
                ToDateTime = new DateTime(int.Parse(nupToYear.Text), int.Parse(nupToWeek.Text), GetDaysForMonth(int.Parse(nupToWeek.Text), int.Parse(nupToYear.Text)));
            }

        }


        public int GetDaysForMonth(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);

        }

        public DateTime FirstDateOfWeek(int weekOfYear, int year)
        {
            var jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            var firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            if (firstWeek <= 1)
            {
                weekNum -= 1;
            }
            var result = firstThursday.AddDays(weekNum * 7);
            return result.AddDays(-3);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
