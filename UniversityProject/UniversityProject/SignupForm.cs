using Azure.Identity;
using Microsoft.Identity.Client;
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
using BCrypt.Net;

namespace UniversityProject
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();


        }

        private void SwitchFormLabel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;
            errorUsername.Visible = false;
            errorPassword.Visible = false;
            errorConfirm.Visible = false;
            var textboxEmpty = false;

            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                errorUsername.Text = "Please fill out all fields";
                errorUsername.Visible = true;
                textboxEmpty = true;
            }

            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                errorPassword.Text = "Please fill out all fields";
                errorPassword.Visible = true;
                textboxEmpty = true;
            }

            if (string.IsNullOrEmpty(ConfirmPasswordTextBox.Text))
            {
                errorConfirm.Text = "Please fill out all fields";
                errorConfirm.Visible = true;
                textboxEmpty = true;
            }

            if (textboxEmpty)
            {
                return;
            }

            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                errorConfirm.Text = "Passwords don't maching";
                errorConfirm.Visible = true;
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password); 

            var user = new User
            {
                Name = username,
                Password = hashedPassword,
            };
            try
            {
                using (AppDbContext db = new AppDbContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();

                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();
                    usernameTextBox.Clear();
                    PasswordTextBox.Clear();
                    ConfirmPasswordTextBox.Clear();
                }
            }
            catch(Microsoft.EntityFrameworkCore.DbUpdateException)
            {
                errorUsername.Text = "Username already exists!";
                errorUsername.Visible = true;
            }
        }

    }
}
