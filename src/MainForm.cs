using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Countdown
{
    public partial class timeLeftForm : Form
    {
        Microsoft.Office.Interop.Word.Application wordObj = null;
        Microsoft.Office.Interop.Word.Document docObj = null;

        public timeLeftForm()
        {
            InitializeComponent();

            timeThenPicker.Value = DateTime.Today;
            timePicker.Value = DateTime.Now.Hour;

            // Fill target label text so that it doesn't start empty
            wordsTargetLabel.Text = "Target: " + wordsTargetBar.Value.ToString() + " words.";
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            // Update all text based on new up-to-date time
            // Target date and time
            DateTime timeThen = new DateTime();
            timeThen = timeThenPicker.Value;
            timeThen = timeThen.AddHours(timePicker.Value);
            timeThenLabel.Text = "Deadline: " + timeThen.ToString();

            // Current date and time
            DateTime timeNow = new DateTime();
            timeNow = DateTime.Now;
            timeLabel.Text = "Time now: " + timeNow.ToString();

            TimeSpan change = timeThen - timeNow;

            daysLeft.Text = change.Days.ToString() + " days";
            hoursLeft.Text = change.Hours.ToString() + " hours";
            minutesLeft.Text = change.Minutes.ToString() + " minutes";
            secondsLeft.Text = change.Seconds.ToString() + " seconds";

            float wordsLeftValue = 0;

            if (docObj != null)
            {
                int currentWordCount = docObj.ComputeStatistics(Microsoft.Office.Interop.Word.WdStatistic.wdStatisticWords);

                wordsCurrentLabel.Text = "Current: " + currentWordCount + " words.";
                wordsLeftLabel.Text = "Remaining: " + (wordsTargetBar.Value - currentWordCount) + " words.";

                if (change.TotalHours > 1.0)
                {
                    wordsLeftValue = (wordsTargetBar.Value - currentWordCount) / (float)change.TotalHours;
                    wordsPerHour.Text = wordsLeftValue.ToString() + " words per hour required.";
                }
                else
                {
                    wordsLeftValue = (wordsTargetBar.Value - currentWordCount) / (float)change.TotalMinutes;
                    wordsPerHour.Text = wordsLeftValue.ToString() + " words per minute required.";
                }
            }
            else
            {
                wordsCurrentLabel.Text = "Current: No file selected.";
                wordsLeftLabel.Text = "Remaining: No file selected.";
                wordsPerHour.Text = "No file selected.";
            }
        }

        private void wordsLeftBar_Scroll(object sender, EventArgs e)
        {
            // Update target label text
            wordsTargetLabel.Text = "Target: " + wordsTargetBar.Value.ToString() + " words.";
        }

        private void populateListBox()
        {
            try
            {
                wordObj = (Microsoft.Office.Interop.Word.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Word.Application");
            }
            catch
            {
                // No word
                documentListBox.Items.Clear();
                wordObj = null;
                docObj = null;
            }

            try
            {
                if (wordObj != null)
                {
                    int currentIndex = documentListBox.SelectedIndex;

                    string[] documentNames = new string[wordObj.Documents.Count];

                    for (int i = 0; i < wordObj.Documents.Count; i++)
                    {
                        documentNames[i] = wordObj.Documents[i + 1].Name.ToString();
                    }

                    documentListBox.Items.Clear();
                    documentListBox.Items.AddRange(documentNames);

                    documentListBox.SelectedIndex = currentIndex;
                }
            }
            catch
            {
                // No word
                documentListBox.Items.Clear();
                wordObj = null;
                docObj = null;
            }

        }

        private void documentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When a document is selected in the list, change the current selected document
            if (documentListBox.SelectedIndex >= 0)
            {
                if (wordObj != null)
                {
                    docObj = wordObj.Documents[documentListBox.SelectedIndex + 1];
                }
            }
        }

        private void populateListButton_Click(object sender, EventArgs e)
        {
            // Get current documents
            populateListBox();
        }
    }
}
