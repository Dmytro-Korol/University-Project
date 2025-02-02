namespace UniversityProject
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SwitchFormLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            LogInButton = new Button();
            errorUsername = new Label();
            errorPassword = new Label();
            SuspendLayout();
            // 
            // SwitchFormLabel
            // 
            SwitchFormLabel.AutoSize = true;
            SwitchFormLabel.Cursor = Cursors.Hand;
            SwitchFormLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SwitchFormLabel.ForeColor = Color.Transparent;
            SwitchFormLabel.Location = new Point(10, 28);
            SwitchFormLabel.Name = "SwitchFormLabel";
            SwitchFormLabel.Size = new Size(126, 41);
            SwitchFormLabel.TabIndex = 0;
            SwitchFormLabel.Text = "Sign up";
            SwitchFormLabel.Click += SwitchFormLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(10, 111);
            label2.Name = "label2";
            label2.Size = new Size(118, 31);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(10, 253);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            usernameTextBox.Location = new Point(10, 155);
            usernameTextBox.Margin = new Padding(3, 2, 3, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(401, 39);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordTextBox.Location = new Point(10, 300);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(401, 39);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LogInButton
            // 
            LogInButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogInButton.Location = new Point(12, 416);
            LogInButton.Margin = new Padding(3, 2, 3, 2);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(399, 43);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "Log in";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // errorUsername
            // 
            errorUsername.AutoSize = true;
            errorUsername.ForeColor = Color.Red;
            errorUsername.Location = new Point(12, 196);
            errorUsername.Name = "errorUsername";
            errorUsername.Size = new Size(48, 20);
            errorUsername.TabIndex = 16;
            errorUsername.Text = "label1";
            errorUsername.Visible = false;
            // 
            // errorPassword
            // 
            errorPassword.AutoSize = true;
            errorPassword.ForeColor = Color.Red;
            errorPassword.Location = new Point(12, 341);
            errorPassword.Name = "errorPassword";
            errorPassword.Size = new Size(48, 20);
            errorPassword.TabIndex = 17;
            errorPassword.Text = "label1";
            errorPassword.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 26);
            ClientSize = new Size(423, 516);
            Controls.Add(errorPassword);
            Controls.Add(errorUsername);
            Controls.Add(LogInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SwitchFormLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event Planner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SwitchFormLabel;
        private Label label2;
        private Label label3;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button LogInButton;
        private Label errorUsername;
        private Label errorPassword;
    }
}