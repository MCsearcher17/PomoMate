using System.ComponentModel;
using System.Data;
using System.Media;
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

        SoundPlayer pomoSound = new SoundPlayer(Resource1.acoustic_guitar);

        public Form2(string studyTime, string breakTime)
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Form2_KeyDown;

            _studyTimeSeconds = ValidateParsing(studyTime) * 60;
            _breakTimeSeconds = ValidateParsing(breakTime) * 60;

            _activeTimeSeconds = _studyTimeSeconds;

            StartTimer();
            UpdateDisplay();
        }

        /* object? sender → nullable, can be null; object sender → non-nullable, cannot be null.
        Use sender! to assert non-null, or make the method(backToMenu_Click) accept object? if null is
        safe. */
        private void Form2_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                backToMenu_Click(sender!, e); //to prevent 
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                pauseButton_Click(sender!, e);
                e.Handled = true;
            }

            if (e.KeyCode == Keys.R)
            {
                resetTimeButton_Click(sender!, e);
                e.Handled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pomoSound.Load();
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
                ShowParsingErrorMessage();
                numStr = 0;
            }
            return numStr;
        }

        private static void ShowParsingErrorMessage()
        {
            MessageBox.Show("ERROR: The time values are not valid");
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
                pomoSound.Play();

                if (_currentSession == SessionState.Study)
                {
                    ShowSessionInfo("Study Time Complete", "Time to take a break!");
                    StopSessionSound();

                    // Switch to break time
                    _activeTimeSeconds = _breakTimeSeconds;
                    _currentSession = SessionState.Break;
                }
                else
                {
                    ShowSessionInfo("Break Time Complete", "Time to get back to studying!");
                    StopSessionSound();
                    // Switch to study time
                    _activeTimeSeconds = _studyTimeSeconds;
                    _currentSession = SessionState.Study;
                }

                UpdateDisplay();
                if (_activeTimeSeconds > 0)
                {
                    pomoTimer.Start();
                }
                else
                {
                    ShowSessionInfo("Session Complete", "You have completed your all sessions!");
                    StopSessionSound();
                }
            }
        }

        private void ShowSessionInfo(string title, string text)
        {
            sessionInfoNotifyIcon.Icon = SystemIcons.Information;   
            sessionInfoNotifyIcon.BalloonTipTitle = title;
            sessionInfoNotifyIcon.BalloonTipText = text;
            sessionInfoNotifyIcon.ShowBalloonTip(5000); 
        }

        private void StopSessionSound()
        {
            sessionInfoNotifyIcon.BalloonTipClicked += (s, args) =>
            {
                pomoSound.Stop();
            };
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
            timeStateBar.Value = 0; 
        }
    }
}
