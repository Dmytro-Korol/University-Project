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
            label1 = new Label();
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 68);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // DaysUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 81, 79);
            Controls.Add(label1);
            Controls.Add(labelDay);
            Margin = new Padding(10);
            Name = "DaysUserControl";
            Size = new Size(129, 91);
            Load += DaysUserControl_Load;
            Click += DaysUserControl_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDay;
        private Label label1;
    }
}
