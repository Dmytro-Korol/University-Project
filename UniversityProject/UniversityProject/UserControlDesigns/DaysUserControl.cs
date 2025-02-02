 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityProject.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniversityProject
{
    public partial class DaysUserControl : UserControl
    {
        public DateTime Date { get; set; }
        private DateTime nowDate = DateTime.Now;
        private int numOfEvents;

        public DaysUserControl()
        {
            InitializeComponent();
        }

        public void SetEventCount(int count)
        {
            numOfEvents = count;
            numberOfEvents.Text = count > 0 ? $"Number of events: {count}" : "";
        }
        public void Days(int numOfDay, DateTime ran)
        {
            Date = ran;
            labelDay.Text = numOfDay.ToString();
        }
        private void ShowEventsForms()
        {
            if (Date.Date >= nowDate.Date)
            {
                EventPlanner eventPlanner = new EventPlanner();
                eventPlanner.GetDate(Date);
                eventPlanner.ShowDialog();
            }
            else if (numOfEvents > 0)
            {
                DateTime date = Date.Date;
                using (AppDbContext db = new AppDbContext())
                {
                    Session.UserEvents = db.Events.Where(e => e
                    .UserId == Session.LoggedInUserId).Where(e => e
                    .dateTime.Date == date)
                    .OrderBy(e => e.dateTime).ToList();
                }
                EventDescription eventdiscription = new EventDescription();
                eventdiscription.ShowDialog();
            }
            else
            {
                if (Date.Month < nowDate.Month)
                {
                    var year = nowDate.Year - Date.Year + 1;
                    MessageBox.Show($"Your event will be create for the {nowDate.AddYears(year)} Year");
                    EventPlanner eventPlanner = new EventPlanner();
                    eventPlanner.GetDate(Date.AddYears(year));
                    eventPlanner.ShowDialog();
                }
                else if (Date.Month >= nowDate.Month)
                {
                    MessageBox.Show($"Your event will be create for the {nowDate.Year} Year");
                    EventPlanner eventPlanner = new EventPlanner();
                    var year = nowDate.Year - Date.Year;
                    eventPlanner.GetDate(Date.AddYears(year));
                    eventPlanner.ShowDialog();
                }
            }
        }

        private void DaysUserControl_Click(object sender, EventArgs e)
        {
            ShowEventsForms();
        }

        private void numberOfEvents_Click(object sender, EventArgs e)
        {
            ShowEventsForms();
        }

        private void labelDay_Click(object sender, EventArgs e)
        {
            ShowEventsForms();
        }
    }
}
