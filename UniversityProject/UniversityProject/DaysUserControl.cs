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
        public DateTime Date {  get; set; }

        public DaysUserControl()
        {
            InitializeComponent();
        }

        private void DaysUserControl_Load(object sender, EventArgs e)
        {

        }
        public void Days(int numOfDay, DateTime ran)
        {
            Date = ran;
            labelDay.Text = numOfDay.ToString();
        }

        private void DaysUserControl_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{date}");
            EventPlanner eventPlanner = new EventPlanner();
            eventPlanner.GetDate(Date);
            eventPlanner.ShowDialog();
        }
    }
}
