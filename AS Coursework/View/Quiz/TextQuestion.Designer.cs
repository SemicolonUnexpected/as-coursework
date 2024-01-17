namespace AS_Coursework.View.Quiz {
    partial class TextQuestion {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextQuestion));
            customTextbox1 = new Custom_Controls.CustomTextbox();
            lblAnswerTitle = new Label();
            pnlAnswer = new Panel();
            pbSpecialCharacters = new PictureBox();
            lblQuestionTitle = new Label();
            lblQuestionText = new Label();
            pb = new Custom_Controls.PicturePanel();
            btnSubmitNext = new Custom_Controls.CustomButton();
            lblCorrectness = new Label();
            pnlAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpecialCharacters).BeginInit();
            SuspendLayout();
            // 
            // customTextbox1
            // 
            customTextbox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customTextbox1.BackColor = Color.FromArgb(20, 20, 50);
            customTextbox1.BorderColor = Color.White;
            customTextbox1.BorderFocusColor = Color.White;
            customTextbox1.BorderSize = 2;
            customTextbox1.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            customTextbox1.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            customTextbox1.ForeColor = Color.White;
            customTextbox1.IsMultiline = false;
            customTextbox1.Location = new Point(100, 9);
            customTextbox1.Margin = new Padding(10);
            customTextbox1.Name = "customTextbox1";
            customTextbox1.Padding = new Padding(7);
            customTextbox1.PlaceholderText = "";
            customTextbox1.PlaceholderTextColor = Color.White;
            customTextbox1.ShortcutEnabled = true;
            customTextbox1.Size = new Size(490, 49);
            customTextbox1.TabIndex = 0;
            customTextbox1.UsePasswordChar = false;
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
            pnlAnswer.Controls.Add(pbSpecialCharacters);
            pnlAnswer.Controls.Add(lblAnswerTitle);
            pnlAnswer.Controls.Add(customTextbox1);
            pnlAnswer.Location = new Point(87, 657);
            pnlAnswer.Margin = new Padding(25);
            pnlAnswer.Name = "pnlAnswer";
            pnlAnswer.Size = new Size(800, 69);
            pnlAnswer.TabIndex = 12;
            // 
            // pbSpecialCharacters
            // 
            pbSpecialCharacters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbSpecialCharacters.Image = (Image)resources.GetObject("pbSpecialCharacters.Image");
            pbSpecialCharacters.Location = new Point(610, 17);
            pbSpecialCharacters.Margin = new Padding(10);
            pbSpecialCharacters.Name = "pbSpecialCharacters";
            pbSpecialCharacters.Size = new Size(35, 35);
            pbSpecialCharacters.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSpecialCharacters.TabIndex = 12;
            pbSpecialCharacters.TabStop = false;
            // 
            // lblQuestionTitle
            // 
            lblQuestionTitle.Anchor = AnchorStyles.None;
            lblQuestionTitle.AutoSize = true;
            lblQuestionTitle.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionTitle.ForeColor = Color.White;
            lblQuestionTitle.Location = new Point(362, 34);
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
            lblQuestionText.Location = new Point(87, 532);
            lblQuestionText.Margin = new Padding(25, 25, 25, 0);
            lblQuestionText.MaximumSize = new Size(800, 100);
            lblQuestionText.MinimumSize = new Size(800, 100);
            lblQuestionText.Name = "lblQuestionText";
            lblQuestionText.Size = new Size(800, 100);
            lblQuestionText.TabIndex = 11;
            lblQuestionText.Text = "Question text\r\nAnd another test line\r\nThird line\r\n\r\n";
            lblQuestionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pb
            // 
            pb.Anchor = AnchorStyles.None;
            pb.Image = Resources.Images.Flasks_close_up;
            pb.ImagePortion = new Rectangle(0, 0, 2352, 1440);
            pb.Location = new Point(194, 107);
            pb.Margin = new Padding(25, 0, 25, 0);
            pb.Name = "pb";
            pb.Size = new Size(600, 400);
            pb.TabIndex = 13;
            pb.Text = "picturePanel1";
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
            // lblCorrectness
            // 
            lblCorrectness.Anchor = AnchorStyles.Left;
            lblCorrectness.AutoSize = true;
            lblCorrectness.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorrectness.ForeColor = Color.White;
            lblCorrectness.Location = new Point(429, 741);
            lblCorrectness.Margin = new Padding(25, 0, 25, 0);
            lblCorrectness.MaximumSize = new Size(450, 0);
            lblCorrectness.Name = "lblCorrectness";
            lblCorrectness.Size = new Size(109, 34);
            lblCorrectness.TabIndex = 11;
            lblCorrectness.Text = "Correct";
            lblCorrectness.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextQuestion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(975, 800);
            Controls.Add(pb);
            Controls.Add(pnlAnswer);
            Controls.Add(lblCorrectness);
            Controls.Add(lblQuestionText);
            Controls.Add(lblQuestionTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TextQuestion";
            Text = "TextQuestion";
            pnlAnswer.ResumeLayout(false);
            pnlAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpecialCharacters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom_Controls.CustomTextbox customTextbox1;
        private Label lblAnswerTitle;
        private Panel pnlAnswer;
        private PictureBox pbSpecialCharacters;
        private Label lblQuestionTitle;
        private Label lblQuestionText;
        private Custom_Controls.PicturePanel pb;
        private Custom_Controls.CustomButton btnSubmitNext;
        private Label lblCorrectness;
    }
}