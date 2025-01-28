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
    public partial class EventPlanner : Form
    {
        DateTime date;
        public EventPlanner()
        {
            InitializeComponent();
            DaysUserControl dayControl = new DaysUserControl();
            date = dayControl.Date();
            dateLabel.Text = date.ToString();
        }


    }
}
