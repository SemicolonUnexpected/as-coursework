namespace AS_Coursework.View.Admin {
    partial class formAddMultipleChoiceQuestion {
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
            btnAddQuestion = new Custom_Controls.CustomButton();
            btnCancel = new Custom_Controls.CustomButton();
            tbRegex = new Custom_Controls.CustomTextbox();
            lblError = new Label();
            tbAnswer = new Custom_Controls.CustomTextbox();
            tbQuestionTitle = new Custom_Controls.CustomTextbox();
            tbQuestion = new Custom_Controls.CustomTextbox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            lblAdminInfo.Size = new Size(628, 76);
            lblAdminInfo.TabIndex = 0;
            lblAdminInfo.Text = "To create a multiple choice question, fill the fields below.";
            lblAdminInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Anchor = AnchorStyles.None;
            btnAddQuestion.BackColor = Color.FromArgb(0, 150, 255);
            btnAddQuestion.BorderColor = Color.White;
            btnAddQuestion.BorderWidth = 2;
            btnAddQuestion.CornerRadius = 15;
            btnAddQuestion.FlatAppearance.BorderSize = 0;
            btnAddQuestion.FlatStyle = FlatStyle.Flat;
            btnAddQuestion.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddQuestion.ForeColor = Color.White;
            btnAddQuestion.Image = null;
            btnAddQuestion.ImageSize = new Size(150, 40);
            btnAddQuestion.Location = new Point(492, 540);
            btnAddQuestion.Margin = new Padding(5);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(144, 40);
            btnAddQuestion.TabIndex = 6;
            btnAddQuestion.Text = "Add question";
            btnAddQuestion.UseVisualStyleBackColor = false;
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
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbRegex
            // 
            tbRegex.Anchor = AnchorStyles.None;
            tbRegex.BackColor = Color.FromArgb(20, 20, 50);
            tbRegex.BorderColor = Color.White;
            tbRegex.BorderFocusColor = Color.White;
            tbRegex.BorderSize = 2;
            tbRegex.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbRegex.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbRegex.ForeColor = Color.White;
            tbRegex.IsMultiline = false;
            tbRegex.Location = new Point(140, 208);
            tbRegex.Margin = new Padding(10);
            tbRegex.Name = "tbRegex";
            tbRegex.Padding = new Padding(6, 5, 6, 5);
            tbRegex.PlaceholderText = "Correct answer regex";
            tbRegex.PlaceholderTextColor = Color.White;
            tbRegex.ShortcutEnabled = true;
            tbRegex.Size = new Size(367, 34);
            tbRegex.TabIndex = 2;
            tbRegex.UsePasswordChar = false;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.AutoEllipsis = true;
            lblError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(11, 422);
            lblError.Margin = new Padding(2, 0, 2, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(628, 20);
            lblError.TabIndex = 17;
            lblError.Text = "Error";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
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
            tbAnswer.Location = new Point(140, 157);
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
            tbQuestionTitle.Location = new Point(140, 106);
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
            tbQuestion.Location = new Point(140, 261);
            tbQuestion.Margin = new Padding(25);
            tbQuestion.Name = "tbQuestion";
            tbQuestion.Padding = new Padding(7);
            tbQuestion.PlaceholderText = "Question";
            tbQuestion.PlaceholderTextColor = Color.White;
            tbQuestion.ShortcutEnabled = true;
            tbQuestion.Size = new Size(367, 147);
            tbQuestion.TabIndex = 3;
            tbQuestion.UsePasswordChar = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(192, 325);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 18;
            // 
            // formAddMultipleChoiceQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(650, 600);
            Controls.Add(dataGridView1);
            Controls.Add(tbQuestion);
            Controls.Add(lblError);
            Controls.Add(btnCancel);
            Controls.Add(btnAddQuestion);
            Controls.Add(tbRegex);
            Controls.Add(tbAnswer);
            Controls.Add(tbQuestionTitle);
            Controls.Add(lblAdminInfo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formAddMultipleChoiceQuestion";
            Text = "formUserHome";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAdminInfo;
        private Custom_Controls.CustomButton btnAddQuestion;
        private Custom_Controls.CustomButton btnCancel;
        private Custom_Controls.CustomTextbox tbRegex;
        private Label lblError;
        private Custom_Controls.CustomTextbox tbAnswer;
        private Custom_Controls.CustomTextbox tbQuestionTitle;
        private Custom_Controls.CustomTextbox tbQuestion;
        private DataGridView dataGridView1;
    }
}
