namespace AS_Coursework.View.QuizView {
    partial class formQuizFinished {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this m
        /// </summary>
        private void InitializeComponent() {
            lblUsername = new Label();
            pbUserProfile = new Custom_Controls.PictureFrame();
            lblQuizStatistics = new Label();
            btnExit = new Custom_Controls.CustomButton();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoEllipsis = true;
            lblUsername.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(200, 260);
            lblUsername.Margin = new Padding(5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(400, 30);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username is far too long fo this";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbUserProfile
            // 
            pbUserProfile.Anchor = AnchorStyles.None;
            pbUserProfile.BorderColorOne = Color.FromArgb(0, 100, 255);
            pbUserProfile.BorderColorTwo = Color.FromArgb(50, 200, 255);
            pbUserProfile.BorderStyle = Custom_Controls.PictureFrame.BorderType.Circle;
            pbUserProfile.BorderWidth = 20;
            pbUserProfile.GradientAngle = 45;
            pbUserProfile.GradientRectangle = new Rectangle(0, 0, 200, 200);
            pbUserProfile.Image = Resources.Icons.User;
            pbUserProfile.ImagePortion = new Rectangle(-256, -256, 1024, 1024);
            pbUserProfile.Location = new Point(298, 14);
            pbUserProfile.Margin = new Padding(5);
            pbUserProfile.Name = "pbUserProfile";
            pbUserProfile.Size = new Size(200, 200);
            pbUserProfile.TabIndex = 3;
            pbUserProfile.Text = "pbProfile";
            // 
            // lblQuizStatistics
            // 
            lblQuizStatistics.Anchor = AnchorStyles.None;
            lblQuizStatistics.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuizStatistics.ForeColor = Color.White;
            lblQuizStatistics.Location = new Point(200, 300);
            lblQuizStatistics.Margin = new Padding(5);
            lblQuizStatistics.Name = "lblQuizStatistics";
            lblQuizStatistics.Size = new Size(400, 150);
            lblQuizStatistics.TabIndex = 6;
            lblQuizStatistics.Text = "Quiz complete, well done!\r\n\r\nCorrect: 10/10\r\nExperience gained: 10";
            lblQuizStatistics.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(0, 150, 255);
            btnExit.BorderColor = Color.White;
            btnExit.BorderWidth = 2;
            btnExit.CornerRadius = 10;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.BlanchedAlmond;
            btnExit.Image = null;
            btnExit.ImageSize = new Size(150, 40);
            btnExit.Location = new Point(350, 500);
            btnExit.Margin = new Padding(5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 45);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // formQuizFinished
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(800, 600);
            Controls.Add(btnExit);
            Controls.Add(pbUserProfile);
            Controls.Add(lblUsername);
            Controls.Add(lblQuizStatistics);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "formQuizFinished";
            Text = "formUserHome";
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsername;
        private Custom_Controls.PictureFrame pbUserProfile;
        private Panel pnlUserProfile;
        private Label lblQuizStatistics;
        private Custom_Controls.CustomButton btnExit;
    }
}
