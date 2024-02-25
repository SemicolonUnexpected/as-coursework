namespace AS_Coursework.View.QuizView {
    partial class formTypingQuestion {
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
            tbAnswer = new Custom_Controls.CustomTextbox();
            lblAnswerTitle = new Label();
            pnlAnswer = new Panel();
            btnSubmitNext = new Custom_Controls.CustomButton();
            pbIsCorrect = new PictureBox();
            lblQuestionTitle = new Label();
            lblQuestionText = new Label();
            pb = new Custom_Controls.PicturePanel();
            lblIsCorrect = new Label();
            pnlQuestionAnswer = new Panel();
            pnlAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIsCorrect).BeginInit();
            pnlQuestionAnswer.SuspendLayout();
            SuspendLayout();
            // 
            // tbAnswer
            // 
            tbAnswer.Anchor = AnchorStyles.None;
            tbAnswer.BackColor = Color.FromArgb(20, 20, 50);
            tbAnswer.BorderColor = Color.White;
            tbAnswer.BorderFocusColor = Color.White;
            tbAnswer.BorderSize = 2;
            tbAnswer.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbAnswer.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbAnswer.ForeColor = Color.White;
            tbAnswer.IsMultiline = false;
            tbAnswer.Location = new Point(75, 8);
            tbAnswer.Margin = new Padding(0, 4, 0, 4);
            tbAnswer.Name = "tbAnswer";
            tbAnswer.Padding = new Padding(5, 4, 5, 4);
            tbAnswer.PlaceholderText = "";
            tbAnswer.PlaceholderTextColor = Color.White;
            tbAnswer.ShortcutEnabled = true;
            tbAnswer.Size = new Size(364, 32);
            tbAnswer.TabIndex = 0;
            tbAnswer.UsePasswordChar = false;
            // 
            // lblAnswerTitle
            // 
            lblAnswerTitle.Anchor = AnchorStyles.None;
            lblAnswerTitle.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswerTitle.ForeColor = Color.White;
            lblAnswerTitle.Location = new Point(7, 6);
            lblAnswerTitle.Margin = new Padding(7, 6, 7, 6);
            lblAnswerTitle.MaximumSize = new Size(315, 0);
            lblAnswerTitle.Name = "lblAnswerTitle";
            lblAnswerTitle.Size = new Size(61, 38);
            lblAnswerTitle.TabIndex = 11;
            lblAnswerTitle.Text = "Ans:";
            lblAnswerTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAnswer
            // 
            pnlAnswer.Anchor = AnchorStyles.None;
            pnlAnswer.Controls.Add(btnSubmitNext);
            pnlAnswer.Controls.Add(pbIsCorrect);
            pnlAnswer.Controls.Add(lblAnswerTitle);
            pnlAnswer.Controls.Add(tbAnswer);
            pnlAnswer.Location = new Point(55, 90);
            pnlAnswer.Margin = new Padding(5);
            pnlAnswer.Name = "pnlAnswer";
            pnlAnswer.Size = new Size(560, 50);
            pnlAnswer.TabIndex = 12;
            // 
            // btnSubmitNext
            // 
            btnSubmitNext.Anchor = AnchorStyles.None;
            btnSubmitNext.BackColor = Color.FromArgb(0, 150, 255);
            btnSubmitNext.BorderColor = Color.White;
            btnSubmitNext.BorderWidth = 2;
            btnSubmitNext.CornerRadius = 10;
            btnSubmitNext.FlatAppearance.BorderSize = 0;
            btnSubmitNext.FlatStyle = FlatStyle.Popup;
            btnSubmitNext.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmitNext.ForeColor = Color.BlanchedAlmond;
            btnSubmitNext.Image = null;
            btnSubmitNext.ImageSize = new Size(150, 40);
            btnSubmitNext.Location = new Point(479, 10);
            btnSubmitNext.Margin = new Padding(0, 10, 0, 10);
            btnSubmitNext.Name = "btnSubmitNext";
            btnSubmitNext.Size = new Size(81, 30);
            btnSubmitNext.TabIndex = 14;
            btnSubmitNext.Text = "Submit";
            btnSubmitNext.UseVisualStyleBackColor = false;
            btnSubmitNext.Click += btnSubmitNext_Click;
            // 
            // pbIsCorrect
            // 
            pbIsCorrect.Anchor = AnchorStyles.None;
            pbIsCorrect.Location = new Point(444, 10);
            pbIsCorrect.Margin = new Padding(5);
            pbIsCorrect.Name = "pbIsCorrect";
            pbIsCorrect.Size = new Size(30, 30);
            pbIsCorrect.SizeMode = PictureBoxSizeMode.StretchImage;
            pbIsCorrect.TabIndex = 12;
            pbIsCorrect.TabStop = false;
            // 
            // lblQuestionTitle
            // 
            lblQuestionTitle.Anchor = AnchorStyles.None;
            lblQuestionTitle.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionTitle.ForeColor = Color.White;
            lblQuestionTitle.Location = new Point(249, 24);
            lblQuestionTitle.Margin = new Padding(18, 15, 18, 15);
            lblQuestionTitle.Name = "lblQuestionTitle";
            lblQuestionTitle.Size = new Size(180, 39);
            lblQuestionTitle.TabIndex = 11;
            lblQuestionTitle.Text = "Question Title";
            lblQuestionTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuestionText
            // 
            lblQuestionText.Anchor = AnchorStyles.None;
            lblQuestionText.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionText.ForeColor = Color.White;
            lblQuestionText.Location = new Point(55, 20);
            lblQuestionText.Margin = new Padding(5);
            lblQuestionText.Name = "lblQuestionText";
            lblQuestionText.Size = new Size(560, 52);
            lblQuestionText.TabIndex = 11;
            lblQuestionText.Text = "Two lines of question text. The questions wont be much longer than this hopefully";
            lblQuestionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pb
            // 
            pb.Anchor = AnchorStyles.None;
            pb.Image = Resources.Images.Images.Flasks_close_up;
            pb.ImagePortion = new Rectangle(0, 0, 2352, 1440);
            pb.Location = new Point(144, 93);
            pb.Margin = new Padding(18, 15, 18, 15);
            pb.Name = "pb";
            pb.Size = new Size(420, 240);
            pb.TabIndex = 13;
            pb.Text = "picturePanel1";
            // 
            // lblIsCorrect
            // 
            lblIsCorrect.Anchor = AnchorStyles.None;
            lblIsCorrect.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblIsCorrect.ForeColor = Color.White;
            lblIsCorrect.Location = new Point(55, 158);
            lblIsCorrect.Margin = new Padding(5);
            lblIsCorrect.Name = "lblIsCorrect";
            lblIsCorrect.Size = new Size(560, 67);
            lblIsCorrect.TabIndex = 11;
            lblIsCorrect.Text = "Incorrect. Better luck next time. The correct answer was: this very very long sentence to stress test the textbox size\r\n";
            lblIsCorrect.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlQuestionAnswer
            // 
            pnlQuestionAnswer.Controls.Add(pnlAnswer);
            pnlQuestionAnswer.Controls.Add(lblIsCorrect);
            pnlQuestionAnswer.Controls.Add(lblQuestionText);
            pnlQuestionAnswer.Location = new Point(14, 353);
            pnlQuestionAnswer.Margin = new Padding(5);
            pnlQuestionAnswer.Name = "pnlQuestionAnswer";
            pnlQuestionAnswer.Size = new Size(672, 233);
            pnlQuestionAnswer.TabIndex = 14;
            // 
            // formTypingQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(700, 600);
            Controls.Add(pnlQuestionAnswer);
            Controls.Add(pb);
            Controls.Add(lblQuestionTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formTypingQuestion";
            Text = "TextQuestion";
            pnlAnswer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbIsCorrect).EndInit();
            pnlQuestionAnswer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Custom_Controls.CustomTextbox tbAnswer;
        private Label lblAnswerTitle;
        private Panel pnlAnswer;
        private PictureBox pbIsCorrect;
        private Label lblQuestionTitle;
        private Label lblQuestionText;
        private Custom_Controls.PicturePanel pb;
        private Custom_Controls.CustomButton btnSubmitNext;
        private Label lblIsCorrect;
        private Panel pnlQuestionAnswer;
    }
}