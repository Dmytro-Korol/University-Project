namespace UniversityProject
{
    partial class EventDescription
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
            titleLabel = new Label();
            label2 = new Label();
            descriptionLabel = new Label();
            label4 = new Label();
            dateLabel = new Label();
            label5 = new Label();
            eventsFlowLayoutPanel = new FlowLayoutPanel();
            messageLabel = new Label();
            deleteEvent = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.Transparent;
            titleLabel.Location = new Point(11, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(375, 41);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(405, 9);
            label2.Name = "label2";
            label2.Size = new Size(375, 41);
            label2.TabIndex = 2;
            label2.Text = "Another events";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            descriptionLabel.BackColor = Color.FromArgb(83, 81, 79);
            descriptionLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionLabel.ForeColor = Color.Transparent;
            descriptionLabel.Location = new Point(11, 119);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(363, 199);
            descriptionLabel.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(11, 355);
            label4.Name = "label4";
            label4.Size = new Size(166, 31);
            label4.TabIndex = 6;
            label4.Text = "Date and time:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dateLabel.ForeColor = Color.Transparent;
            dateLabel.Location = new Point(182, 359);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(165, 28);
            dateLabel.TabIndex = 7;
            dateLabel.Text = "00.00.0000 00:00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(11, 79);
            label5.Name = "label5";
            label5.Size = new Size(134, 31);
            label5.TabIndex = 8;
            label5.Text = "Description";
            // 
            // eventsFlowLayoutPanel
            // 
            eventsFlowLayoutPanel.AutoScroll = true;
            eventsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            eventsFlowLayoutPanel.Location = new Point(415, 53);
            eventsFlowLayoutPanel.Name = "eventsFlowLayoutPanel";
            eventsFlowLayoutPanel.Size = new Size(375, 416);
            eventsFlowLayoutPanel.TabIndex = 9;
            eventsFlowLayoutPanel.WrapContents = false;
            // 
            // messageLabel
            // 
            messageLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            messageLabel.ForeColor = Color.Transparent;
            messageLabel.Location = new Point(490, 183);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(234, 135);
            messageLabel.TabIndex = 10;
            messageLabel.Text = "You don`t have another events";
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteEvent
            // 
            deleteEvent.Enabled = false;
            deleteEvent.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            deleteEvent.Location = new Point(11, 419);
            deleteEvent.Margin = new Padding(3, 4, 3, 4);
            deleteEvent.Name = "deleteEvent";
            deleteEvent.Size = new Size(363, 47);
            deleteEvent.TabIndex = 11;
            deleteEvent.Text = "Delete current event";
            deleteEvent.UseVisualStyleBackColor = true;
            deleteEvent.Click += deleteEvent_Click;
            // 
            // EventDescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 26);
            ClientSize = new Size(792, 481);
            Controls.Add(deleteEvent);
            Controls.Add(messageLabel);
            Controls.Add(eventsFlowLayoutPanel);
            Controls.Add(label5);
            Controls.Add(dateLabel);
            Controls.Add(label4);
            Controls.Add(descriptionLabel);
            Controls.Add(label2);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EventDescription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventDescription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label label2;
        private Label descriptionLabel;
        private Label label4;
        private Label dateLabel;
        private Label label5;
        private FlowLayoutPanel eventsFlowLayoutPanel;
        private Label messageLabel;
        private Button deleteEvent;
    }
}