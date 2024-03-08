namespace AS_Coursework.View {
    partial class formHome {
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
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pbUserProfile = new Custom_Controls.PictureFrame();
            pnlLevel = new Custom_Controls.CustomRectangle();
            lblLevel = new Label();
            pbLevel = new Custom_Controls.CustomProgressBar();
            lblExperienceRemainder = new Label();
            lblLevelTitle = new Label();
            pnlRank = new Custom_Controls.CustomRectangle();
            pnl = new Panel();
            lblRank = new Label();
            lblRankTitle = new Label();
            lblUsername = new Label();
            pnlAccuracy = new Custom_Controls.CustomRectangle();
            lblAccuracyTitle = new Label();
            lblPercentageAccuracy = new Label();
            lblCorrect = new Label();
            lblAnswers = new Label();
            pnlLevel.SuspendLayout();
            pnlRank.SuspendLayout();
            pnl.SuspendLayout();
            pnlAccuracy.SuspendLayout();
            SuspendLayout();
            // 
            // pbUserProfile
            // 
            pbUserProfile.Anchor = AnchorStyles.None;
            pbUserProfile.BorderColorOne = Color.FromArgb(0, 100, 255);
            pbUserProfile.BorderColorTwo = Color.FromArgb(50, 200, 255);
            pbUserProfile.BorderStyle = Custom_Controls.PictureFrame.BorderType.Circle;
            pbUserProfile.BorderWidth = 20;
            pbUserProfile.GradientAngle = 45;
            pbUserProfile.GradientRectangle = new Rectangle(0, 0, 222, 222);
            pbUserProfile.Image = Resources.Icons.Icons.User;
            pbUserProfile.ImagePortion = new Rectangle(-256, -256, 1024, 1024);
            pbUserProfile.Location = new Point(264, 41);
            pbUserProfile.Margin = new Padding(2);
            pbUserProfile.Name = "pbUserProfile";
            pbUserProfile.Size = new Size(222, 222);
            pbUserProfile.TabIndex = 0;
            pbUserProfile.Text = "pbProfile";
            // 
            // pnlLevel
            // 
            pnlLevel.Anchor = AnchorStyles.None;
            pnlLevel.BackColor = Color.FromArgb(30, 30, 70);
            pnlLevel.BorderColor = Color.White;
            pnlLevel.BorderWidth = 0;
            pnlLevel.Controls.Add(lblLevel);
            pnlLevel.Controls.Add(pbLevel);
            pnlLevel.Controls.Add(lblExperienceRemainder);
            pnlLevel.Controls.Add(lblLevelTitle);
            pnlLevel.CornerRadius = 20;
            pnlLevel.Location = new Point(47, 345);
            pnlLevel.Margin = new Padding(14, 12, 14, 12);
            pnlLevel.Name = "pnlLevel";
            pnlLevel.Size = new Size(210, 210);
            pnlLevel.TabIndex = 1;
            pnlLevel.Text = "customRectangle1";
            // 
            // lblLevel
            // 
            lblLevel.Anchor = AnchorStyles.Left;
            lblLevel.AutoEllipsis = true;
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblLevel.ForeColor = Color.White;
            lblLevel.Location = new Point(22, 87);
            lblLevel.Margin = new Padding(18, 15, 18, 15);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(30, 33);
            lblLevel.TabIndex = 2;
            lblLevel.Text = "0";
            // 
            // pbLevel
            // 
            pbLevel.Anchor = AnchorStyles.Left;
            pbLevel.Angle = 0;
            pbLevel.BackingColor = Color.White;
            pbLevel.EndColor = Color.FromArgb(50, 200, 255);
            pbLevel.Location = new Point(18, 128);
            pbLevel.Margin = new Padding(10, 9, 10, 9);
            pbLevel.Name = "pbLevel";
            pbLevel.Progress = 0F;
            pbLevel.Size = new Size(168, 14);
            pbLevel.StartColor = Color.FromArgb(0, 100, 255);
            pbLevel.TabIndex = 3;
            pbLevel.Text = "customProgressBar3";
            // 
            // lblExperienceRemainder
            // 
            lblExperienceRemainder.Anchor = AnchorStyles.Left;
            lblExperienceRemainder.AutoEllipsis = true;
            lblExperienceRemainder.AutoSize = true;
            lblExperienceRemainder.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblExperienceRemainder.ForeColor = Color.White;
            lblExperienceRemainder.Location = new Point(22, 141);
            lblExperienceRemainder.Margin = new Padding(18, 15, 18, 15);
            lblExperienceRemainder.Name = "lblExperienceRemainder";
            lblExperienceRemainder.Size = new Size(16, 17);
            lblExperienceRemainder.TabIndex = 2;
            lblExperienceRemainder.Text = "0";
            // 
            // lblLevelTitle
            // 
            lblLevelTitle.AutoEllipsis = true;
            lblLevelTitle.AutoSize = true;
            lblLevelTitle.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLevelTitle.ForeColor = Color.White;
            lblLevelTitle.Location = new Point(18, 15);
            lblLevelTitle.Margin = new Padding(18, 15, 18, 15);
            lblLevelTitle.Name = "lblLevelTitle";
            lblLevelTitle.Size = new Size(72, 29);
            lblLevelTitle.TabIndex = 2;
            lblLevelTitle.Text = "Level";
            // 
            // pnlRank
            // 
            pnlRank.Anchor = AnchorStyles.None;
            pnlRank.BackColor = Color.FromArgb(30, 30, 70);
            pnlRank.BorderColor = Color.White;
            pnlRank.BorderWidth = 0;
            pnlRank.Controls.Add(pnl);
            pnlRank.Controls.Add(lblRankTitle);
            pnlRank.CornerRadius = 20;
            pnlRank.Location = new Point(494, 345);
            pnlRank.Margin = new Padding(14, 12, 14, 12);
            pnlRank.Name = "pnlRank";
            pnlRank.Size = new Size(210, 210);
            pnlRank.TabIndex = 1;
            pnlRank.Text = "customRectangle1";
            // 
            // pnl
            // 
            pnl.Controls.Add(lblRank);
            pnl.Location = new Point(0, 49);
            pnl.Margin = new Padding(2);
            pnl.Name = "pnl";
            pnl.Size = new Size(210, 138);
            pnl.TabIndex = 3;
            // 
            // lblRank
            // 
            lblRank.AutoEllipsis = true;
            lblRank.AutoSize = true;
            lblRank.Font = new Font("Bahnschrift", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRank.ForeColor = Color.White;
            lblRank.Location = new Point(75, 25);
            lblRank.Margin = new Padding(18, 15, 18, 15);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(50, 41);
            lblRank.TabIndex = 2;
            lblRank.Text = "#1";
            // 
            // lblRankTitle
            // 
            lblRankTitle.AutoEllipsis = true;
            lblRankTitle.AutoSize = true;
            lblRankTitle.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblRankTitle.ForeColor = Color.White;
            lblRankTitle.Location = new Point(18, 15);
            lblRankTitle.Margin = new Padding(18, 15, 18, 15);
            lblRankTitle.Name = "lblRankTitle";
            lblRankTitle.Size = new Size(68, 29);
            lblRankTitle.TabIndex = 2;
            lblRankTitle.Text = "Rank";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoEllipsis = true;
            lblUsername.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(55, 277);
            lblUsername.Margin = new Padding(12);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(640, 33);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAccuracy
            // 
            pnlAccuracy.Anchor = AnchorStyles.None;
            pnlAccuracy.BackColor = Color.FromArgb(30, 30, 70);
            pnlAccuracy.BorderColor = Color.White;
            pnlAccuracy.BorderWidth = 0;
            pnlAccuracy.Controls.Add(lblAccuracyTitle);
            pnlAccuracy.Controls.Add(lblPercentageAccuracy);
            pnlAccuracy.Controls.Add(lblCorrect);
            pnlAccuracy.Controls.Add(lblAnswers);
            pnlAccuracy.CornerRadius = 20;
            pnlAccuracy.Location = new Point(270, 345);
            pnlAccuracy.Margin = new Padding(0);
            pnlAccuracy.Name = "pnlAccuracy";
            pnlAccuracy.Size = new Size(210, 210);
            pnlAccuracy.TabIndex = 1;
            pnlAccuracy.Text = "customRectangle1";
            // 
            // lblAccuracyTitle
            // 
            lblAccuracyTitle.AutoEllipsis = true;
            lblAccuracyTitle.AutoSize = true;
            lblAccuracyTitle.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccuracyTitle.ForeColor = Color.White;
            lblAccuracyTitle.Location = new Point(18, 15);
            lblAccuracyTitle.Margin = new Padding(18, 15, 18, 15);
            lblAccuracyTitle.Name = "lblAccuracyTitle";
            lblAccuracyTitle.Size = new Size(113, 29);
            lblAccuracyTitle.TabIndex = 2;
            lblAccuracyTitle.Text = "Accuracy";
            // 
            // lblPercentageAccuracy
            // 
            lblPercentageAccuracy.Anchor = AnchorStyles.Left;
            lblPercentageAccuracy.AutoEllipsis = true;
            lblPercentageAccuracy.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPercentageAccuracy.ForeColor = Color.White;
            lblPercentageAccuracy.Location = new Point(10, 133);
            lblPercentageAccuracy.Margin = new Padding(10, 5, 10, 5);
            lblPercentageAccuracy.Name = "lblPercentageAccuracy";
            lblPercentageAccuracy.Size = new Size(190, 25);
            lblPercentageAccuracy.TabIndex = 2;
            lblPercentageAccuracy.Text = "Percentage accuracy - ";
            // 
            // lblCorrect
            // 
            lblCorrect.Anchor = AnchorStyles.Left;
            lblCorrect.AutoEllipsis = true;
            lblCorrect.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorrect.ForeColor = Color.White;
            lblCorrect.Location = new Point(10, 98);
            lblCorrect.Margin = new Padding(10, 5, 10, 5);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(190, 25);
            lblCorrect.TabIndex = 2;
            lblCorrect.Text = "Questions correct - ";
            // 
            // lblAnswers
            // 
            lblAnswers.Anchor = AnchorStyles.Left;
            lblAnswers.AutoEllipsis = true;
            lblAnswers.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswers.ForeColor = Color.White;
            lblAnswers.Location = new Point(10, 63);
            lblAnswers.Margin = new Padding(10, 5, 10, 5);
            lblAnswers.Name = "lblAnswers";
            lblAnswers.Size = new Size(190, 25);
            lblAnswers.TabIndex = 2;
            lblAnswers.Text = "Questions answered - ";
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(750, 600);
            Controls.Add(lblUsername);
            Controls.Add(pnlAccuracy);
            Controls.Add(pnlRank);
            Controls.Add(pnlLevel);
            Controls.Add(pbUserProfile);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formHome";
            Text = "formUserHome";
            pnlLevel.ResumeLayout(false);
            pnlLevel.PerformLayout();
            pnlRank.ResumeLayout(false);
            pnlRank.PerformLayout();
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
            pnlAccuracy.ResumeLayout(false);
            pnlAccuracy.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Custom_Controls.PictureFrame pbUserProfile;
        private Custom_Controls.CustomRectangle pnlLevel;
        private Custom_Controls.CustomRectangle pnlRank;
        private Label lblUsername;
        private Custom_Controls.CustomProgressBar pbLevel;
        private Label lblExperienceRemainder;
        private Label lblLevelTitle;
        private Label lblRankTitle;
        private Custom_Controls.CustomRectangle pnlAccuracy;
        private Label lblAccuracyTitle;
        private Label lblRank;
        private Label lblPercentageAccuracy;
        private Label lblCorrect;
        private Label lblAnswers;
        private Label lblLevel;
        private Panel pnl;
    }
}