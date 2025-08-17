using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PomoMate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startTimerButton_Click(object sender, EventArgs e)
        {
            string studyTime = studyTimesBox.Text;
            string breakTime = breakTimesBox.Text;

            if (IsStringBlank(studyTime) || IsStringBlank(breakTime))
            {
                MessageBox.Show("Please enter the study and break interval values",
                                "Invalid Time Value Error", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!(IsValidNumber(studyTime) || IsValidNumber(breakTime))) {
                MessageBox.Show("ERROR: The time values are not valid", 
                                "Invalid Input", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                return;
            }

            if(int.Parse(studyTime) > 1440 || int.Parse(breakTime) > 60)
            {
                MessageBox.Show("Invalid input.Study time cannot exceed 1440 minutes(24 hours), or break time cannot exceed 60 minutes.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Form2 form2 = new Form2(studyTime, breakTime);
            form2.Show();
            this.Hide();
        }

        private static bool IsStringBlank(string str)
        {
            return (string.IsNullOrWhiteSpace(str));
        }

        private bool IsValidNumber(string str)
        {
            if (!int.TryParse(str, out _))
            {
                return false;
            }
            return true;
        }

        private void closeAppForm1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
