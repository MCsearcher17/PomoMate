using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PomoMate
{
    public partial class Form1 : Form
    {
        private const int MaxStudyMinutes = 1440;
        private const int MaxBreakMinutes = 60;

        public Form1()
        {
            InitializeComponent();
        }

        private void startTimerButton_Click(object sender, EventArgs e)
        {
            string studyTime = studyTimesBox.Text;
            string breakTime = breakTimesBox.Text;

            if(IsInputsValid(studyTime, breakTime))
            {
                Form2 form2 = new Form2(studyTime, breakTime);
                form2.Show();
                this.Hide();
            }   
        }

        private bool IsInputsValid(string studyTime, string breakTime)
        {
            if (IsStringBlank(studyTime) || IsStringBlank(breakTime))
            {
                ShowErrorMessage("Please enter the study and break time interval values",
                                "Input Required");
                return false;
            }

            if (int.TryParse(studyTime, out int studyMinutes) == false ||
                int.TryParse(breakTime, out int breakMinutes) == false)
            {
                ShowErrorMessage("The time values must be integers.",
                                "Noninteger Input");
                return false;

            }
            if (studyMinutes > MaxStudyMinutes || breakMinutes > MaxBreakMinutes)
            {
                ShowErrorMessage($"Study time cannot exceed {MaxStudyMinutes} minutes(24 hours), or break time cannot exceed {MaxBreakMinutes} minutes(1 hours).", "Input out of Range");
                return false;
            }
            return true;
        }

        private static bool IsStringBlank(string str)
        {
            return (string.IsNullOrWhiteSpace(str));
        }

        private static void ShowErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 

        private void closeAppForm1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
