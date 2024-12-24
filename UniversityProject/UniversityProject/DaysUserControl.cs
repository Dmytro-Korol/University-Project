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
            label1.Text = date.ToString();
            
        }

        private void DaysUserControl_Click(object sender, EventArgs e)
        {
            //label1.Text = "Hello";
            MessageBox.Show($"{date}");
        }
    }
}
