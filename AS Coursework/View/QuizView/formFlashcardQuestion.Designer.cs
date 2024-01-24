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
            pnlFlashcard = new Custom_Controls.CustomRectangle();
            lblFlashcardText = new Label();
            btnSwitchSides = new Custom_Controls.CustomButton();
            btnKnown = new Custom_Controls.CustomButton();
            pnlButtons = new Panel();
            pnlFlashcard.SuspendLayout();
            pnlButtons.SuspendLayout();
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
            btnNext.Anchor = AnchorStyles.None;
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
            btnNext.Location = new Point(300, 0);
            btnNext.Margin = new Padding(10);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(250, 75);
            btnNext.TabIndex = 18;
            btnNext.Text = "I don't know this";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // pnlFlashcard
            // 
            pnlFlashcard.Anchor = AnchorStyles.None;
            pnlFlashcard.BackColor = Color.FromArgb(30, 30, 70);
            pnlFlashcard.BorderColor = Color.White;
            pnlFlashcard.BorderWidth = 0;
            pnlFlashcard.Controls.Add(lblFlashcardText);
            pnlFlashcard.CornerRadius = 20;
            pnlFlashcard.Location = new Point(79, 127);
            pnlFlashcard.Margin = new Padding(20);
            pnlFlashcard.Name = "pnlFlashcard";
            pnlFlashcard.Size = new Size(800, 550);
            pnlFlashcard.TabIndex = 19;
            // 
            // lblFlashcardText
            // 
            lblFlashcardText.AutoSize = true;
            lblFlashcardText.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblFlashcardText.ForeColor = Color.White;
            lblFlashcardText.Location = new Point(20, 20);
            lblFlashcardText.Margin = new Padding(25, 25, 25, 20);
            lblFlashcardText.MaximumSize = new Size(760, 510);
            lblFlashcardText.MinimumSize = new Size(760, 510);
            lblFlashcardText.Name = "lblFlashcardText";
            lblFlashcardText.Size = new Size(760, 510);
            lblFlashcardText.TabIndex = 12;
            lblFlashcardText.Text = "Flashcard side one";
            lblFlashcardText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSwitchSides
            // 
            btnSwitchSides.Anchor = AnchorStyles.None;
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
            btnSwitchSides.Location = new Point(448, 696);
            btnSwitchSides.Margin = new Padding(10);
            btnSwitchSides.Name = "btnSwitchSides";
            btnSwitchSides.Size = new Size(75, 75);
            btnSwitchSides.TabIndex = 18;
            btnSwitchSides.UseVisualStyleBackColor = false;
            btnSwitchSides.Click += btnSwitchSides_Click;
            // 
            // btnKnown
            // 
            btnKnown.Anchor = AnchorStyles.None;
            btnKnown.BackColor = Color.FromArgb(0, 150, 255);
            btnKnown.BorderColor = Color.White;
            btnKnown.BorderWidth = 2;
            btnKnown.CornerRadius = 20;
            btnKnown.FlatAppearance.BorderSize = 0;
            btnKnown.FlatStyle = FlatStyle.Popup;
            btnKnown.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnKnown.ForeColor = Color.BlanchedAlmond;
            btnKnown.Image = null;
            btnKnown.ImageSize = new Size(150, 40);
            btnKnown.Location = new Point(0, 0);
            btnKnown.Margin = new Padding(10);
            btnKnown.Name = "btnKnown";
            btnKnown.Size = new Size(250, 75);
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
            pnlButtons.Location = new Point(208, 791);
            pnlButtons.Margin = new Padding(25);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(550, 75);
            pnlButtons.TabIndex = 20;
            // 
            // formFlashcardQuestion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(975, 900);
            Controls.Add(pnlButtons);
            Controls.Add(pnlFlashcard);
            Controls.Add(btnSwitchSides);
            Controls.Add(lblQuestionTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formFlashcardQuestion";
            Text = "TextQuestion";
            pnlFlashcard.ResumeLayout(false);
            pnlFlashcard.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestionTitle;
        private Custom_Controls.CustomButton btnNext;
        private Custom_Controls.CustomRectangle pnlFlashcard;
        private Label lblFlashcardText;
        private Custom_Controls.CustomButton btnSwitchSides;
        private Custom_Controls.CustomButton btnKnown;
        private Panel pnlButtons;
    }
}
