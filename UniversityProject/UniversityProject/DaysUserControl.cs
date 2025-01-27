 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniversityProject
{
    public partial class DaysUserControl : UserControl
    {
        public DaysUserControl()
        {
            InitializeComponent();
        }

        private void DaysUserControl_Load(object sender, EventArgs e)
        {

        }
        public DateTime date;
        public void Days(int numOfDay, DateTime ran)
        {
            date = ran;
            labelDay.Text = numOfDay.ToString();
        }

        public DateTime Date()
        {
            return date;
        }

        private void DaysUserControl_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{date}");
            EventPlanner eventPlanner = new EventPlanner();
            eventPlanner.ShowDialog();
        }
    }
}
