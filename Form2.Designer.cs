namespace PomoMate
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            projectNameLabel = new Label();
            clockPictureBox = new PictureBox();
            timeStateBar = new ProgressBar();
            backToMenu = new Button();
            timeDisplayLabel = new Label();
            pomoTimer = new System.Windows.Forms.Timer(components);
            pauseButton = new Button();
            resetTimeButton = new Button();
            sessionStateLabel = new Label();
            sessionInfoNotifyIcon = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)clockPictureBox).BeginInit();
            SuspendLayout();
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            projectNameLabel.Location = new Point(50, 27);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new Size(138, 32);
            projectNameLabel.TabIndex = 19;
            projectNameLabel.Text = "PomoMate";
            // 
            // clockPictureBox
            // 
            clockPictureBox.Anchor = AnchorStyles.Top;
            clockPictureBox.BackgroundImageLayout = ImageLayout.Center;
            clockPictureBox.Image = Resource1.Alarm_Clock;
            clockPictureBox.Location = new Point(12, 27);
            clockPictureBox.Name = "clockPictureBox";
            clockPictureBox.Size = new Size(32, 32);
            clockPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            clockPictureBox.TabIndex = 18;
            clockPictureBox.TabStop = false;
            // 
            // timeStateBar
            // 
            timeStateBar.Location = new Point(332, 361);
            timeStateBar.Name = "timeStateBar";
            timeStateBar.Size = new Size(142, 38);
            timeStateBar.TabIndex = 20;
            // 
            // backToMenu
            // 
            backToMenu.BackColor = Color.Red;
            backToMenu.FlatAppearance.BorderSize = 0;
            backToMenu.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            backToMenu.ForeColor = SystemColors.ControlLight;
            backToMenu.Location = new Point(2, 361);
            backToMenu.Name = "backToMenu";
            backToMenu.Size = new Size(115, 89);
            backToMenu.TabIndex = 21;
            backToMenu.Text = "Back to Menu";
            backToMenu.UseVisualStyleBackColor = false;
            backToMenu.Click += backToMenu_Click;
            // 
            // timeDisplayLabel
            // 
            timeDisplayLabel.Font = new Font("Segoe UI", 64F, FontStyle.Bold);
            timeDisplayLabel.Location = new Point(117, 150);
            timeDisplayLabel.Name = "timeDisplayLabel";
            timeDisplayLabel.Size = new Size(576, 189);
            timeDisplayLabel.TabIndex = 22;
            timeDisplayLabel.Text = "Time";
            timeDisplayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pomoTimer
            // 
            pomoTimer.Tick += pomoTimer_Tick;
            // 
            // pauseButton
            // 
            pauseButton.BackColor = Color.DeepSkyBlue;
            pauseButton.FlatAppearance.BorderSize = 0;
            pauseButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            pauseButton.ForeColor = SystemColors.ControlLightLight;
            pauseButton.Location = new Point(578, 361);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(115, 89);
            pauseButton.TabIndex = 23;
            pauseButton.Text = "Pause";
            pauseButton.UseVisualStyleBackColor = false;
            pauseButton.Click += pauseButton_Click;
            // 
            // resetTimeButton
            // 
            resetTimeButton.BackColor = Color.CadetBlue;
            resetTimeButton.FlatAppearance.BorderSize = 0;
            resetTimeButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            resetTimeButton.ForeColor = SystemColors.ControlLight;
            resetTimeButton.Location = new Point(689, 361);
            resetTimeButton.Name = "resetTimeButton";
            resetTimeButton.Size = new Size(115, 89);
            resetTimeButton.TabIndex = 24;
            resetTimeButton.Text = "Reset";
            resetTimeButton.UseVisualStyleBackColor = false;
            resetTimeButton.Click += resetTimeButton_Click;
            // 
            // sessionStateLabel
            // 
            sessionStateLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            sessionStateLabel.Location = new Point(280, 95);
            sessionStateLabel.Name = "sessionStateLabel";
            sessionStateLabel.Size = new Size(240, 99);
            sessionStateLabel.TabIndex = 25;
            sessionStateLabel.Text = "Session";
            sessionStateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sessionInfoNotifyIcon
            // 
            sessionInfoNotifyIcon.Text = "notifyIcon1";
            sessionInfoNotifyIcon.Visible = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sessionStateLabel);
            Controls.Add(resetTimeButton);
            Controls.Add(pauseButton);
            Controls.Add(timeDisplayLabel);
            Controls.Add(backToMenu);
            Controls.Add(timeStateBar);
            Controls.Add(projectNameLabel);
            Controls.Add(clockPictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timer - PomoMate";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)clockPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timerDisplayLabel;
        private Label projectNameLabel;
        private PictureBox clockPictureBox;
        private ProgressBar timeStateBar;
        private Button backToMenu;
        private Label timeDisplayLabel;
        private System.Windows.Forms.Timer pomoTimer;
        private Button pauseButton;
        private Button resetTimeButton;
        private Label sessionStateLabel;
        private NotifyIcon sessionInfoNotifyIcon;
    }
}