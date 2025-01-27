using System;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;

namespace UniversityProject
{
    public partial class Form1 : Form
    {
        public Form1()
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
            for (var i = 1; i < numDay; i++)                            
            {                                                           
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

        private void SetAdaptiveMinimumSize()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;

            int minWidth = Math.Max((int)(screenBounds.Width), 800);  
            int minHeight = Math.Max((int)(screenBounds.Height), 600); 

            this.MinimumSize = new Size(minWidth, minHeight);
        }
    }
}
