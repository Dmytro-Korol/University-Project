﻿namespace UniversityProject
{
    partial class SignupForm
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
            SignUpButton = new Button();
            ConfirmPasswordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SwitchFormLabel = new Label();
            PasswordTextBox = new TextBox();
            label4 = new Label();
            errorConfirm = new Label();
            errorUsername = new Label();
            errorPassword = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // SignUpButton
            // 
            SignUpButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SignUpButton.Location = new Point(12, 463);
            SignUpButton.Margin = new Padding(3, 2, 3, 2);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(395, 40);
            SignUpButton.TabIndex = 11;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConfirmPasswordTextBox.Location = new Point(12, 361);
            ConfirmPasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(398, 34);
            ConfirmPasswordTextBox.TabIndex = 10;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            usernameTextBox.Location = new Point(11, 144);
            usernameTextBox.Margin = new Padding(3, 2, 3, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(396, 34);
            usernameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(12, 211);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(11, 109);
            label2.Name = "label2";
            label2.Size = new Size(118, 31);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // SwitchFormLabel
            // 
            SwitchFormLabel.AutoSize = true;
            SwitchFormLabel.Cursor = Cursors.Hand;
            SwitchFormLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SwitchFormLabel.ForeColor = Color.Transparent;
            SwitchFormLabel.Location = new Point(11, 39);
            SwitchFormLabel.Name = "SwitchFormLabel";
            SwitchFormLabel.Size = new Size(105, 41);
            SwitchFormLabel.TabIndex = 6;
            SwitchFormLabel.Text = "Log in";
            SwitchFormLabel.Click += SwitchFormLabel_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTextBox.Location = new Point(12, 251);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(396, 34);
            PasswordTextBox.TabIndex = 12;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(12, 319);
            label4.Name = "label4";
            label4.Size = new Size(202, 31);
            label4.TabIndex = 13;
            label4.Text = "Confirm Password";
            // 
            // errorConfirm
            // 
            errorConfirm.AutoSize = true;
            errorConfirm.ForeColor = Color.Red;
            errorConfirm.Location = new Point(15, 397);
            errorConfirm.Name = "errorConfirm";
            errorConfirm.Size = new Size(48, 20);
            errorConfirm.TabIndex = 14;
            errorConfirm.Text = "label1";
            errorConfirm.Visible = false;
            // 
            // errorUsername
            // 
            errorUsername.AutoSize = true;
            errorUsername.ForeColor = Color.Red;
            errorUsername.Location = new Point(12, 180);
            errorUsername.Name = "errorUsername";
            errorUsername.Size = new Size(48, 20);
            errorUsername.TabIndex = 15;
            errorUsername.Text = "label1";
            errorUsername.Visible = false;
            // 
            // errorPassword
            // 
            errorPassword.AutoSize = true;
            errorPassword.ForeColor = Color.Red;
            errorPassword.Location = new Point(13, 287);
            errorPassword.Name = "errorPassword";
            errorPassword.Size = new Size(48, 20);
            errorPassword.TabIndex = 16;
            errorPassword.Text = "label1";
            errorPassword.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(140, 39);
            label1.Name = "label1";
            label1.Size = new Size(156, 46);
            label1.TabIndex = 17;
            label1.Text = "⬅  Go to";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 26);
            ClientSize = new Size(419, 548);
            Controls.Add(label1);
            Controls.Add(errorPassword);
            Controls.Add(errorUsername);
            Controls.Add(errorConfirm);
            Controls.Add(label4);
            Controls.Add(PasswordTextBox);
            Controls.Add(SignUpButton);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SwitchFormLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event Planner(Sign up)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignUpButton;
        private TextBox ConfirmPasswordTextBox;
        private TextBox usernameTextBox;
        private Label label3;
        private Label label2;
        private Label SwitchFormLabel;
        private TextBox PasswordTextBox;
        private Label label4;
        private Label errorConfirm;
        private Label errorUsername;
        private Label errorPassword;
        private Label label1;
    }
}