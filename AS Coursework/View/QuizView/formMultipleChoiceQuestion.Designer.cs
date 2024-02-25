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
            SuspendLayout();
            // 
            // lblQuestionTitle
            // 
            lblQuestionTitle.Anchor = AnchorStyles.None;
            lblQuestionTitle.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionTitle.ForeColor = Color.White;
            lblQuestionTitle.Location = new Point(260, 19);
            lblQuestionTitle.Margin = new Padding(10);
            lblQuestionTitle.MaximumSize = new Size(315, 0);
            lblQuestionTitle.Name = "lblQuestionTitle";
            lblQuestionTitle.Size = new Size(180, 33);
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
            btnOptionFour.Location = new Point(363, 303);
            btnOptionFour.Margin = new Padding(10);
            btnOptionFour.Name = "btnOptionFour";
            btnOptionFour.Size = new Size(210, 90);
            btnOptionFour.TabIndex = 15;
            btnOptionFour.Text = "Fill the blanks";
            btnOptionFour.UseVisualStyleBackColor = false;
            btnOptionFour.Click += btnClick;
            // 
            // btnOptionThree
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
            btnOptionThree.Location = new Point(133, 303);
            btnOptionThree.Margin = new Padding(10);
            btnOptionThree.Name = "btnOptionThree";
            btnOptionThree.Size = new Size(210, 90);
            btnOptionThree.TabIndex = 14;
            btnOptionThree.Text = "Typing";
            btnOptionThree.UseVisualStyleBackColor = false;
            btnOptionThree.Click += btnClick;
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
            btnOptionTwo.Location = new Point(363, 193);
            btnOptionTwo.Margin = new Padding(10);
            btnOptionTwo.Name = "btnOptionTwo";
            btnOptionTwo.Size = new Size(210, 90);
            btnOptionTwo.TabIndex = 13;
            btnOptionTwo.Text = "Flashcards";
            btnOptionTwo.UseVisualStyleBackColor = false;
            btnOptionTwo.Click += btnClick;
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
            btnOptionOne.Location = new Point(133, 193);
            btnOptionOne.Margin = new Padding(10);
            btnOptionOne.Name = "btnOptionOne";
            btnOptionOne.Size = new Size(210, 90);
            btnOptionOne.TabIndex = 12;
            btnOptionOne.Text = "All questions";
            btnOptionOne.UseVisualStyleBackColor = false;
            btnOptionOne.Click += btnClick;
            // 
            // lblQuestionText
            // 
            lblQuestionText.Anchor = AnchorStyles.None;
            lblQuestionText.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionText.ForeColor = Color.White;
            lblQuestionText.Location = new Point(19, 72);
            lblQuestionText.Margin = new Padding(10);
            lblQuestionText.Name = "lblQuestionText";
            lblQuestionText.Size = new Size(662, 101);
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
            btnNext.CornerRadius = 10;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.BlanchedAlmond;
            btnNext.Image = null;
            btnNext.ImageSize = new Size(150, 40);
            btnNext.Location = new Point(600, 551);
            btnNext.Margin = new Padding(10);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(81, 30);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // formMultipleChoiceQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(700, 600);
            Controls.Add(btnNext);
            Controls.Add(lblQuestionText);
            Controls.Add(btnOptionFour);
            Controls.Add(btnOptionThree);
            Controls.Add(btnOptionTwo);
            Controls.Add(btnOptionOne);
            Controls.Add(lblQuestionTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formMultipleChoiceQuestion";
            Text = "TextQuestion";
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuestionTitle;
        private Custom_Controls.CustomButton btnOptionFour;
        private Custom_Controls.CustomButton btnOptionThree;
        private Custom_Controls.CustomButton btnOptionTwo;
        private Custom_Controls.CustomButton btnOptionOne;
        private Label lblQuestionText;
        private Custom_Controls.CustomButton btnNext;
    }
}