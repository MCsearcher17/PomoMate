using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomoMate
{
    struct TimeState
    {
        public const string Study = "Study Session";
        public const string Break = "Break Session";
    }

    public partial class Form2 : Form
    {
        // Change the fields from readonly to regular fields so they can be modified in the timer tick event.
        private int studyTimeSeconds;
        private int breakTimeSeconds;
        private int activeTimeSeconds;
        private bool isStudyTime = true;

        public Form2(string studyTime, string breakTime)
        {
            InitializeComponent();

            this.studyTimeSeconds = ValidateParsing(studyTime) * 60;
            this.breakTimeSeconds = ValidateParsing(breakTime) * 60;

            this.activeTimeSeconds = this.studyTimeSeconds;

            StartTimer();
            UpdateDisplay();
        }

        private static void ShowErrorMessage()
        {
            MessageBox.Show("ERROR: The time values are not valid");
        }

        private void StartTimer()
        {
            if (pomoTimer != null)
            {
                pomoTimer.Interval = 1000;
                pomoTimer.Start();
            }
        }

        private void UpdateDisplay()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(activeTimeSeconds);
            timeDisplayLabel.Text = timeSpan.ToString(@"hh\:mm\:ss");
        }

        private static int ValidateParsing(string str)
        {
            if (!int.TryParse(str, out int numStr))
            {
                ShowErrorMessage();
                numStr = 0;
            }
            return numStr;
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            pomoTimer.Stop();
            Form1 form1 = new();
            form1.Show();
            this.Hide();
        }

        private void pomoTimer_Tick(object sender, EventArgs e)
        {
            timeStateBar.Value = (int)((double)(activeTimeSeconds) / (isStudyTime ? studyTimeSeconds : breakTimeSeconds) * 100);

            sessionStateLabel.Text = isStudyTime ? TimeState.Study : TimeState.Break;

            if (activeTimeSeconds > 0)
            {
                activeTimeSeconds--;
                UpdateDisplay();
            }

            else
            {
                if (isStudyTime)
                {
                    pomoTimer.Stop();
                    MessageBox.Show("Study time is over! Starting break time.",
                                    "Study Complete",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    // Switch to break time
                    isStudyTime = false;
                    activeTimeSeconds = breakTimeSeconds;
                    UpdateDisplay();

                    // Checking the break time because the user might typed it as 0 that means
                    // no any break time and the only session is completed.
                    if (activeTimeSeconds <= 0)
                    {
                        pomoTimer.Stop();
                        MessageBox.Show("Session completed!",
                                        "All Done",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        pomoTimer.Start();
                    }
                }
                else
                {
                    pomoTimer.Stop();
                    MessageBox.Show("Break time is over! Starting new study session.",
                                     "Break Complete",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    // Switch to study time
                    isStudyTime = true;
                    activeTimeSeconds = studyTimeSeconds;
                    UpdateDisplay();
                    pomoTimer.Start();
                }
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (pomoTimer.Enabled)
            {
                pomoTimer.Stop();
                pauseButton.Text = "Resume";
            }
            else
            {
                pomoTimer.Start();
                pauseButton.Text = "Pause";
            }
        }

        private void resetTimeButton_Click(object sender, EventArgs e)
        {
            pomoTimer.Stop();
            pauseButton.Text = "Resume";
            activeTimeSeconds = (isStudyTime) ? studyTimeSeconds : breakTimeSeconds;
            UpdateDisplay();
            timeStateBar.Value = 0; // Reset the progress bar
            MessageBox.Show("Timer has been reset.",
                            "Reset Timer",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);    

        }
    }
}
