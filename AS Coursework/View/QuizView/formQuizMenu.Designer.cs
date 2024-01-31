namespace AS_Coursework.View.QuizView {
    partial class formQuizMenu {
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
            pnlUserProfile = new Panel();
            lblQuizInfo = new Label();
            btnAll = new Custom_Controls.CustomButton();
            btnEquations = new Custom_Controls.CustomButton();
            btnFlashcards = new Custom_Controls.CustomButton();
            btnText = new Custom_Controls.CustomButton();
            btnFillTheBlanks = new Custom_Controls.CustomButton();
            btnMultipleChoice = new Custom_Controls.CustomButton();
            pnlUserProfile.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Bottom;
            lblUsername.AutoEllipsis = true;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(50, 425);
            lblUsername.Margin = new Padding(25);
            lblUsername.MaximumSize = new Size(300, 50);
            lblUsername.MinimumSize = new Size(300, 50);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(300, 50);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username is far too long fo this";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbUserProfile
            // 
            pbUserProfile.Anchor = AnchorStyles.Top;
            pbUserProfile.BorderColorOne = Color.FromArgb(0, 100, 255);
            pbUserProfile.BorderColorTwo = Color.FromArgb(50, 200, 255);
            pbUserProfile.BorderStyle = Custom_Controls.PictureFrame.BorderType.Circle;
            pbUserProfile.BorderWidth = 30;
            pbUserProfile.GradientAngle = 45;
            pbUserProfile.GradientRectangle = new Rectangle(0, 0, 350, 350);
            pbUserProfile.Image = Resources.Icons.User;
            pbUserProfile.ImagePortion = new Rectangle(-256, -256, 1024, 1024);
            pbUserProfile.Location = new Point(0, 0);
            pbUserProfile.Name = "pbUserProfile";
            pbUserProfile.Size = new Size(400, 400);
            pbUserProfile.TabIndex = 3;
            pbUserProfile.Text = "pbProfile";
            // 
            // pnlUserProfile
            // 
            pnlUserProfile.Anchor = AnchorStyles.None;
            pnlUserProfile.Controls.Add(lblUsername);
            pnlUserProfile.Controls.Add(pbUserProfile);
            pnlUserProfile.Location = new Point(34, 168);
            pnlUserProfile.Margin = new Padding(25);
            pnlUserProfile.Name = "pnlUserProfile";
            pnlUserProfile.Size = new Size(400, 500);
            pnlUserProfile.TabIndex = 5;
            // 
            // lblQuizInfo
            // 
            lblQuizInfo.Anchor = AnchorStyles.None;
            lblQuizInfo.AutoSize = true;
            lblQuizInfo.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuizInfo.ForeColor = Color.White;
            lblQuizInfo.Location = new Point(484, 168);
            lblQuizInfo.Margin = new Padding(25, 0, 25, 0);
            lblQuizInfo.MaximumSize = new Size(600, 150);
            lblQuizInfo.MinimumSize = new Size(600, 150);
            lblQuizInfo.Name = "lblQuizInfo";
            lblQuizInfo.Size = new Size(600, 150);
            lblQuizInfo.TabIndex = 6;
            lblQuizInfo.Text = "Welcome to the quiz. Select a quiz below to begin. You gain expeience for each question you answer correctly";
            lblQuizInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAll
            // 
            btnAll.Anchor = AnchorStyles.None;
            btnAll.BackColor = Color.FromArgb(0, 150, 255);
            btnAll.BorderColor = Color.White;
            btnAll.BorderWidth = 2;
            btnAll.CornerRadius = 20;
            btnAll.FlatAppearance.BorderSize = 0;
            btnAll.FlatStyle = FlatStyle.Popup;
            btnAll.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAll.ForeColor = Color.BlanchedAlmond;
            btnAll.Image = null;
            btnAll.ImageSize = new Size(150, 40);
            btnAll.Location = new Point(502, 343);
            btnAll.Margin = new Padding(25);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(250, 75);
            btnAll.TabIndex = 0;
            btnAll.Text = "All questions";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAllQuestions_Click;
            // 
            // btnEquations
            // 
            btnEquations.Anchor = AnchorStyles.None;
            btnEquations.BackColor = Color.FromArgb(0, 150, 255);
            btnEquations.BorderColor = Color.White;
            btnEquations.BorderWidth = 2;
            btnEquations.CornerRadius = 20;
            btnEquations.FlatAppearance.BorderSize = 0;
            btnEquations.FlatStyle = FlatStyle.Popup;
            btnEquations.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEquations.ForeColor = Color.BlanchedAlmond;
            btnEquations.Image = null;
            btnEquations.ImageSize = new Size(150, 40);
            btnEquations.Location = new Point(802, 593);
            btnEquations.Margin = new Padding(25);
            btnEquations.Name = "btnEquations";
            btnEquations.Size = new Size(250, 75);
            btnEquations.TabIndex = 5;
            btnEquations.Text = "Equations";
            btnEquations.UseVisualStyleBackColor = false;
            // 
            // btnFlashcards
            // 
            btnFlashcards.Anchor = AnchorStyles.None;
            btnFlashcards.BackColor = Color.FromArgb(0, 150, 255);
            btnFlashcards.BorderColor = Color.White;
            btnFlashcards.BorderWidth = 2;
            btnFlashcards.CornerRadius = 20;
            btnFlashcards.FlatAppearance.BorderSize = 0;
            btnFlashcards.FlatStyle = FlatStyle.Popup;
            btnFlashcards.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnFlashcards.ForeColor = Color.BlanchedAlmond;
            btnFlashcards.Image = null;
            btnFlashcards.ImageSize = new Size(150, 40);
            btnFlashcards.Location = new Point(802, 343);
            btnFlashcards.Margin = new Padding(25);
            btnFlashcards.Name = "btnFlashcards";
            btnFlashcards.Size = new Size(250, 75);
            btnFlashcards.TabIndex = 1;
            btnFlashcards.Text = "Flashcards";
            btnFlashcards.UseVisualStyleBackColor = false;
            // 
            // btnText
            // 
            btnText.Anchor = AnchorStyles.None;
            btnText.BackColor = Color.FromArgb(0, 150, 255);
            btnText.BorderColor = Color.White;
            btnText.BorderWidth = 2;
            btnText.CornerRadius = 20;
            btnText.FlatAppearance.BorderSize = 0;
            btnText.FlatStyle = FlatStyle.Popup;
            btnText.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnText.ForeColor = Color.BlanchedAlmond;
            btnText.Image = null;
            btnText.ImageSize = new Size(150, 40);
            btnText.Location = new Point(502, 468);
            btnText.Margin = new Padding(25);
            btnText.Name = "btnText";
            btnText.Size = new Size(250, 75);
            btnText.TabIndex = 2;
            btnText.Text = "Typing";
            btnText.UseVisualStyleBackColor = false;
            // 
            // btnFillTheBlanks
            // 
            btnFillTheBlanks.Anchor = AnchorStyles.None;
            btnFillTheBlanks.BackColor = Color.FromArgb(0, 150, 255);
            btnFillTheBlanks.BorderColor = Color.White;
            btnFillTheBlanks.BorderWidth = 2;
            btnFillTheBlanks.CornerRadius = 20;
            btnFillTheBlanks.FlatAppearance.BorderSize = 0;
            btnFillTheBlanks.FlatStyle = FlatStyle.Popup;
            btnFillTheBlanks.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnFillTheBlanks.ForeColor = Color.BlanchedAlmond;
            btnFillTheBlanks.Image = null;
            btnFillTheBlanks.ImageSize = new Size(150, 40);
            btnFillTheBlanks.Location = new Point(802, 468);
            btnFillTheBlanks.Margin = new Padding(25);
            btnFillTheBlanks.Name = "btnFillTheBlanks";
            btnFillTheBlanks.Size = new Size(250, 75);
            btnFillTheBlanks.TabIndex = 3;
            btnFillTheBlanks.Text = "Fill the blanks";
            btnFillTheBlanks.UseVisualStyleBackColor = false;
            // 
            // btnMultipleChoice
            // 
            btnMultipleChoice.Anchor = AnchorStyles.None;
            btnMultipleChoice.BackColor = Color.FromArgb(0, 150, 255);
            btnMultipleChoice.BorderColor = Color.White;
            btnMultipleChoice.BorderWidth = 2;
            btnMultipleChoice.CornerRadius = 20;
            btnMultipleChoice.FlatAppearance.BorderSize = 0;
            btnMultipleChoice.FlatStyle = FlatStyle.Popup;
            btnMultipleChoice.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultipleChoice.ForeColor = Color.BlanchedAlmond;
            btnMultipleChoice.Image = null;
            btnMultipleChoice.ImageSize = new Size(150, 40);
            btnMultipleChoice.Location = new Point(502, 593);
            btnMultipleChoice.Margin = new Padding(25);
            btnMultipleChoice.Name = "btnMultipleChoice";
            btnMultipleChoice.Size = new Size(250, 75);
            btnMultipleChoice.TabIndex = 4;
            btnMultipleChoice.Text = "Multiple choice";
            btnMultipleChoice.UseVisualStyleBackColor = false;
            // 
            // formQuizMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(1125, 900);
            Controls.Add(btnMultipleChoice);
            Controls.Add(btnFillTheBlanks);
            Controls.Add(btnText);
            Controls.Add(btnFlashcards);
            Controls.Add(btnEquations);
            Controls.Add(btnAll);
            Controls.Add(lblQuizInfo);
            Controls.Add(pnlUserProfile);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formQuizMenu";
            Text = "formUserHome";
            pnlUserProfile.ResumeLayout(false);
            pnlUserProfile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Custom_Controls.PictureFrame pbUserProfile;
        private Panel pnlUserProfile;
        private Label lblQuizInfo;
        private Custom_Controls.CustomButton btnAll;
        private Custom_Controls.CustomButton btnEquations;
        private Custom_Controls.CustomButton btnFlashcards;
        private Custom_Controls.CustomButton btnText;
        private Custom_Controls.CustomButton btnFillTheBlanks;
        private Custom_Controls.CustomButton btnMultipleChoice;
    }
}