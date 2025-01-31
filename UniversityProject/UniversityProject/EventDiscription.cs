﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityProject
{
    public partial class EventDiscription : Form
    {
        private EventsUserControl lastClicked = null!;
        public EventDiscription()
        {
            InitializeComponent();
            DisplayEvents();
            dateLabel.Visible = false;
        }
        private void DisplayEvents()
        {
            eventsFlowLayoutPanel.Controls.Clear();

            foreach (var ev in Session.UserEvents)
            {
                EventsUserControl eventControl = new EventsUserControl();
                eventControl.SetEventData(ev);
                eventControl.Click += UserControl_Click!;
                eventsFlowLayoutPanel.Controls.Add(eventControl);
            }

            if(Session.UserEvents != null)
            {
                messageLabel.Visible = false;
            }
        }
        private void UserControl_Click(object sender, EventArgs e)
        {
            if (sender is EventsUserControl clickedControl)
            {
                titleLabel.Text = clickedControl.title;
                descriptionLabel.Text = clickedControl.description;
                dateLabel.Visible = true;
                dateLabel.Text = clickedControl.date;
                if (clickedControl != null)
                    if (lastClicked != null)
                        lastClicked.BackColor = Color.FromArgb(83, 81, 79);
                clickedControl!.BackColor = Color.FromArgb(63, 61, 59);
                lastClicked = clickedControl;
            }
        }
        public void UserControlClicked(EventsUserControl control)
        {
            titleLabel.Text = control.title;
            descriptionLabel.Text = control.description;
            dateLabel.Visible = true;
            dateLabel.Text = control.date;
            if (control != null)
                if (lastClicked != null)
                    lastClicked.BackColor = Color.FromArgb(83, 81, 79);
            control!.BackColor = Color.FromArgb(63, 61, 59);
            lastClicked = control;
        }
    }
}
