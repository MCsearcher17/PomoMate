namespace PomoMate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            projectNameLabel = new Label();
            clockPictureBox = new PictureBox();
            studyTimesBoxLabel = new Label();
            breakTimesBoxLabel = new Label();
            breakTimesBox = new ComboBox();
            studyTimesBox = new ComboBox();
            startTimerButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblScientistName = new Label();
            lblQuote = new Label();
            ((System.ComponentModel.ISupportInitialize)clockPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            projectNameLabel.Location = new Point(50, 27);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new Size(138, 32);
            projectNameLabel.TabIndex = 26;
            projectNameLabel.Text = "PomoMate";
            // 
            // clockPictureBox
            // 
            clockPictureBox.Anchor = AnchorStyles.Top;
            clockPictureBox.BackgroundImageLayout = ImageLayout.Center;
            clockPictureBox.Image = (Image)resources.GetObject("clockPictureBox.Image");
            clockPictureBox.Location = new Point(12, 27);
            clockPictureBox.Name = "clockPictureBox";
            clockPictureBox.Size = new Size(32, 32);
            clockPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            clockPictureBox.TabIndex = 25;
            clockPictureBox.TabStop = false;
            // 
            // studyTimesBoxLabel
            // 
            studyTimesBoxLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            studyTimesBoxLabel.Location = new Point(207, 178);
            studyTimesBoxLabel.Name = "studyTimesBoxLabel";
            studyTimesBoxLabel.Size = new Size(95, 90);
            studyTimesBoxLabel.TabIndex = 24;
            studyTimesBoxLabel.Text = "Study Times";
            studyTimesBoxLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // breakTimesBoxLabel
            // 
            breakTimesBoxLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            breakTimesBoxLabel.Location = new Point(395, 178);
            breakTimesBoxLabel.Name = "breakTimesBoxLabel";
            breakTimesBoxLabel.Size = new Size(95, 90);
            breakTimesBoxLabel.TabIndex = 23;
            breakTimesBoxLabel.Text = "Break Times";
            breakTimesBoxLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // breakTimesBox
            // 
            breakTimesBox.Font = new Font("Segoe UI", 14F);
            breakTimesBox.FormattingEnabled = true;
            breakTimesBox.Items.AddRange(new object[] { "5", "10 ", "15" });
            breakTimesBox.Location = new Point(340, 274);
            breakTimesBox.Name = "breakTimesBox";
            breakTimesBox.Size = new Size(150, 33);
            breakTimesBox.TabIndex = 22;
            // 
            // studyTimesBox
            // 
            studyTimesBox.Font = new Font("Segoe UI", 14F);
            studyTimesBox.FormattingEnabled = true;
            studyTimesBox.Items.AddRange(new object[] { "5", "10 ", "15", "30", "45", "60" });
            studyTimesBox.Location = new Point(152, 274);
            studyTimesBox.Name = "studyTimesBox";
            studyTimesBox.Size = new Size(150, 33);
            studyTimesBox.TabIndex = 21;
            // 
            // startTimerButton
            // 
            startTimerButton.BackColor = Color.LightYellow;
            startTimerButton.FlatAppearance.BorderSize = 0;
            startTimerButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            startTimerButton.Location = new Point(535, 221);
            startTimerButton.Name = "startTimerButton";
            startTimerButton.Size = new Size(170, 95);
            startTimerButton.TabIndex = 18;
            startTimerButton.Text = "Start";
            startTimerButton.UseVisualStyleBackColor = false;
            startTimerButton.Click += startTimerButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.studyIcon;
            pictureBox1.Location = new Point(152, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.breakIcon;
            pictureBox2.Location = new Point(340, 191);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // lblScientistName
            // 
            lblScientistName.Location = new Point(152, 399);
            lblScientistName.Name = "lblScientistName";
            lblScientistName.Size = new Size(100, 23);
            lblScientistName.TabIndex = 29;
            lblScientistName.Text = "Scientist Name";
            // 
            // lblQuote
            // 
            lblQuote.Location = new Point(340, 399);
            lblQuote.Name = "lblQuote";
            lblQuote.Size = new Size(100, 23);
            lblQuote.TabIndex = 30;
            lblQuote.Text = "Quote";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblQuote);
            Controls.Add(lblScientistName);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(projectNameLabel);
            Controls.Add(clockPictureBox);
            Controls.Add(studyTimesBoxLabel);
            Controls.Add(breakTimesBoxLabel);
            Controls.Add(breakTimesBox);
            Controls.Add(studyTimesBox);
            Controls.Add(startTimerButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu - PomoMate";
            ((System.ComponentModel.ISupportInitialize)clockPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label projectNameLabel;
        private PictureBox clockPictureBox;
        private Label studyTimesBoxLabel;
        private Label breakTimesBoxLabel;
        private ComboBox breakTimesBox;
        private ComboBox studyTimesBox;
        private Button startTimerButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblScientistName;
        private Label lblQuote;
    }
}
