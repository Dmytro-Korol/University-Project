namespace UniversityProject
{
    partial class DaysUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelDay = new Label();
            numberOfEvents = new Label();
            SuspendLayout();
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.ForeColor = Color.White;
            labelDay.Location = new Point(17, 14);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(19, 15);
            labelDay.TabIndex = 0;
            labelDay.Text = "00";
            // 
            // numberOfEvents
            // 
            numberOfEvents.AutoSize = true;
            numberOfEvents.Location = new Point(3, 53);
            numberOfEvents.Name = "numberOfEvents";
            numberOfEvents.Size = new Size(38, 15);
            numberOfEvents.TabIndex = 1;
            numberOfEvents.Text = "label1";
            // 
            // DaysUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 81, 79);
            Controls.Add(numberOfEvents);
            Controls.Add(labelDay);
            Margin = new Padding(9, 8, 9, 8);
            Name = "DaysUserControl";
            Size = new Size(113, 68);
            Load += DaysUserControl_Load;
            Click += DaysUserControl_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDay;
        private Label numberOfEvents;
    }
}
