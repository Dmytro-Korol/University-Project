using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityProject.Models;

namespace UniversityProject
{
    public partial class EventsUserControl : UserControl
    {
        public EventsUserControl()
        {

            InitializeComponent();
            this.Click += EventsUserControl_Click!;
        }

        public string title { get; set; } = null!;
        public string? description { get; set; } 
        public string date { get; set; } = null!;
        public void SetEventData(Event ev)
        {
            titleControl.Text = ev.Title;
            timeControl.Text = ev.dateTime.ToString("HH:mm");

            title = ev.Title;
            description = ev.Description;
            date = ev.dateTime.ToString("g");
        }

        private void EventsUserControl_Click(object sender, EventArgs e)
        {
            if (ParentForm is EventDiscription form)
            {
                form.UserControlClicked(this);
            }
        }


    }
}
