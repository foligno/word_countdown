namespace Countdown
{
    partial class timeLeftForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timeLeftForm));
            this.timeLabel = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.daysLeft = new System.Windows.Forms.Label();
            this.hoursLeft = new System.Windows.Forms.Label();
            this.secondsLeft = new System.Windows.Forms.Label();
            this.minutesLeft = new System.Windows.Forms.Label();
            this.wordsPerHour = new System.Windows.Forms.Label();
            this.wordsTargetBar = new System.Windows.Forms.TrackBar();
            this.wordsLeftLabel = new System.Windows.Forms.Label();
            this.timeThenPicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.TrackBar();
            this.timeThenLabel = new System.Windows.Forms.Label();
            this.wordsTargetLabel = new System.Windows.Forms.Label();
            this.documentListBox = new System.Windows.Forms.ListBox();
            this.wordsCurrentLabel = new System.Windows.Forms.Label();
            this.populateListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wordsTargetBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(361, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(52, 13);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "timeLabel";
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // daysLeft
            // 
            this.daysLeft.AutoSize = true;
            this.daysLeft.Location = new System.Drawing.Point(336, 157);
            this.daysLeft.Name = "daysLeft";
            this.daysLeft.Size = new System.Drawing.Size(47, 13);
            this.daysLeft.TabIndex = 1;
            this.daysLeft.Text = "daysLeft";
            // 
            // hoursLeft
            // 
            this.hoursLeft.AutoSize = true;
            this.hoursLeft.Location = new System.Drawing.Point(336, 170);
            this.hoursLeft.Name = "hoursLeft";
            this.hoursLeft.Size = new System.Drawing.Size(51, 13);
            this.hoursLeft.TabIndex = 1;
            this.hoursLeft.Text = "hoursLeft";
            // 
            // secondsLeft
            // 
            this.secondsLeft.AutoSize = true;
            this.secondsLeft.Location = new System.Drawing.Point(336, 196);
            this.secondsLeft.Name = "secondsLeft";
            this.secondsLeft.Size = new System.Drawing.Size(65, 13);
            this.secondsLeft.TabIndex = 1;
            this.secondsLeft.Text = "secondsLeft";
            // 
            // minutesLeft
            // 
            this.minutesLeft.AutoSize = true;
            this.minutesLeft.Location = new System.Drawing.Point(336, 183);
            this.minutesLeft.Name = "minutesLeft";
            this.minutesLeft.Size = new System.Drawing.Size(61, 13);
            this.minutesLeft.TabIndex = 1;
            this.minutesLeft.Text = "minutesLeft";
            // 
            // wordsPerHour
            // 
            this.wordsPerHour.AutoSize = true;
            this.wordsPerHour.Location = new System.Drawing.Point(336, 260);
            this.wordsPerHour.Name = "wordsPerHour";
            this.wordsPerHour.Size = new System.Drawing.Size(74, 13);
            this.wordsPerHour.TabIndex = 1;
            this.wordsPerHour.Text = "wordsPerHour";
            // 
            // wordsTargetBar
            // 
            this.wordsTargetBar.LargeChange = 500;
            this.wordsTargetBar.Location = new System.Drawing.Point(285, 9);
            this.wordsTargetBar.Maximum = 15000;
            this.wordsTargetBar.Name = "wordsTargetBar";
            this.wordsTargetBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.wordsTargetBar.Size = new System.Drawing.Size(45, 344);
            this.wordsTargetBar.SmallChange = 250;
            this.wordsTargetBar.TabIndex = 2;
            this.wordsTargetBar.Value = 8000;
            this.wordsTargetBar.Scroll += new System.EventHandler(this.wordsLeftBar_Scroll);
            // 
            // wordsLeftLabel
            // 
            this.wordsLeftLabel.AutoSize = true;
            this.wordsLeftLabel.Location = new System.Drawing.Point(336, 247);
            this.wordsLeftLabel.Name = "wordsLeftLabel";
            this.wordsLeftLabel.Size = new System.Drawing.Size(79, 13);
            this.wordsLeftLabel.TabIndex = 0;
            this.wordsLeftLabel.Text = "wordsLeftLabel";
            // 
            // timeThenPicker
            // 
            this.timeThenPicker.Location = new System.Drawing.Point(336, 36);
            this.timeThenPicker.Name = "timeThenPicker";
            this.timeThenPicker.Size = new System.Drawing.Size(227, 20);
            this.timeThenPicker.TabIndex = 3;
            this.timeThenPicker.Value = new System.DateTime(2013, 4, 24, 0, 0, 0, 0);
            // 
            // timePicker
            // 
            this.timePicker.LargeChange = 4;
            this.timePicker.Location = new System.Drawing.Point(336, 62);
            this.timePicker.Maximum = 24;
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(230, 45);
            this.timePicker.TabIndex = 4;
            this.timePicker.Value = 8;
            // 
            // timeThenLabel
            // 
            this.timeThenLabel.AutoSize = true;
            this.timeThenLabel.Location = new System.Drawing.Point(336, 128);
            this.timeThenLabel.Name = "timeThenLabel";
            this.timeThenLabel.Size = new System.Drawing.Size(77, 13);
            this.timeThenLabel.TabIndex = 0;
            this.timeThenLabel.Text = "timeThenLabel";
            // 
            // wordsTargetLabel
            // 
            this.wordsTargetLabel.AutoSize = true;
            this.wordsTargetLabel.Location = new System.Drawing.Point(336, 234);
            this.wordsTargetLabel.Name = "wordsTargetLabel";
            this.wordsTargetLabel.Size = new System.Drawing.Size(92, 13);
            this.wordsTargetLabel.TabIndex = 0;
            this.wordsTargetLabel.Text = "wordsTargetLabel";
            // 
            // documentListBox
            // 
            this.documentListBox.FormattingEnabled = true;
            this.documentListBox.Location = new System.Drawing.Point(12, 48);
            this.documentListBox.Name = "documentListBox";
            this.documentListBox.Size = new System.Drawing.Size(267, 303);
            this.documentListBox.TabIndex = 5;
            this.documentListBox.SelectedIndexChanged += new System.EventHandler(this.documentListBox_SelectedIndexChanged);
            // 
            // wordsCurrentLabel
            // 
            this.wordsCurrentLabel.AutoSize = true;
            this.wordsCurrentLabel.Location = new System.Drawing.Point(336, 221);
            this.wordsCurrentLabel.Name = "wordsCurrentLabel";
            this.wordsCurrentLabel.Size = new System.Drawing.Size(95, 13);
            this.wordsCurrentLabel.TabIndex = 0;
            this.wordsCurrentLabel.Text = "wordsCurrentLabel";
            // 
            // populateListButton
            // 
            this.populateListButton.Location = new System.Drawing.Point(12, 12);
            this.populateListButton.Name = "populateListButton";
            this.populateListButton.Size = new System.Drawing.Size(105, 24);
            this.populateListButton.TabIndex = 6;
            this.populateListButton.Text = "Populate List";
            this.populateListButton.UseVisualStyleBackColor = true;
            this.populateListButton.Click += new System.EventHandler(this.populateListButton_Click);
            // 
            // timeLeftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 365);
            this.Controls.Add(this.populateListButton);
            this.Controls.Add(this.documentListBox);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.timeThenPicker);
            this.Controls.Add(this.wordsTargetBar);
            this.Controls.Add(this.minutesLeft);
            this.Controls.Add(this.wordsPerHour);
            this.Controls.Add(this.secondsLeft);
            this.Controls.Add(this.hoursLeft);
            this.Controls.Add(this.daysLeft);
            this.Controls.Add(this.wordsCurrentLabel);
            this.Controls.Add(this.wordsTargetLabel);
            this.Controls.Add(this.wordsLeftLabel);
            this.Controls.Add(this.timeThenLabel);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "timeLeftForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Counter";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.wordsTargetBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label daysLeft;
        private System.Windows.Forms.Label hoursLeft;
        private System.Windows.Forms.Label secondsLeft;
        private System.Windows.Forms.Label minutesLeft;
        private System.Windows.Forms.Label wordsPerHour;
        private System.Windows.Forms.TrackBar wordsTargetBar;
        private System.Windows.Forms.Label wordsLeftLabel;
        private System.Windows.Forms.DateTimePicker timeThenPicker;
        private System.Windows.Forms.TrackBar timePicker;
        private System.Windows.Forms.Label timeThenLabel;
        private System.Windows.Forms.Label wordsTargetLabel;
        private System.Windows.Forms.ListBox documentListBox;
        private System.Windows.Forms.Label wordsCurrentLabel;
        private System.Windows.Forms.Button populateListButton;

    }
}

