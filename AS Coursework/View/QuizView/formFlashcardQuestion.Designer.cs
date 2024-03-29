﻿namespace AS_Coursework.View.QuizView {
    partial class formFlashcardQuestion {
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
            btnNext = new Custom_Controls.CustomButton();
            pnlFlashcard = new Custom_Controls.CustomRectangle();
            pnl = new Panel();
            lblText = new Label();
            btnKnown = new Custom_Controls.CustomButton();
            pnlButtons = new Panel();
            btnSwitchSides = new Custom_Controls.CustomButton();
            pnlFlashcard.SuspendLayout();
            pnl.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestionTitle
            // 
            lblQuestionTitle.Anchor = AnchorStyles.None;
            lblQuestionTitle.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionTitle.ForeColor = Color.White;
            lblQuestionTitle.Location = new Point(0, 50);
            lblQuestionTitle.Margin = new Padding(0);
            lblQuestionTitle.Name = "lblQuestionTitle";
            lblQuestionTitle.Size = new Size(700, 33);
            lblQuestionTitle.TabIndex = 11;
            lblQuestionTitle.Text = "Question Title";
            lblQuestionTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
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
            btnNext.Location = new Point(210, 0);
            btnNext.Margin = new Padding(7, 6, 7, 6);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(175, 45);
            btnNext.TabIndex = 18;
            btnNext.Text = "I don't know this";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // pnlFlashcard
            // 
            pnlFlashcard.Anchor = AnchorStyles.None;
            pnlFlashcard.BackColor = Color.FromArgb(30, 30, 70);
            pnlFlashcard.BorderColor = Color.White;
            pnlFlashcard.BorderWidth = 0;
            pnlFlashcard.Controls.Add(pnl);
            pnlFlashcard.CornerRadius = 20;
            pnlFlashcard.Location = new Point(64, 100);
            pnlFlashcard.Margin = new Padding(14, 12, 14, 12);
            pnlFlashcard.Name = "pnlFlashcard";
            pnlFlashcard.Size = new Size(560, 330);
            pnlFlashcard.TabIndex = 19;
            pnlFlashcard.Click += btnSwitchSides_Click;
            // 
            // pnl
            // 
            pnl.Controls.Add(lblText);
            pnl.Location = new Point(10, 10);
            pnl.Margin = new Padding(10);
            pnl.Name = "pnl";
            pnl.Size = new Size(540, 310);
            pnl.TabIndex = 1;
            pnl.Click += btnSwitchSides_Click;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblText.ForeColor = Color.White;
            lblText.Location = new Point(0, 0);
            lblText.Margin = new Padding(0);
            lblText.MaximumSize = new Size(540, 0);
            lblText.Name = "lblText";
            lblText.Padding = new Padding(0, 0, 10, 0);
            lblText.Size = new Size(68, 23);
            lblText.TabIndex = 0;
            lblText.Text = "label1";
            lblText.Click += btnSwitchSides_Click;
            // 
            // btnKnown
            // 
            btnKnown.Anchor = AnchorStyles.None;
            btnKnown.BackColor = Color.FromArgb(0, 150, 255);
            btnKnown.BorderColor = Color.White;
            btnKnown.BorderWidth = 2;
            btnKnown.CornerRadius = 10;
            btnKnown.FlatAppearance.BorderSize = 0;
            btnKnown.FlatStyle = FlatStyle.Popup;
            btnKnown.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnKnown.ForeColor = Color.BlanchedAlmond;
            btnKnown.Image = null;
            btnKnown.ImageSize = new Size(150, 40);
            btnKnown.Location = new Point(0, 0);
            btnKnown.Margin = new Padding(7, 6, 7, 6);
            btnKnown.Name = "btnKnown";
            btnKnown.Size = new Size(175, 45);
            btnKnown.TabIndex = 18;
            btnKnown.Text = "I know this";
            btnKnown.UseVisualStyleBackColor = false;
            btnKnown.Click += btnKnown_Click;
            // 
            // pnlButtons
            // 
            pnlButtons.Anchor = AnchorStyles.None;
            pnlButtons.Controls.Add(btnNext);
            pnlButtons.Controls.Add(btnKnown);
            pnlButtons.Location = new Point(155, 505);
            pnlButtons.Margin = new Padding(18, 15, 18, 15);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(385, 45);
            pnlButtons.TabIndex = 20;
            // 
            // btnSwitchSides
            // 
            btnSwitchSides.Anchor = AnchorStyles.None;
            btnSwitchSides.BackColor = Color.FromArgb(20, 20, 50);
            btnSwitchSides.BorderColor = Color.WhiteSmoke;
            btnSwitchSides.BorderWidth = 0;
            btnSwitchSides.CornerRadius = 20;
            btnSwitchSides.FlatAppearance.BorderSize = 0;
            btnSwitchSides.FlatStyle = FlatStyle.Flat;
            btnSwitchSides.ForeColor = Color.Black;
            btnSwitchSides.Image = Resources.Icons.Icons.swap;
            btnSwitchSides.ImageSize = new Size(30, 30);
            btnSwitchSides.Location = new Point(330, 447);
            btnSwitchSides.Margin = new Padding(5);
            btnSwitchSides.Name = "btnSwitchSides";
            btnSwitchSides.Size = new Size(40, 40);
            btnSwitchSides.TabIndex = 21;
            btnSwitchSides.UseVisualStyleBackColor = false;
            btnSwitchSides.Click += btnSwitchSides_Click;
            // 
            // formFlashcardQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(700, 600);
            Controls.Add(btnSwitchSides);
            Controls.Add(pnlButtons);
            Controls.Add(pnlFlashcard);
            Controls.Add(lblQuestionTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formFlashcardQuestion";
            Text = "TextQuestion";
            pnlFlashcard.ResumeLayout(false);
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuestionTitle;
        private Custom_Controls.CustomButton btnNext;
        private Custom_Controls.CustomRectangle pnlFlashcard;
        private Custom_Controls.CustomButton btnKnown;
        private Panel pnlButtons;
        private Custom_Controls.CustomButton btnSwitchSides;
        private Panel pnl;
        private Label lblText;
    }
}
