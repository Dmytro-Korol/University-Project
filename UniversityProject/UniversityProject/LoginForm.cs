using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using UniversityProject.Data;

namespace UniversityProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.usernameTextBox.AutoSize = false;
            this.passwordTextBox.AutoSize = false;
            this.usernameTextBox.Size = new Size(this.usernameTextBox.Width, 40);
            this.passwordTextBox.Size = new Size(this.passwordTextBox.Width, 40);
        }
        public int userId;

        private void SwitchFormLabel_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            this.Hide();
            signupForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameTextBox.Text;
            string enteredPassword = passwordTextBox.Text;
            string hashedPasswordfromDb = null!;

            bool isValid = false;   
            var textboxEmpty = false;

            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                errorUsername.Text = "Please fill out all fields";
                errorUsername.Visible = true;
                textboxEmpty = true;
            }

            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                errorPassword.Text = "Please fill out all fields";
                errorPassword.Visible = true;
                textboxEmpty = true;
            }

            if (textboxEmpty)
            {
                return;
            }

            using (AppDbContext db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Name == enteredUsername);
                if (user != null)
                {
                    hashedPasswordfromDb = user.Password;
                    Session.LoggedInUserId = user.Id;
                }
                else
                {
                    errorUsername.Text = "Invalid Username!";
                    errorUsername.Visible = true;
                    return;
                }

                isValid = BCrypt.Net.BCrypt.Verify(enteredPassword, hashedPasswordfromDb);
            }

            if(!isValid)
            {
                MessageBox.Show("Incorrect password \nAccess denied");
                return;
            }
            else
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
            
            
        }
    }
}
