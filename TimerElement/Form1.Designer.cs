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
            label1 = new Label();
            clockPictureBox = new PictureBox();
            studyTimesBoxLabel = new Label();
            breakTimesBoxLabel = new Label();
            breakTimesBox = new ComboBox();
            studyTimesBox = new ComboBox();
            startTimerButton = new Button();
            closeAppForm1 = new Button();
            ((System.ComponentModel.ISupportInitialize)clockPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(86, 27);
            label1.Name = "label1";
            label1.Size = new Size(205, 40);
            label1.TabIndex = 26;
            label1.Text = "PomoMate";
            // 
            // clockPictureBox
            // 
            clockPictureBox.Anchor = AnchorStyles.Top;
            clockPictureBox.BackgroundImageLayout = ImageLayout.Center;
            clockPictureBox.Image = Resource1.clock_symbol;
            clockPictureBox.Location = new Point(2, -3);
            clockPictureBox.Name = "clockPictureBox";
            clockPictureBox.Size = new Size(78, 97);
            clockPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            clockPictureBox.TabIndex = 25;
            clockPictureBox.TabStop = false;
            // 
            // studyTimesBoxLabel
            // 
            studyTimesBoxLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            studyTimesBoxLabel.Location = new Point(152, 171);
            studyTimesBoxLabel.Name = "studyTimesBoxLabel";
            studyTimesBoxLabel.Size = new Size(150, 90);
            studyTimesBoxLabel.TabIndex = 24;
            studyTimesBoxLabel.Text = "Study Times";
            studyTimesBoxLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // breakTimesBoxLabel
            // 
            breakTimesBoxLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            breakTimesBoxLabel.Location = new Point(340, 171);
            breakTimesBoxLabel.Name = "breakTimesBoxLabel";
            breakTimesBoxLabel.Size = new Size(150, 90);
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
            startTimerButton.BackColor = Color.LemonChiffon;
            startTimerButton.FlatAppearance.BorderSize = 0;
            startTimerButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            startTimerButton.Location = new Point(552, 155);
            startTimerButton.Name = "startTimerButton";
            startTimerButton.Size = new Size(170, 95);
            startTimerButton.TabIndex = 18;
            startTimerButton.Text = "Start";
            startTimerButton.UseVisualStyleBackColor = false;
            startTimerButton.Click += startTimerButton_Click;
            // 
            // closeAppForm1
            // 
            closeAppForm1.BackColor = Color.Red;
            closeAppForm1.FlatAppearance.BorderSize = 0;
            closeAppForm1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            closeAppForm1.ForeColor = SystemColors.ControlLight;
            closeAppForm1.Location = new Point(552, 240);
            closeAppForm1.Name = "closeAppForm1";
            closeAppForm1.Size = new Size(170, 95);
            closeAppForm1.TabIndex = 27;
            closeAppForm1.Text = "Close App";
            closeAppForm1.UseVisualStyleBackColor = false;
            closeAppForm1.Click += closeAppForm1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeAppForm1);
            Controls.Add(label1);
            Controls.Add(clockPictureBox);
            Controls.Add(studyTimesBoxLabel);
            Controls.Add(breakTimesBoxLabel);
            Controls.Add(breakTimesBox);
            Controls.Add(studyTimesBox);
            Controls.Add(startTimerButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)clockPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private PictureBox clockPictureBox;
        private Label studyTimesBoxLabel;
        private Label breakTimesBoxLabel;
        private ComboBox breakTimesBox;
        private ComboBox studyTimesBox;
        private Button startTimerButton;
        private Button closeAppForm1;
    }
}
