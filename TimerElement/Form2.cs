using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace PomoMate
{
    public enum SessionState
    {
        Study,
        Break 
    }

    public partial class Form2 : Form
    {
        private int _studyTimeSeconds;
        private int _breakTimeSeconds;
        private int _activeTimeSeconds;
        private SessionState _currentSession = SessionState.Study;

        public Form2(string studyTime, string breakTime)
        {
            InitializeComponent();

            _studyTimeSeconds = ValidateParsing(studyTime) * 60;
            _breakTimeSeconds = ValidateParsing(breakTime) * 60;

            _activeTimeSeconds = _studyTimeSeconds;

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
            TimeSpan timeSpan = TimeSpan.FromSeconds(_activeTimeSeconds);
            timeDisplayLabel.Text = timeSpan.ToString(@"hh\:mm\:ss");
            sessionStateLabel.Text = _currentSession == SessionState.Study ? "Study Time" : "Break Time";
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
            int sessionTotalSeconds = (_currentSession == SessionState.Study) ? _studyTimeSeconds : _breakTimeSeconds;

            timeStateBar.Value = (sessionTotalSeconds > 0) ? 
                                 (int)((double)_activeTimeSeconds / sessionTotalSeconds * 100) : 0;

            if (_activeTimeSeconds > 0)
            {
                _activeTimeSeconds--;
                UpdateDisplay();
            }

            else
            {
                pomoTimer.Stop();
                if (_currentSession == SessionState.Study)
                {
                    MessageBox.Show("Study time is over! Starting break time.",
                                    "Study Complete",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    // Switch to break time
                    
                    _activeTimeSeconds = _breakTimeSeconds;
                    _currentSession = SessionState.Break;
                }
                else
                {
                    MessageBox.Show("Break time is over! Starting new study session.",
                                     "Break Complete",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    // Switch to study time
                    _activeTimeSeconds = _studyTimeSeconds;
                    _currentSession = SessionState.Study;
                }

                UpdateDisplay();
                if(_activeTimeSeconds > 0)
                {
                    pomoTimer.Start();
                }
                else
                {
                    MessageBox.Show("Session compalated", 
                                    "All Done", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
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
            _activeTimeSeconds = (_currentSession == SessionState.Study) ? _studyTimeSeconds : _breakTimeSeconds;
            UpdateDisplay();
            timeStateBar.Value = 0; // Reset the progress bar
        }
    }
}
