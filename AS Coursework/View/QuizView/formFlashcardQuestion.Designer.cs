namespace AS_Coursework.View.QuizView {
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
            pnlRank = new Custom_Controls.CustomRectangle();
            lblFlashcardText = new Label();
            btnSwitchSides = new Custom_Controls.CustomButton();
            pnlRank.SuspendLayout();
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
            btnNext.TabIndex = 18;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // pnlRank
            // 
            pnlRank.Anchor = AnchorStyles.None;
            pnlRank.BackColor = Color.FromArgb(30, 30, 70);
            pnlRank.BorderColor = Color.White;
            pnlRank.BorderWidth = 0;
            pnlRank.Controls.Add(lblFlashcardText);
            pnlRank.CornerRadius = 20;
            pnlRank.Location = new Point(79, 127);
            pnlRank.Margin = new Padding(20);
            pnlRank.Name = "pnlRank";
            pnlRank.Size = new Size(800, 600);
            pnlRank.TabIndex = 19;
            pnlRank.Text = "customRectangle1";
            // 
            // lblFlashcardText
            // 
            lblFlashcardText.AutoSize = true;
            lblFlashcardText.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblFlashcardText.ForeColor = Color.White;
            lblFlashcardText.Location = new Point(20, 20);
            lblFlashcardText.Margin = new Padding(25, 25, 25, 20);
            lblFlashcardText.MaximumSize = new Size(760, 560);
            lblFlashcardText.MinimumSize = new Size(760, 560);
            lblFlashcardText.Name = "lblFlashcardText";
            lblFlashcardText.Size = new Size(760, 560);
            lblFlashcardText.TabIndex = 12;
            lblFlashcardText.Text = "Flashcard side one";
            lblFlashcardText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSwitchSides
            // 
            btnSwitchSides.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSwitchSides.BackColor = Color.FromArgb(20, 20, 50);
            btnSwitchSides.BorderColor = Color.FromArgb(20, 20, 50);
            btnSwitchSides.BorderWidth = 0;
            btnSwitchSides.CornerRadius = 37;
            btnSwitchSides.FlatAppearance.BorderSize = 0;
            btnSwitchSides.FlatStyle = FlatStyle.Popup;
            btnSwitchSides.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSwitchSides.ForeColor = Color.BlanchedAlmond;
            btnSwitchSides.Image = Resources.Icons.swap;
            btnSwitchSides.ImageSize = new Size(60, 60);
            btnSwitchSides.Location = new Point(416, 746);
            btnSwitchSides.Margin = new Padding(10);
            btnSwitchSides.Name = "btnSwitchSides";
            btnSwitchSides.Size = new Size(75, 75);
            btnSwitchSides.TabIndex = 18;
            btnSwitchSides.UseVisualStyleBackColor = false;
            btnSwitchSides.Click += btnSwitchSides_Click;
            // 
            // formFlashcardQuestion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(975, 900);
            Controls.Add(pnlRank);
            Controls.Add(btnSwitchSides);
            Controls.Add(btnNext);
            Controls.Add(lblQuestionTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formFlashcardQuestion";
            Text = "TextQuestion";
            pnlRank.ResumeLayout(false);
            pnlRank.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestionTitle;
        private Custom_Controls.CustomButton btnNext;
        private Custom_Controls.CustomRectangle pnlRank;
        private Label lblFlashcardText;
        private Custom_Controls.CustomButton btnSwitchSides;
    }
}
