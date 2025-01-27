namespace UniversityProject
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
            SuspendLayout();
            // 
            // SignUpButton
            // 
            SignUpButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SignUpButton.Location = new Point(11, 383);
            SignUpButton.Margin = new Padding(3, 2, 3, 2);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(373, 34);
            SignUpButton.TabIndex = 11;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConfirmPasswordTextBox.Location = new Point(9, 318);
            ConfirmPasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(373, 29);
            ConfirmPasswordTextBox.TabIndex = 10;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            usernameTextBox.Location = new Point(11, 144);
            usernameTextBox.Margin = new Padding(3, 2, 3, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(373, 29);
            usernameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(11, 189);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
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
            label2.Size = new Size(98, 25);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // SwitchFormLabel
            // 
            SwitchFormLabel.AutoSize = true;
            SwitchFormLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SwitchFormLabel.ForeColor = Color.Transparent;
            SwitchFormLabel.Location = new Point(11, 39);
            SwitchFormLabel.Name = "SwitchFormLabel";
            SwitchFormLabel.Size = new Size(85, 32);
            SwitchFormLabel.TabIndex = 6;
            SwitchFormLabel.Text = "Log in";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTextBox.Location = new Point(11, 229);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(373, 29);
            PasswordTextBox.TabIndex = 12;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(9, 276);
            label4.Name = "label4";
            label4.Size = new Size(166, 25);
            label4.TabIndex = 13;
            label4.Text = "Confirm Password";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 26);
            ClientSize = new Size(394, 454);
            Controls.Add(label4);
            Controls.Add(PasswordTextBox);
            Controls.Add(SignUpButton);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SwitchFormLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event Planner";
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
    }
}