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
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            dateLabel = new Label();
            dateTimePicker = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(387, 55);
            label1.TabIndex = 0;
            label1.Text = "Create event";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(11, 63);
            label2.Name = "label2";
            label2.Size = new Size(59, 31);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(11, 148);
            label3.Name = "label3";
            label3.Size = new Size(134, 31);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 181);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(363, 129);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(11, 337);
            label4.Name = "label4";
            label4.Size = new Size(166, 31);
            label4.TabIndex = 5;
            label4.Text = "Date and time:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dateLabel.ForeColor = Color.Transparent;
            dateLabel.Location = new Point(173, 340);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(110, 28);
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
            dateTimePicker.Location = new Point(289, 340);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.RightToLeft = RightToLeft.No;
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.Size = new Size(83, 30);
            dateTimePicker.TabIndex = 7;
            dateTimePicker.Value = new DateTime(2025, 1, 28, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button1.Location = new Point(248, 421);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(126, 47);
            button1.TabIndex = 8;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EventPlanner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 26);
            ClientSize = new Size(387, 481);
            Controls.Add(button1);
            Controls.Add(dateTimePicker);
            Controls.Add(dateLabel);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EventPlanner";
            Text = "EventPlanner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label dateLabel;
        private DateTimePicker dateTimePicker;
        private Button button1;
    }
}