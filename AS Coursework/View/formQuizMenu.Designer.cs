namespace AS_Coursework.View {
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
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblUsername = new Label();
            pbUserProfile = new Custom_Controls.PictureFrame();
            pnlUserProfile = new Panel();
            lblQuizInfo = new Label();
            btnStartQuizAllQuestions = new Custom_Controls.CustomButton();
            customButton1 = new Custom_Controls.CustomButton();
            btnFlashcards = new Custom_Controls.CustomButton();
            btnTextQuestions = new Custom_Controls.CustomButton();
            btnFillTheBlanks = new Custom_Controls.CustomButton();
            btnMultipleChoiceQuestions = new Custom_Controls.CustomButton();
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
            lblQuizInfo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
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
            lblQuizInfo.Click += lblQuizInfo_Click;
            // 
            // btnStartQuizAllQuestions
            // 
            btnStartQuizAllQuestions.Anchor = AnchorStyles.Right;
            btnStartQuizAllQuestions.BackColor = Color.FromArgb(0, 150, 255);
            btnStartQuizAllQuestions.BorderColor = Color.White;
            btnStartQuizAllQuestions.BorderWidth = 2;
            btnStartQuizAllQuestions.CornerRadius = 20;
            btnStartQuizAllQuestions.FlatAppearance.BorderSize = 0;
            btnStartQuizAllQuestions.FlatStyle = FlatStyle.Popup;
            btnStartQuizAllQuestions.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartQuizAllQuestions.ForeColor = Color.BlanchedAlmond;
            btnStartQuizAllQuestions.Image = null;
            btnStartQuizAllQuestions.ImageSize = new Size(150, 40);
            btnStartQuizAllQuestions.Location = new Point(502, 343);
            btnStartQuizAllQuestions.Margin = new Padding(25);
            btnStartQuizAllQuestions.Name = "btnStartQuizAllQuestions";
            btnStartQuizAllQuestions.Size = new Size(250, 75);
            btnStartQuizAllQuestions.TabIndex = 10;
            btnStartQuizAllQuestions.Text = "All questions";
            btnStartQuizAllQuestions.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            customButton1.Anchor = AnchorStyles.Right;
            customButton1.BackColor = Color.FromArgb(0, 150, 255);
            customButton1.BorderColor = Color.White;
            customButton1.BorderWidth = 2;
            customButton1.CornerRadius = 20;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Popup;
            customButton1.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            customButton1.ForeColor = Color.BlanchedAlmond;
            customButton1.Image = null;
            customButton1.ImageSize = new Size(150, 40);
            customButton1.Location = new Point(802, 593);
            customButton1.Margin = new Padding(25);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(250, 75);
            customButton1.TabIndex = 11;
            customButton1.Text = "Done";
            customButton1.UseVisualStyleBackColor = false;
            // 
            // btnFlashcards
            // 
            btnFlashcards.Anchor = AnchorStyles.Right;
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
            btnFlashcards.TabIndex = 12;
            btnFlashcards.Text = "Flashcards";
            btnFlashcards.UseVisualStyleBackColor = false;
            // 
            // btnTextQuestions
            // 
            btnTextQuestions.Anchor = AnchorStyles.Right;
            btnTextQuestions.BackColor = Color.FromArgb(0, 150, 255);
            btnTextQuestions.BorderColor = Color.White;
            btnTextQuestions.BorderWidth = 2;
            btnTextQuestions.CornerRadius = 20;
            btnTextQuestions.FlatAppearance.BorderSize = 0;
            btnTextQuestions.FlatStyle = FlatStyle.Popup;
            btnTextQuestions.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnTextQuestions.ForeColor = Color.BlanchedAlmond;
            btnTextQuestions.Image = null;
            btnTextQuestions.ImageSize = new Size(150, 40);
            btnTextQuestions.Location = new Point(502, 468);
            btnTextQuestions.Margin = new Padding(25);
            btnTextQuestions.Name = "btnTextQuestions";
            btnTextQuestions.Size = new Size(250, 75);
            btnTextQuestions.TabIndex = 13;
            btnTextQuestions.Text = "Typing";
            btnTextQuestions.UseVisualStyleBackColor = false;
            btnTextQuestions.Click += customButton3_Click;
            // 
            // btnFillTheBlanks
            // 
            btnFillTheBlanks.Anchor = AnchorStyles.Right;
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
            btnFillTheBlanks.TabIndex = 14;
            btnFillTheBlanks.Text = "Fill the blanks";
            btnFillTheBlanks.UseVisualStyleBackColor = false;
            // 
            // btnMultipleChoiceQuestions
            // 
            btnMultipleChoiceQuestions.Anchor = AnchorStyles.Right;
            btnMultipleChoiceQuestions.BackColor = Color.FromArgb(0, 150, 255);
            btnMultipleChoiceQuestions.BorderColor = Color.White;
            btnMultipleChoiceQuestions.BorderWidth = 2;
            btnMultipleChoiceQuestions.CornerRadius = 20;
            btnMultipleChoiceQuestions.FlatAppearance.BorderSize = 0;
            btnMultipleChoiceQuestions.FlatStyle = FlatStyle.Popup;
            btnMultipleChoiceQuestions.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultipleChoiceQuestions.ForeColor = Color.BlanchedAlmond;
            btnMultipleChoiceQuestions.Image = null;
            btnMultipleChoiceQuestions.ImageSize = new Size(150, 40);
            btnMultipleChoiceQuestions.Location = new Point(502, 593);
            btnMultipleChoiceQuestions.Margin = new Padding(25);
            btnMultipleChoiceQuestions.Name = "btnMultipleChoiceQuestions";
            btnMultipleChoiceQuestions.Size = new Size(250, 75);
            btnMultipleChoiceQuestions.TabIndex = 15;
            btnMultipleChoiceQuestions.Text = "Multiple choice";
            btnMultipleChoiceQuestions.UseVisualStyleBackColor = false;
            // 
            // formQuizMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(1125, 900);
            Controls.Add(btnMultipleChoiceQuestions);
            Controls.Add(btnFillTheBlanks);
            Controls.Add(btnTextQuestions);
            Controls.Add(btnFlashcards);
            Controls.Add(customButton1);
            Controls.Add(btnStartQuizAllQuestions);
            Controls.Add(lblQuizInfo);
            Controls.Add(pnlUserProfile);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formQuizMenu";
            Text = "formUserHome";
            Load += formQuizMenu_Load;
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
        private Custom_Controls.CustomButton btnStartQuizAllQuestions;
        private Custom_Controls.CustomButton customButton1;
        private Custom_Controls.CustomButton btnFlashcards;
        private Custom_Controls.CustomButton btnTextQuestions;
        private Custom_Controls.CustomButton btnFillTheBlanks;
        private Custom_Controls.CustomButton btnMultipleChoiceQuestions;
    }
}