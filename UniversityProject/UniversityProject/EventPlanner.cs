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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


    }
}
