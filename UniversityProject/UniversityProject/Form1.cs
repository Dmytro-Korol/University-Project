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

        private void DisplayDays()
        {
            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;

            var date = DateTime.Now;

            var firstDayOfTheMonth = new DateTime(year, month, 1);

            var daysInMonth = DateTime.DaysInMonth(year, month);

            var numDay = int.Parse(firstDayOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (var i = 1; i < numDay; i++)
            {
                BlankUserControl blank = new BlankUserControl();
                dayContainer.Controls.Add(blank);
            }
            for (var i = 1; i < daysInMonth+1; i++)
            {
                DaysUserControl day = new DaysUserControl();
                day.Days(i, firstDayOfTheMonth.AddDays(i-1));
                dayContainer.Controls.Add(day);
            }
        }
    }
}
