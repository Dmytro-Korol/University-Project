namespace UniversityProject
{
    partial class EventsUserControl
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
            titleControl = new Label();
            label4 = new Label();
            timeControl = new Label();
            SuspendLayout();
            // 
            // titleControl
            // 
            titleControl.AutoSize = true;
            titleControl.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleControl.ForeColor = Color.Transparent;
            titleControl.Location = new Point(3, 10);
            titleControl.Name = "titleControl";
            titleControl.Size = new Size(49, 25);
            titleControl.TabIndex = 2;
            titleControl.Text = "Title";
            titleControl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(3, 57);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 6;
            label4.Text = "Time:";
            // 
            // timeControl
            // 
            timeControl.AutoSize = true;
            timeControl.Font = new Font("Segoe UI Semibold", 10.2000008F, FontStyle.Bold);
            timeControl.ForeColor = Color.Transparent;
            timeControl.Location = new Point(80, 62);
            timeControl.Name = "timeControl";
            timeControl.Size = new Size(44, 19);
            timeControl.TabIndex = 8;
            timeControl.Text = "00:00";
            // 
            // EventsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 81, 79);
            Controls.Add(timeControl);
            Controls.Add(label4);
            Controls.Add(titleControl);
            Margin = new Padding(9, 2, 9, 2);
            Name = "EventsUserControl";
            Size = new Size(291, 94);
            Click += EventsUserControl_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleControl;
        private Label label4;
        private Label timeControl;
    }
}
