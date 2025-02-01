using Microsoft.VisualBasic.ApplicationServices;
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
using UniversityProject.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniversityProject
{
    public partial class EventPlanner : Form
    {
        public DateTime Date;
        public EventPlanner()
        {
            InitializeComponent();
        }

        public void GetDate(DateTime date)
        {
            Date = date;
            dateTimePicker.Value = Date;
            dateLabel.Text = date.ToString("d");
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            errorTitle.Visible = false;
            string title = titleTextBox.Text;
            string description = descriptonTextBox.Text;
            DateTime date = dateTimePicker.Value;
            var userId = Session.LoggedInUserId;
            if (string.IsNullOrEmpty(title))
            {
                errorTitle.Text = "Plesase enter the title";
                errorTitle.Visible = true;
                return;
            }
            using (AppDbContext db = new AppDbContext())
            {
                var newEvent = new Event
                {
                    Title = title,
                    Description = description,
                    dateTime = date,
                    UserId = userId,
                };


                db.Events.Add(newEvent);
                db.SaveChanges();
            }
            Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault()!;
            if (mainForm != null)
            {
                mainForm.LoadEvents();
            }
            this.Close();
            
        }


        private void viewEventsButton_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value.Date;
            using (AppDbContext db = new AppDbContext())
            {
                Session.UserEvents = db.Events.Where(e => e
                .UserId == Session.LoggedInUserId ).Where (e => e
                .dateTime.Date == date)
                .OrderBy(e => e.dateTime).ToList();
            }
            EventDiscription eventdiscription = new EventDiscription();
            this.Hide();
            eventdiscription.ShowDialog();
            this.Close();
        }
    }
}
