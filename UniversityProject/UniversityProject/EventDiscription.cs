using System;
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
        public EventDiscription()
        {
            InitializeComponent();
            DisplayEvents();
        }

        private void DisplayEvents()
        {
            var test = true;
            if (!test)
            {
                return;
            }
            else
            {
                messageLabel.Visible = false;
                for (int i = 0; i < 4; i++)
                {
                    EventsUserControl newEvent = new EventsUserControl();
                    eventsFlowLayoutPanel.Controls.Add(newEvent);
                }
            }
        }
            
        
    }
}
