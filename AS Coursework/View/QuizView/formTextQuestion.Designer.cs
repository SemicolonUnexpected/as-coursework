﻿namespace AS_Coursework.View.QuizView {
    partial class formTextQuestion {
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
            pnlAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIsCorrect).BeginInit();
            SuspendLayout();
            // 
            // tbAnswer
            // 
            tbAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbAnswer.BackColor = Color.FromArgb(20, 20, 50);
            tbAnswer.BorderColor = Color.White;
            tbAnswer.BorderFocusColor = Color.White;
            tbAnswer.BorderSize = 2;
            tbAnswer.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbAnswer.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbAnswer.ForeColor = Color.White;
            tbAnswer.IsMultiline = false;
            tbAnswer.Location = new Point(100, 9);
            tbAnswer.Margin = new Padding(10);
            tbAnswer.Name = "tbAnswer";
            tbAnswer.Padding = new Padding(7);
            tbAnswer.PlaceholderText = "";
            tbAnswer.PlaceholderTextColor = Color.White;
            tbAnswer.ShortcutEnabled = true;
            tbAnswer.Size = new Size(490, 49);
            tbAnswer.TabIndex = 0;
            tbAnswer.UsePasswordChar = false;
            // 
            // lblAnswerTitle
            // 
            lblAnswerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAnswerTitle.AutoSize = true;
            lblAnswerTitle.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswerTitle.ForeColor = Color.White;
            lblAnswerTitle.Location = new Point(10, 17);
            lblAnswerTitle.Margin = new Padding(10);
            lblAnswerTitle.MaximumSize = new Size(450, 0);
            lblAnswerTitle.Name = "lblAnswerTitle";
            lblAnswerTitle.Size = new Size(70, 34);
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
            pnlAnswer.Location = new Point(68, 695);
            pnlAnswer.Margin = new Padding(25);
            pnlAnswer.Name = "pnlAnswer";
            pnlAnswer.Size = new Size(800, 69);
            pnlAnswer.TabIndex = 12;
            // 
            // btnSubmitNext
            // 
            btnSubmitNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSubmitNext.BackColor = Color.FromArgb(0, 150, 255);
            btnSubmitNext.BorderColor = Color.White;
            btnSubmitNext.BorderWidth = 2;
            btnSubmitNext.CornerRadius = 20;
            btnSubmitNext.FlatAppearance.BorderSize = 0;
            btnSubmitNext.FlatStyle = FlatStyle.Popup;
            btnSubmitNext.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmitNext.ForeColor = Color.BlanchedAlmond;
            btnSubmitNext.Image = null;
            btnSubmitNext.ImageSize = new Size(150, 40);
            btnSubmitNext.Location = new Point(665, 8);
            btnSubmitNext.Margin = new Padding(10);
            btnSubmitNext.Name = "btnSubmitNext";
            btnSubmitNext.Size = new Size(116, 50);
            btnSubmitNext.TabIndex = 14;
            btnSubmitNext.Text = "Submit";
            btnSubmitNext.UseVisualStyleBackColor = false;
            btnSubmitNext.Click += btnSubmitNext_Click;
            // 
            // pbIsCorrect
            // 
            pbIsCorrect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbIsCorrect.Location = new Point(610, 17);
            pbIsCorrect.Margin = new Padding(10);
            pbIsCorrect.Name = "pbIsCorrect";
            pbIsCorrect.Size = new Size(35, 35);
            pbIsCorrect.SizeMode = PictureBoxSizeMode.StretchImage;
            pbIsCorrect.TabIndex = 12;
            pbIsCorrect.TabStop = false;
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
            // lblQuestionText
            // 
            lblQuestionText.Anchor = AnchorStyles.None;
            lblQuestionText.AutoSize = true;
            lblQuestionText.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionText.ForeColor = Color.White;
            lblQuestionText.Location = new Point(68, 582);
            lblQuestionText.Margin = new Padding(25, 25, 25, 20);
            lblQuestionText.MaximumSize = new Size(800, 68);
            lblQuestionText.MinimumSize = new Size(800, 68);
            lblQuestionText.Name = "lblQuestionText";
            lblQuestionText.Size = new Size(800, 68);
            lblQuestionText.TabIndex = 11;
            lblQuestionText.Text = "Two lines of question text. The questions wont be much longer than this hopefully";
            lblQuestionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pb
            // 
            pb.Anchor = AnchorStyles.None;
            pb.Image = Resources.Images.Flasks_close_up;
            pb.ImagePortion = new Rectangle(0, 0, 2352, 1440);
            pb.Location = new Point(197, 132);
            pb.Margin = new Padding(25);
            pb.Name = "pb";
            pb.Size = new Size(600, 400);
            pb.TabIndex = 13;
            pb.Text = "picturePanel1";
            // 
            // lblIsCorrect
            // 
            lblIsCorrect.Anchor = AnchorStyles.None;
            lblIsCorrect.AutoSize = true;
            lblIsCorrect.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblIsCorrect.ForeColor = Color.White;
            lblIsCorrect.Location = new Point(68, 798);
            lblIsCorrect.Margin = new Padding(25);
            lblIsCorrect.MaximumSize = new Size(800, 68);
            lblIsCorrect.MinimumSize = new Size(800, 68);
            lblIsCorrect.Name = "lblIsCorrect";
            lblIsCorrect.Size = new Size(800, 68);
            lblIsCorrect.TabIndex = 11;
            lblIsCorrect.Text = "Incorrect. Better luck next time. The correct answer was: this very very long sentence to stress test the textbox size\r\n";
            lblIsCorrect.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextQuestion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(975, 900);
            Controls.Add(pb);
            Controls.Add(pnlAnswer);
            Controls.Add(lblIsCorrect);
            Controls.Add(lblQuestionText);
            Controls.Add(lblQuestionTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TextQuestion";
            Text = "TextQuestion";
            pnlAnswer.ResumeLayout(false);
            pnlAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIsCorrect).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}