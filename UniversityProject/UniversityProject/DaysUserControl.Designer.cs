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
            labelDay.Location = new Point(19, 19);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(25, 20);
            labelDay.TabIndex = 0;
            labelDay.Text = "00";
            labelDay.Click += labelDay_Click;
            // 
            // numberOfEvents
            // 
            numberOfEvents.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberOfEvents.ForeColor = Color.MistyRose;
            numberOfEvents.Location = new Point(0, 50);
            numberOfEvents.Name = "numberOfEvents";
            numberOfEvents.Size = new Size(129, 41);
            numberOfEvents.TabIndex = 1;
            numberOfEvents.Text = "label1";
            numberOfEvents.Click += numberOfEvents_Click;
            // 
            // DaysUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 81, 79);
            Controls.Add(numberOfEvents);
            Controls.Add(labelDay);
            Margin = new Padding(10, 11, 10, 11);
            Name = "DaysUserControl";
            Size = new Size(129, 91);
            Click += DaysUserControl_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDay;
        private Label numberOfEvents;
    }
}
