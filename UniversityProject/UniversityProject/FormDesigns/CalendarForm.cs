using System;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using UniversityProject.Data;
using UniversityProject.Models;

namespace UniversityProject
{
    public partial class CalendarForm : Form
    {
        public CalendarForm()
        {
            InitializeComponent();

            //SetAdaptiveMinimumSize();
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

            CultureInfo englishCulture = new CultureInfo("en-US");
            var monthName = englishCulture.DateTimeFormat.MonthNames[month - 1];

            monthYearLabel.Text = monthName + " " + year;

            var firstDayOfTheMonth = new DateTime(year, month, 1);

            var daysInMonth = DateTime.DaysInMonth(year, month);

            var numDay = int.Parse(firstDayOfTheMonth.DayOfWeek.ToString("d"));

            numDay = numDay == 0 ? 7 : numDay;

            List<Event> UserEventsAll;
            using (AppDbContext db = new AppDbContext())
            {
                UserEventsAll = db.Events.Where(e => e.UserId == Session.LoggedInUserId
                && e.dateTime.Month == month
                && e.dateTime.Year == year).ToList();
            }


            for (var i = 1; i < numDay; i++)
            {
                BlankUserControl blank = new BlankUserControl();
                dayContainer.Controls.Add(blank);
            }
            for (var i = 1; i < daysInMonth + 1; i++)
            {
                DateTime currentDate = firstDayOfTheMonth.AddDays(i - 1);

                DaysUserControl day = new DaysUserControl();
                day.Days(i, currentDate);

                int eventCount = UserEventsAll.Count(e => e.dateTime.Date == currentDate.Date);
                day.SetEventCount(eventCount);

                dayContainer.Controls.Add(day);
            }
        }

        private void NextPage()
        {
            dayContainer.Controls.Clear();
            month++;
            if (month > 12) { year++; month = 1; }
            DisplayDays();
        }

        private void PrevPage()
        {
            dayContainer.Controls.Clear();
            month--;
            if (month < 1) { year--; month = 12; }
            DisplayDays();
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void prevPageButton_Click(object sender, EventArgs e)
        {
            PrevPage();
        }


        private void nextPageLabel_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void prevPageLabel_Click(object sender, EventArgs e)
        {
            PrevPage();
        }

        public void LoadEvents()
        {
            this.Controls.Clear();
            InitializeComponent();
            DisplayDays();
            this.Refresh();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
