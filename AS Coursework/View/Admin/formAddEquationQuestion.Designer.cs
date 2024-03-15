namespace AS_Coursework.View.Admin {
    partial class formAddEquationQuestion {
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
            lblAdminInfo = new Label();
            tbQuestionTitle = new Custom_Controls.CustomTextbox();
            btnAddQuesiton = new Custom_Controls.CustomButton();
            btnCancel = new Custom_Controls.CustomButton();
            tbAnswer = new Custom_Controls.CustomTextbox();
            lblError = new Label();
            tbQuestion = new Custom_Controls.CustomTextbox();
            chemistryCharacterKeypad1 = new Custom_Controls.ChemistryCharacterKeypad();
            SuspendLayout();
            // 
            // lblAdminInfo
            // 
            lblAdminInfo.Anchor = AnchorStyles.None;
            lblAdminInfo.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdminInfo.ForeColor = Color.White;
            lblAdminInfo.ImageAlign = ContentAlignment.TopCenter;
            lblAdminInfo.Location = new Point(11, 9);
            lblAdminInfo.Margin = new Padding(2, 0, 2, 0);
            lblAdminInfo.Name = "lblAdminInfo";
            lblAdminInfo.Size = new Size(628, 39);
            lblAdminInfo.TabIndex = 0;
            lblAdminInfo.Text = "To create an equation question, fill the fields below.";
            lblAdminInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbQuestionTitle
            // 
            tbQuestionTitle.Anchor = AnchorStyles.None;
            tbQuestionTitle.BackColor = Color.FromArgb(20, 20, 50);
            tbQuestionTitle.BorderColor = Color.White;
            tbQuestionTitle.BorderFocusColor = Color.White;
            tbQuestionTitle.BorderSize = 2;
            tbQuestionTitle.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbQuestionTitle.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbQuestionTitle.ForeColor = Color.White;
            tbQuestionTitle.IsMultiline = false;
            tbQuestionTitle.Location = new Point(140, 58);
            tbQuestionTitle.Margin = new Padding(10);
            tbQuestionTitle.Name = "tbQuestionTitle";
            tbQuestionTitle.Padding = new Padding(6, 5, 6, 5);
            tbQuestionTitle.PlaceholderText = "Question title";
            tbQuestionTitle.PlaceholderTextColor = Color.White;
            tbQuestionTitle.ShortcutEnabled = true;
            tbQuestionTitle.Size = new Size(367, 34);
            tbQuestionTitle.TabIndex = 0;
            tbQuestionTitle.UsePasswordChar = false;
            // 
            // btnAddQuesiton
            // 
            btnAddQuesiton.Anchor = AnchorStyles.None;
            btnAddQuesiton.BackColor = Color.FromArgb(0, 150, 255);
            btnAddQuesiton.BorderColor = Color.White;
            btnAddQuesiton.BorderWidth = 2;
            btnAddQuesiton.CornerRadius = 15;
            btnAddQuesiton.FlatAppearance.BorderSize = 0;
            btnAddQuesiton.FlatStyle = FlatStyle.Flat;
            btnAddQuesiton.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddQuesiton.ForeColor = Color.White;
            btnAddQuesiton.Image = null;
            btnAddQuesiton.ImageSize = new Size(150, 40);
            btnAddQuesiton.Location = new Point(492, 540);
            btnAddQuesiton.Margin = new Padding(5);
            btnAddQuesiton.Name = "btnAddQuesiton";
            btnAddQuesiton.Size = new Size(144, 40);
            btnAddQuesiton.TabIndex = 4;
            btnAddQuesiton.Text = "Add question";
            btnAddQuesiton.UseVisualStyleBackColor = false;
            btnAddQuesiton.Click += btnAddQuesiton_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.FromArgb(0, 150, 255);
            btnCancel.BorderColor = Color.White;
            btnCancel.BorderWidth = 2;
            btnCancel.CornerRadius = 15;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = null;
            btnCancel.ImageSize = new Size(150, 40);
            btnCancel.Location = new Point(338, 540);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 40);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            tbAnswer.Location = new Point(140, 109);
            tbAnswer.Margin = new Padding(10);
            tbAnswer.Name = "tbAnswer";
            tbAnswer.Padding = new Padding(6, 5, 6, 5);
            tbAnswer.PlaceholderText = "Correct answer";
            tbAnswer.PlaceholderTextColor = Color.White;
            tbAnswer.ShortcutEnabled = true;
            tbAnswer.Size = new Size(367, 34);
            tbAnswer.TabIndex = 1;
            tbAnswer.UsePasswordChar = false;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.AutoEllipsis = true;
            lblError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(11, 512);
            lblError.Margin = new Padding(2, 0, 2, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(628, 20);
            lblError.TabIndex = 17;
            lblError.Text = "Error";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbQuestion
            // 
            tbQuestion.Anchor = AnchorStyles.None;
            tbQuestion.BackColor = Color.FromArgb(20, 20, 50);
            tbQuestion.BorderColor = Color.White;
            tbQuestion.BorderFocusColor = Color.White;
            tbQuestion.BorderSize = 1;
            tbQuestion.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Rectangle;
            tbQuestion.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbQuestion.ForeColor = Color.White;
            tbQuestion.IsMultiline = true;
            tbQuestion.Location = new Point(140, 422);
            tbQuestion.Margin = new Padding(25);
            tbQuestion.Name = "tbQuestion";
            tbQuestion.Padding = new Padding(7);
            tbQuestion.PlaceholderText = "Question";
            tbQuestion.PlaceholderTextColor = Color.White;
            tbQuestion.ShortcutEnabled = true;
            tbQuestion.Size = new Size(367, 84);
            tbQuestion.TabIndex = 2;
            tbQuestion.UsePasswordChar = false;
            // 
            // chemistryCharacterKeypad1
            // 
            chemistryCharacterKeypad1.Anchor = AnchorStyles.None;
            chemistryCharacterKeypad1.BackColor = Color.FromArgb(20, 20, 50);
            chemistryCharacterKeypad1.ForeColor = Color.White;
            chemistryCharacterKeypad1.Location = new Point(140, 152);
            chemistryCharacterKeypad1.Margin = new Padding(4, 3, 4, 3);
            chemistryCharacterKeypad1.Name = "chemistryCharacterKeypad1";
            chemistryCharacterKeypad1.Padding = new Padding(4, 3, 4, 3);
            chemistryCharacterKeypad1.Size = new Size(364, 261);
            chemistryCharacterKeypad1.TabIndex = 19;
            chemistryCharacterKeypad1.CharacterClicked += chemistryCharacterKeypad1_CharacterClicked;
            // 
            // formAddEquationQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(650, 600);
            Controls.Add(chemistryCharacterKeypad1);
            Controls.Add(tbQuestion);
            Controls.Add(lblError);
            Controls.Add(btnCancel);
            Controls.Add(btnAddQuesiton);
            Controls.Add(tbAnswer);
            Controls.Add(tbQuestionTitle);
            Controls.Add(lblAdminInfo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formAddEquationQuestion";
            Text = "formUserHome";
            ResumeLayout(false);
        }

        #endregion

        private Label lblAdminInfo;
        private Custom_Controls.CustomButton btnAddImage;
        private Custom_Controls.CustomTextbox tbQuestionTitle;
        private Custom_Controls.CustomButton btnAddQuesiton;
        private Custom_Controls.CustomButton btnCancel;
        private Custom_Controls.CustomTextbox tbAnswer;
        private Custom_Controls.CustomTextbox tbRegex;
        private Label lblFilePath;
        private Label lblError;
        private Custom_Controls.CustomTextbox tbQuestion;
        private Custom_Controls.ChemistryCharacterKeypad chemistryCharacterKeypad1;
    }
}
