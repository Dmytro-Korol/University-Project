namespace UniversityProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dayContainer = new FlowLayoutPanel();
            nextPageButton = new Button();
            prevPageButton = new Button();
            monthYearLabel = new Label();
            nextPageLabel = new Label();
            prevPageLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.Font = new Font("Georgia", 13.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(127, 72);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.MaximumSize = new Size(129, 35);
            label1.MinimumSize = new Size(129, 35);
            label1.Name = "label1";
            label1.Size = new Size(129, 35);
            label1.TabIndex = 0;
            label1.Text = "Monday";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.Font = new Font("Georgia", 13.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(277, 72);
            label2.Margin = new Padding(10, 0, 10, 0);
            label2.MaximumSize = new Size(129, 35);
            label2.MinimumSize = new Size(129, 35);
            label2.Name = "label2";
            label2.Size = new Size(129, 35);
            label2.TabIndex = 1;
            label2.Text = "Tuesday";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.Font = new Font("Georgia", 13.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(426, 72);
            label3.Margin = new Padding(10, 0, 10, 0);
            label3.MaximumSize = new Size(129, 35);
            label3.MinimumSize = new Size(129, 35);
            label3.Name = "label3";
            label3.Size = new Size(129, 35);
            label3.TabIndex = 2;
            label3.Text = "Wednesday";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.Font = new Font("Georgia", 13.8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(574, 72);
            label4.Margin = new Padding(10, 0, 10, 0);
            label4.MaximumSize = new Size(129, 35);
            label4.MinimumSize = new Size(129, 35);
            label4.Name = "label4";
            label4.Size = new Size(129, 35);
            label4.TabIndex = 3;
            label4.Text = "Thursday";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.Font = new Font("Georgia", 13.8F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(724, 72);
            label5.Margin = new Padding(10, 0, 10, 0);
            label5.MaximumSize = new Size(129, 35);
            label5.MinimumSize = new Size(129, 35);
            label5.Name = "label5";
            label5.Size = new Size(129, 35);
            label5.TabIndex = 4;
            label5.Text = "Friday";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.Font = new Font("Georgia", 13.8F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(872, 72);
            label6.Margin = new Padding(10, 0, 10, 0);
            label6.MaximumSize = new Size(129, 35);
            label6.MinimumSize = new Size(129, 35);
            label6.Name = "label6";
            label6.Size = new Size(129, 35);
            label6.TabIndex = 5;
            label6.Text = "Saturday";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.Font = new Font("Georgia", 13.8F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1022, 72);
            label7.Margin = new Padding(10, 0, 10, 0);
            label7.MaximumSize = new Size(129, 35);
            label7.MinimumSize = new Size(129, 35);
            label7.Name = "label7";
            label7.Size = new Size(129, 35);
            label7.TabIndex = 6;
            label7.Text = "Sunday";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dayContainer
            // 
            dayContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dayContainer.Location = new Point(117, 121);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(1066, 675);
            dayContainer.TabIndex = 7;
            // 
            // nextPageButton
            // 
            nextPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextPageButton.Location = new Point(1176, 812);
            nextPageButton.Name = "nextPageButton";
            nextPageButton.Size = new Size(94, 29);
            nextPageButton.TabIndex = 8;
            nextPageButton.Text = "Next";
            nextPageButton.UseVisualStyleBackColor = true;
            nextPageButton.Click += nextPageButton_Click;
            // 
            // prevPageButton
            // 
            prevPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            prevPageButton.Location = new Point(1050, 812);
            prevPageButton.Name = "prevPageButton";
            prevPageButton.Size = new Size(94, 29);
            prevPageButton.TabIndex = 9;
            prevPageButton.Text = "Previous";
            prevPageButton.UseVisualStyleBackColor = true;
            prevPageButton.Click += prevPageButton_Click;
            // 
            // monthYearLabel
            // 
            monthYearLabel.Dock = DockStyle.Top;
            monthYearLabel.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            monthYearLabel.ForeColor = Color.White;
            monthYearLabel.Location = new Point(0, 0);
            monthYearLabel.Margin = new Padding(10, 0, 10, 0);
            monthYearLabel.Name = "monthYearLabel";
            monthYearLabel.Size = new Size(1282, 45);
            monthYearLabel.TabIndex = 10;
            monthYearLabel.Text = "Month Year";
            monthYearLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // nextPageLabel
            // 
            nextPageLabel.AutoSize = true;
            nextPageLabel.Cursor = Cursors.Hand;
            nextPageLabel.Font = new Font("Franklin Gothic Medium Cond", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextPageLabel.ForeColor = Color.Transparent;
            nextPageLabel.Location = new Point(1218, 450);
            nextPageLabel.Name = "nextPageLabel";
            nextPageLabel.Size = new Size(34, 39);
            nextPageLabel.TabIndex = 11;
            nextPageLabel.Text = ">";
            nextPageLabel.Click += nextPageLabel_Click;
            // 
            // prevPageLabel
            // 
            prevPageLabel.AutoSize = true;
            prevPageLabel.Cursor = Cursors.Hand;
            prevPageLabel.Font = new Font("Franklin Gothic Medium Cond", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prevPageLabel.ForeColor = Color.Transparent;
            prevPageLabel.Location = new Point(41, 450);
            prevPageLabel.Name = "prevPageLabel";
            prevPageLabel.Size = new Size(34, 39);
            prevPageLabel.TabIndex = 12;
            prevPageLabel.Text = "<";
            prevPageLabel.Click += prevPageLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 26);
            ClientSize = new Size(1282, 853);
            Controls.Add(prevPageLabel);
            Controls.Add(nextPageLabel);
            Controls.Add(monthYearLabel);
            Controls.Add(prevPageButton);
            Controls.Add(nextPageButton);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(dayContainer);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Event Planner";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private FlowLayoutPanel dayContainer;
        private Button nextPageButton;
        private Button prevPageButton;
        private Label monthYearLabel;
        private Label nextPageLabel;
        private Label prevPageLabel;
    }
}
