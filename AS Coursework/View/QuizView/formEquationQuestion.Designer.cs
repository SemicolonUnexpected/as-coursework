﻿namespace AS_Coursework.View.QuizView {
    partial class formEquationQuestion {
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
            lblIsCorrect = new Label();
            pnlAnswer = new Panel();
            btnSubmitNext = new Custom_Controls.CustomButton();
            pbIsCorrect = new PictureBox();
            lblAnswerTitle = new Label();
            tbAnswer = new Custom_Controls.CustomTextbox();
            lblQuestionText = new Label();
            chemistryCharachterKeypad1 = new Custom_Controls.ChemistryCharacterKeypad();
            pnlAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIsCorrect).BeginInit();
            SuspendLayout();
            // 
            // lblQuestionTitle
            // 
            lblQuestionTitle.Anchor = AnchorStyles.None;
            lblQuestionTitle.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionTitle.ForeColor = Color.White;
            lblQuestionTitle.Location = new Point(0, 20);
            lblQuestionTitle.Margin = new Padding(0);
            lblQuestionTitle.Name = "lblQuestionTitle";
            lblQuestionTitle.Size = new Size(684, 33);
            lblQuestionTitle.TabIndex = 11;
            lblQuestionTitle.Text = "Question Title";
            lblQuestionTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIsCorrect
            // 
            lblIsCorrect.Anchor = AnchorStyles.None;
            lblIsCorrect.AutoSize = true;
            lblIsCorrect.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblIsCorrect.ForeColor = Color.White;
            lblIsCorrect.Location = new Point(56, 471);
            lblIsCorrect.Margin = new Padding(18, 15, 18, 15);
            lblIsCorrect.MaximumSize = new Size(560, 41);
            lblIsCorrect.MinimumSize = new Size(560, 41);
            lblIsCorrect.Name = "lblIsCorrect";
            lblIsCorrect.Size = new Size(560, 41);
            lblIsCorrect.TabIndex = 12;
            lblIsCorrect.Text = "Incorrect. Better luck next time. The correct answer was: this very very long sentence to stress test the textbox size\r\n";
            lblIsCorrect.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlAnswer
            // 
            pnlAnswer.Anchor = AnchorStyles.None;
            pnlAnswer.Controls.Add(btnSubmitNext);
            pnlAnswer.Controls.Add(pbIsCorrect);
            pnlAnswer.Controls.Add(lblAnswerTitle);
            pnlAnswer.Controls.Add(tbAnswer);
            pnlAnswer.Location = new Point(61, 133);
            pnlAnswer.Margin = new Padding(18, 15, 18, 15);
            pnlAnswer.Name = "pnlAnswer";
            pnlAnswer.Size = new Size(560, 50);
            pnlAnswer.TabIndex = 14;
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
            btnSubmitNext.Location = new Point(474, 10);
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
            pbIsCorrect.Location = new Point(439, 10);
            pbIsCorrect.Margin = new Padding(5);
            pbIsCorrect.Name = "pbIsCorrect";
            pbIsCorrect.Size = new Size(30, 30);
            pbIsCorrect.SizeMode = PictureBoxSizeMode.StretchImage;
            pbIsCorrect.TabIndex = 12;
            pbIsCorrect.TabStop = false;
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
            lblAnswerTitle.Size = new Size(56, 38);
            lblAnswerTitle.TabIndex = 11;
            lblAnswerTitle.Text = "Ans:";
            lblAnswerTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            tbAnswer.Location = new Point(70, 8);
            tbAnswer.Margin = new Padding(0);
            tbAnswer.Name = "tbAnswer";
            tbAnswer.Padding = new Padding(5, 4, 5, 4);
            tbAnswer.PlaceholderText = "";
            tbAnswer.PlaceholderTextColor = Color.White;
            tbAnswer.ShortcutEnabled = true;
            tbAnswer.Size = new Size(364, 32);
            tbAnswer.TabIndex = 0;
            tbAnswer.UsePasswordChar = false;
            tbAnswer.KeyDown += tbAnswer_KeyDown;
            // 
            // lblQuestionText
            // 
            lblQuestionText.Anchor = AnchorStyles.None;
            lblQuestionText.AutoSize = true;
            lblQuestionText.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionText.ForeColor = Color.White;
            lblQuestionText.Location = new Point(56, 65);
            lblQuestionText.Margin = new Padding(18, 15, 18, 12);
            lblQuestionText.MaximumSize = new Size(560, 41);
            lblQuestionText.MinimumSize = new Size(560, 41);
            lblQuestionText.Name = "lblQuestionText";
            lblQuestionText.Size = new Size(560, 41);
            lblQuestionText.TabIndex = 13;
            lblQuestionText.Text = "Two lines of question text. The questions wont be much longer than this hopefully";
            lblQuestionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chemistryCharachterKeypad1
            // 
            chemistryCharachterKeypad1.Anchor = AnchorStyles.None;
            chemistryCharachterKeypad1.BackColor = Color.FromArgb(20, 20, 50);
            chemistryCharachterKeypad1.ForeColor = Color.White;
            chemistryCharachterKeypad1.Location = new Point(148, 192);
            chemistryCharachterKeypad1.Margin = new Padding(4, 3, 4, 3);
            chemistryCharachterKeypad1.Name = "chemistryCharachterKeypad1";
            chemistryCharachterKeypad1.Padding = new Padding(4, 3, 4, 3);
            chemistryCharachterKeypad1.Size = new Size(364, 261);
            chemistryCharachterKeypad1.TabIndex = 15;
            chemistryCharachterKeypad1.CharacterClicked += chemistryCharachterKeypad1_CharacterClicked;
            // 
            // formEquationQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(682, 540);
            Controls.Add(chemistryCharachterKeypad1);
            Controls.Add(pnlAnswer);
            Controls.Add(lblQuestionText);
            Controls.Add(lblIsCorrect);
            Controls.Add(lblQuestionTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formEquationQuestion";
            Text = "TextQuestion";
            pnlAnswer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbIsCorrect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestionTitle;
        private Label lblIsCorrect;
        private Panel pnlAnswer;
        private Custom_Controls.CustomButton btnSubmitNext;
        private PictureBox pbIsCorrect;
        private Label lblAnswerTitle;
        private Custom_Controls.CustomTextbox tbAnswer;
        private Label lblQuestionText;
        private Custom_Controls.ChemistryCharacterKeypad chemistryCharachterKeypad1;
    }
}
