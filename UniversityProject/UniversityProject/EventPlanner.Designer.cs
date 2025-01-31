namespace UniversityProject
{
    partial class EventPlanner
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
            label1 = new Label();
            label2 = new Label();
            titleTextBox = new TextBox();
            label3 = new Label();
            descriptonTextBox = new TextBox();
            label4 = new Label();
            dateLabel = new Label();
            dateTimePicker = new DateTimePicker();
            createButton = new Button();
            errorTitle = new Label();
            viewEventsButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(339, 41);
            label1.TabIndex = 0;
            label1.Text = "Create event";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(10, 47);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(10, 73);
            titleTextBox.Margin = new Padding(3, 2, 3, 2);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(318, 23);
            titleTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(10, 111);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // descriptonTextBox
            // 
            descriptonTextBox.Location = new Point(10, 136);
            descriptonTextBox.Margin = new Padding(3, 2, 3, 2);
            descriptonTextBox.Multiline = true;
            descriptonTextBox.Name = "descriptonTextBox";
            descriptonTextBox.ScrollBars = ScrollBars.Vertical;
            descriptonTextBox.Size = new Size(318, 98);
            descriptonTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(10, 253);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 5;
            label4.Text = "Date and time:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dateLabel.ForeColor = Color.Transparent;
            dateLabel.Location = new Point(151, 255);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(90, 21);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "00.00.0000";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarForeColor = Color.FromArgb(25, 25, 26);
            dateTimePicker.CalendarMonthBackground = Color.FromArgb(25, 25, 26);
            dateTimePicker.CalendarTitleBackColor = Color.FromArgb(25, 25, 26);
            dateTimePicker.CalendarTitleForeColor = Color.FromArgb(25, 25, 26);
            dateTimePicker.CalendarTrailingForeColor = Color.FromArgb(25, 25, 26);
            dateTimePicker.CustomFormat = "H m";
            dateTimePicker.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.ImeMode = ImeMode.NoControl;
            dateTimePicker.Location = new Point(253, 255);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.RightToLeft = RightToLeft.No;
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.Size = new Size(73, 25);
            dateTimePicker.TabIndex = 7;
            dateTimePicker.Value = new DateTime(2025, 1, 28, 0, 0, 0, 0);
            // 
            // createButton
            // 
            createButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            createButton.Location = new Point(217, 316);
            createButton.Name = "createButton";
            createButton.Size = new Size(110, 35);
            createButton.TabIndex = 8;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // errorTitle
            // 
            errorTitle.AutoSize = true;
            errorTitle.ForeColor = Color.Red;
            errorTitle.Location = new Point(12, 98);
            errorTitle.Name = "errorTitle";
            errorTitle.Size = new Size(38, 15);
            errorTitle.TabIndex = 16;
            errorTitle.Text = "label1";
            errorTitle.Visible = false;
            // 
            // viewEventsButton
            // 
            viewEventsButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            viewEventsButton.Location = new Point(12, 316);
            viewEventsButton.Name = "viewEventsButton";
            viewEventsButton.Size = new Size(155, 35);
            viewEventsButton.TabIndex = 17;
            viewEventsButton.Text = "View events";
            viewEventsButton.UseVisualStyleBackColor = true;
            viewEventsButton.Click += viewEventsButton_Click;
            // 
            // EventPlanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 26);
            ClientSize = new Size(339, 361);
            Controls.Add(viewEventsButton);
            Controls.Add(errorTitle);
            Controls.Add(createButton);
            Controls.Add(dateTimePicker);
            Controls.Add(dateLabel);
            Controls.Add(label4);
            Controls.Add(descriptonTextBox);
            Controls.Add(label3);
            Controls.Add(titleTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EventPlanner";
            Text = "EventPlanner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox titleTextBox;
        private Label label3;
        private TextBox descriptonTextBox;
        private Label label4;
        private Label dateLabel;
        private DateTimePicker dateTimePicker;
        private Button createButton;
        private Label errorTitle;
        private Button viewEventsButton;
    }
}