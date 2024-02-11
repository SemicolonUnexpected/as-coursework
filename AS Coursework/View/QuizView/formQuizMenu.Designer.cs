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
            lblQuizInfo = new Label();
            btnAll = new Custom_Controls.CustomButton();
            btnEquations = new Custom_Controls.CustomButton();
            btnFlashcards = new Custom_Controls.CustomButton();
            btnText = new Custom_Controls.CustomButton();
            btnFillTheBlanks = new Custom_Controls.CustomButton();
            btnMultipleChoice = new Custom_Controls.CustomButton();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoEllipsis = true;
            lblUsername.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(30, 398);
            lblUsername.Margin = new Padding(18, 15, 18, 15);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(250, 30);
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
            pbUserProfile.GradientRectangle = new Rectangle(0, 0, 250, 250);
            pbUserProfile.Image = Resources.Icons.Icons.User;
            pbUserProfile.ImagePortion = new Rectangle(-256, -256, 1024, 1024);
            pbUserProfile.Location = new Point(30, 131);
            pbUserProfile.Margin = new Padding(2);
            pbUserProfile.Name = "pbUserProfile";
            pbUserProfile.Size = new Size(250, 250);
            pbUserProfile.TabIndex = 3;
            pbUserProfile.Text = "pbProfile";
            // 
            // lblQuizInfo
            // 
            lblQuizInfo.Anchor = AnchorStyles.None;
            lblQuizInfo.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuizInfo.ForeColor = Color.White;
            lblQuizInfo.Location = new Point(320, 131);
            lblQuizInfo.Margin = new Padding(18, 0, 18, 0);
            lblQuizInfo.MaximumSize = new Size(420, 90);
            lblQuizInfo.MinimumSize = new Size(420, 90);
            lblQuizInfo.Name = "lblQuizInfo";
            lblQuizInfo.Size = new Size(420, 90);
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
            btnAll.CornerRadius = 10;
            btnAll.FlatAppearance.BorderSize = 0;
            btnAll.FlatStyle = FlatStyle.Popup;
            btnAll.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAll.ForeColor = Color.BlanchedAlmond;
            btnAll.Image = null;
            btnAll.ImageSize = new Size(150, 40);
            btnAll.Location = new Point(332, 236);
            btnAll.Margin = new Padding(18, 15, 18, 15);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(175, 45);
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
            btnEquations.CornerRadius = 10;
            btnEquations.FlatAppearance.BorderSize = 0;
            btnEquations.FlatStyle = FlatStyle.Popup;
            btnEquations.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEquations.ForeColor = Color.BlanchedAlmond;
            btnEquations.Image = null;
            btnEquations.ImageSize = new Size(150, 40);
            btnEquations.Location = new Point(542, 386);
            btnEquations.Margin = new Padding(18, 15, 18, 15);
            btnEquations.Name = "btnEquations";
            btnEquations.Size = new Size(175, 45);
            btnEquations.TabIndex = 5;
            btnEquations.Text = "Equations";
            btnEquations.UseVisualStyleBackColor = false;
            btnEquations.Click += btnAllQuestions_Click;
            // 
            // btnFlashcards
            // 
            btnFlashcards.Anchor = AnchorStyles.None;
            btnFlashcards.BackColor = Color.FromArgb(0, 150, 255);
            btnFlashcards.BorderColor = Color.White;
            btnFlashcards.BorderWidth = 2;
            btnFlashcards.CornerRadius = 10;
            btnFlashcards.FlatAppearance.BorderSize = 0;
            btnFlashcards.FlatStyle = FlatStyle.Popup;
            btnFlashcards.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnFlashcards.ForeColor = Color.BlanchedAlmond;
            btnFlashcards.Image = null;
            btnFlashcards.ImageSize = new Size(150, 40);
            btnFlashcards.Location = new Point(542, 236);
            btnFlashcards.Margin = new Padding(18, 15, 18, 15);
            btnFlashcards.Name = "btnFlashcards";
            btnFlashcards.Size = new Size(175, 45);
            btnFlashcards.TabIndex = 1;
            btnFlashcards.Text = "Flashcards";
            btnFlashcards.UseVisualStyleBackColor = false;
            btnFlashcards.Click += btnAllQuestions_Click;
            // 
            // btnText
            // 
            btnText.Anchor = AnchorStyles.None;
            btnText.BackColor = Color.FromArgb(0, 150, 255);
            btnText.BorderColor = Color.White;
            btnText.BorderWidth = 2;
            btnText.CornerRadius = 10;
            btnText.FlatAppearance.BorderSize = 0;
            btnText.FlatStyle = FlatStyle.Popup;
            btnText.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnText.ForeColor = Color.BlanchedAlmond;
            btnText.Image = null;
            btnText.ImageSize = new Size(150, 40);
            btnText.Location = new Point(332, 311);
            btnText.Margin = new Padding(18, 15, 18, 15);
            btnText.Name = "btnText";
            btnText.Size = new Size(175, 45);
            btnText.TabIndex = 2;
            btnText.Text = "Typing";
            btnText.UseVisualStyleBackColor = false;
            btnText.Click += btnAllQuestions_Click;
            // 
            // btnFillTheBlanks
            // 
            btnFillTheBlanks.Anchor = AnchorStyles.None;
            btnFillTheBlanks.BackColor = Color.FromArgb(0, 150, 255);
            btnFillTheBlanks.BorderColor = Color.White;
            btnFillTheBlanks.BorderWidth = 2;
            btnFillTheBlanks.CornerRadius = 10;
            btnFillTheBlanks.FlatAppearance.BorderSize = 0;
            btnFillTheBlanks.FlatStyle = FlatStyle.Popup;
            btnFillTheBlanks.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnFillTheBlanks.ForeColor = Color.BlanchedAlmond;
            btnFillTheBlanks.Image = null;
            btnFillTheBlanks.ImageSize = new Size(150, 40);
            btnFillTheBlanks.Location = new Point(542, 311);
            btnFillTheBlanks.Margin = new Padding(18, 15, 18, 15);
            btnFillTheBlanks.Name = "btnFillTheBlanks";
            btnFillTheBlanks.Size = new Size(175, 45);
            btnFillTheBlanks.TabIndex = 3;
            btnFillTheBlanks.Text = "Fill the blanks";
            btnFillTheBlanks.UseVisualStyleBackColor = false;
            btnFillTheBlanks.Click += btnAllQuestions_Click;
            // 
            // btnMultipleChoice
            // 
            btnMultipleChoice.Anchor = AnchorStyles.None;
            btnMultipleChoice.BackColor = Color.FromArgb(0, 150, 255);
            btnMultipleChoice.BorderColor = Color.White;
            btnMultipleChoice.BorderWidth = 2;
            btnMultipleChoice.CornerRadius = 10;
            btnMultipleChoice.FlatAppearance.BorderSize = 0;
            btnMultipleChoice.FlatStyle = FlatStyle.Popup;
            btnMultipleChoice.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultipleChoice.ForeColor = Color.BlanchedAlmond;
            btnMultipleChoice.Image = null;
            btnMultipleChoice.ImageSize = new Size(150, 40);
            btnMultipleChoice.Location = new Point(332, 386);
            btnMultipleChoice.Margin = new Padding(18, 15, 18, 15);
            btnMultipleChoice.Name = "btnMultipleChoice";
            btnMultipleChoice.Size = new Size(175, 45);
            btnMultipleChoice.TabIndex = 4;
            btnMultipleChoice.Text = "Multiple choice";
            btnMultipleChoice.UseVisualStyleBackColor = false;
            btnMultipleChoice.Click += btnAllQuestions_Click;
            // 
            // formQuizMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(750, 600);
            Controls.Add(pbUserProfile);
            Controls.Add(lblUsername);
            Controls.Add(btnMultipleChoice);
            Controls.Add(btnFillTheBlanks);
            Controls.Add(btnText);
            Controls.Add(btnFlashcards);
            Controls.Add(btnEquations);
            Controls.Add(btnAll);
            Controls.Add(lblQuizInfo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formQuizMenu";
            Text = "formUserHome";
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsername;
        private Custom_Controls.PictureFrame pbUserProfile;
        private Label lblQuizInfo;
        private Custom_Controls.CustomButton btnAll;
        private Custom_Controls.CustomButton btnEquations;
        private Custom_Controls.CustomButton btnFlashcards;
        private Custom_Controls.CustomButton btnText;
        private Custom_Controls.CustomButton btnFillTheBlanks;
        private Custom_Controls.CustomButton btnMultipleChoice;
    }
}