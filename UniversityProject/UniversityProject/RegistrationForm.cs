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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            this.usernameTextBox.AutoSize = false;
            this.passwordTextBox.AutoSize = false;
            this.usernameTextBox.Size = new Size(this.usernameTextBox.Width, 40);
            this.passwordTextBox.Size = new Size(this.passwordTextBox.Width, 40);
        }
    }
}
