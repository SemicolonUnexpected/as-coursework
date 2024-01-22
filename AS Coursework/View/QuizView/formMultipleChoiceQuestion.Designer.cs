namespace AS_Coursework.View.QuizView {
    partial class formMultipleChoiceQuestion {
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
            lblQuestionTitle = new Label();
            btnOptionFour = new Custom_Controls.CustomButton();
            btnOptionThree = new Custom_Controls.CustomButton();
            btnOptionTwo = new Custom_Controls.CustomButton();
            btnOptionOne = new Custom_Controls.CustomButton();
            lblQuestionText = new Label();
            btnNext = new Custom_Controls.CustomButton();
            lblIsCorrect = new Label();
            SuspendLayout();
            // 
            // lblQuestionTitle
            // 
            lblQuestionTitle.Anchor = AnchorStyles.None;
            lblQuestionTitle.AutoSize = true;
            lblQuestionTitle.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionTitle.ForeColor = Color.White;
            lblQuestionTitle.Location = new Point(344, 34);
            lblQuestionTitle.Margin = new Padding(25);
            lblQuestionTitle.MaximumSize = new Size(450, 0);
            lblQuestionTitle.Name = "lblQuestionTitle";
            lblQuestionTitle.Size = new Size(263, 48);
            lblQuestionTitle.TabIndex = 11;
            lblQuestionTitle.Text = "Question Title";
            lblQuestionTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOptionFour
            // 
            btnOptionFour.Anchor = AnchorStyles.Right;
            btnOptionFour.BackColor = Color.FromArgb(0, 150, 255);
            btnOptionFour.BorderColor = Color.White;
            btnOptionFour.BorderWidth = 2;
            btnOptionFour.CornerRadius = 20;
            btnOptionFour.FlatAppearance.BorderSize = 0;
            btnOptionFour.FlatStyle = FlatStyle.Popup;
            btnOptionFour.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOptionFour.ForeColor = Color.BlanchedAlmond;
            btnOptionFour.Image = null;
            btnOptionFour.ImageSize = new Size(150, 40);
            btnOptionFour.Location = new Point(493, 509);
            btnOptionFour.Margin = new Padding(25);
            btnOptionFour.Name = "btnOptionFour";
            btnOptionFour.Size = new Size(300, 150);
            btnOptionFour.TabIndex = 15;
            btnOptionFour.Text = "Fill the blanks";
            btnOptionFour.UseVisualStyleBackColor = false;
            // 
            // btnOption3
            // 
            btnOptionThree.Anchor = AnchorStyles.Right;
            btnOptionThree.BackColor = Color.FromArgb(0, 150, 255);
            btnOptionThree.BorderColor = Color.White;
            btnOptionThree.BorderWidth = 2;
            btnOptionThree.CornerRadius = 20;
            btnOptionThree.FlatAppearance.BorderSize = 0;
            btnOptionThree.FlatStyle = FlatStyle.Popup;
            btnOptionThree.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOptionThree.ForeColor = Color.BlanchedAlmond;
            btnOptionThree.Image = null;
            btnOptionThree.ImageSize = new Size(150, 40);
            btnOptionThree.Location = new Point(143, 509);
            btnOptionThree.Margin = new Padding(25);
            btnOptionThree.Name = "btnOption3";
            btnOptionThree.Size = new Size(300, 150);
            btnOptionThree.TabIndex = 14;
            btnOptionThree.Text = "Typing";
            btnOptionThree.UseVisualStyleBackColor = false;
            // 
            // btnOptionTwo
            // 
            btnOptionTwo.Anchor = AnchorStyles.Right;
            btnOptionTwo.BackColor = Color.FromArgb(0, 150, 255);
            btnOptionTwo.BorderColor = Color.White;
            btnOptionTwo.BorderWidth = 2;
            btnOptionTwo.CornerRadius = 20;
            btnOptionTwo.FlatAppearance.BorderSize = 0;
            btnOptionTwo.FlatStyle = FlatStyle.Popup;
            btnOptionTwo.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOptionTwo.ForeColor = Color.BlanchedAlmond;
            btnOptionTwo.Image = null;
            btnOptionTwo.ImageSize = new Size(150, 40);
            btnOptionTwo.Location = new Point(493, 309);
            btnOptionTwo.Margin = new Padding(25);
            btnOptionTwo.Name = "btnOptionTwo";
            btnOptionTwo.Size = new Size(300, 150);
            btnOptionTwo.TabIndex = 13;
            btnOptionTwo.Text = "Flashcards";
            btnOptionTwo.UseVisualStyleBackColor = false;
            // 
            // btnOptionOne
            // 
            btnOptionOne.Anchor = AnchorStyles.Right;
            btnOptionOne.BackColor = Color.FromArgb(0, 150, 255);
            btnOptionOne.BorderColor = Color.White;
            btnOptionOne.BorderWidth = 2;
            btnOptionOne.CornerRadius = 20;
            btnOptionOne.FlatAppearance.BorderSize = 0;
            btnOptionOne.FlatStyle = FlatStyle.Popup;
            btnOptionOne.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOptionOne.ForeColor = Color.BlanchedAlmond;
            btnOptionOne.Image = null;
            btnOptionOne.ImageSize = new Size(150, 40);
            btnOptionOne.Location = new Point(143, 309);
            btnOptionOne.Margin = new Padding(25);
            btnOptionOne.Name = "btnOptionOne";
            btnOptionOne.Size = new Size(300, 150);
            btnOptionOne.TabIndex = 12;
            btnOptionOne.Text = "All questions";
            btnOptionOne.UseVisualStyleBackColor = false;
            // 
            // lblQuestionText
            // 
            lblQuestionText.Anchor = AnchorStyles.None;
            lblQuestionText.AutoSize = true;
            lblQuestionText.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionText.ForeColor = Color.White;
            lblQuestionText.Location = new Point(70, 194);
            lblQuestionText.Margin = new Padding(25, 25, 25, 20);
            lblQuestionText.MaximumSize = new Size(800, 68);
            lblQuestionText.MinimumSize = new Size(800, 68);
            lblQuestionText.Name = "lblQuestionText";
            lblQuestionText.Size = new Size(800, 68);
            lblQuestionText.TabIndex = 16;
            lblQuestionText.Text = "Two lines of question text. The questions wont be much longer than this hopefully";
            lblQuestionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(0, 150, 255);
            btnNext.BorderColor = Color.White;
            btnNext.BorderWidth = 2;
            btnNext.CornerRadius = 20;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.BlanchedAlmond;
            btnNext.Image = null;
            btnNext.ImageSize = new Size(150, 40);
            btnNext.Location = new Point(840, 831);
            btnNext.Margin = new Padding(10);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(116, 50);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblIsCorrect
            // 
            lblIsCorrect.Anchor = AnchorStyles.None;
            lblIsCorrect.AutoSize = true;
            lblIsCorrect.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblIsCorrect.ForeColor = Color.White;
            lblIsCorrect.Location = new Point(70, 709);
            lblIsCorrect.Margin = new Padding(25);
            lblIsCorrect.MaximumSize = new Size(800, 68);
            lblIsCorrect.MinimumSize = new Size(800, 68);
            lblIsCorrect.Name = "lblIsCorrect";
            lblIsCorrect.Size = new Size(800, 68);
            lblIsCorrect.TabIndex = 18;
            lblIsCorrect.Text = "Incorrect. Better luck next time. The correct answer was: this very very long sentence to stress test the textbox size\r\n";
            lblIsCorrect.TextAlign = ContentAlignment.TopCenter;
            // 
            // formMultipleChoiceQuestion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(975, 900);
            Controls.Add(lblIsCorrect);
            Controls.Add(btnNext);
            Controls.Add(lblQuestionText);
            Controls.Add(btnOptionFour);
            Controls.Add(btnOptionThree);
            Controls.Add(btnOptionTwo);
            Controls.Add(btnOptionOne);
            Controls.Add(lblQuestionTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formMultipleChoiceQuestion";
            Text = "TextQuestion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestionTitle;
        private Custom_Controls.CustomButton btnOptionFour;
        private Custom_Controls.CustomButton btnOptionThree;
        private Custom_Controls.CustomButton btnOptionTwo;
        private Custom_Controls.CustomButton btnOptionOne;
        private Label lblQuestionText;
        private Custom_Controls.CustomButton btnNext;
        private Label lblIsCorrect;
    }
}