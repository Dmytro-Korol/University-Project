using System.Globalization;

namespace UniversityProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        int year = DateTime.Now.Year;
        int month = DateTime.Now.Month;
        private void DisplayDays()
        {
            //var date = DateTime.Now;

            var monthName = DateTimeFormatInfo.CurrentInfo.MonthNames[month-1];
            monthYearLabel.Text = monthName + " " + year;

            var firstDayOfTheMonth = new DateTime(year, month, 1);

            var daysInMonth = DateTime.DaysInMonth(year, month);

            var numDay = int.Parse(firstDayOfTheMonth.DayOfWeek.ToString("d"));

            numDay = numDay == 0 ? 7 : numDay;
            for (var i = 1; i < numDay; i++)                            //TO DO "display last days of prev month on free space
            {                                                           //       instead of blankUserControl"
                BlankUserControl blank = new BlankUserControl();
                dayContainer.Controls.Add(blank);
            }
            for (var i = 1; i < daysInMonth + 1; i++)
            {
                DaysUserControl day = new DaysUserControl();
                day.Days(i, firstDayOfTheMonth.AddDays(i - 1));
                dayContainer.Controls.Add(day);
            }
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            month++;
            if (month > 12) { year++; month = 1; }
            DisplayDays();
        }

        private void prevPageButton_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            month--;
            if (month < 1) { year--; month = 12; }
            DisplayDays();
        }
    }
}
