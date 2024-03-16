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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblAdminInfo = new Label();
            btnAddQuestion = new Custom_Controls.CustomButton();
            btnCancel = new Custom_Controls.CustomButton();
            lblError = new Label();
            tbCorrectAnswer = new Custom_Controls.CustomTextbox();
            tbQuestionTitle = new Custom_Controls.CustomTextbox();
            tbQuestion = new Custom_Controls.CustomTextbox();
            btnAdd = new Custom_Controls.CustomButton();
            btnDelete = new Custom_Controls.CustomButton();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
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
            lblAdminInfo.Size = new Size(628, 50);
            lblAdminInfo.TabIndex = 0;
            lblAdminInfo.Text = "To create a multiple choice question, fill the fields below. Add at last three incorretc answers to the table.";
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
            btnAddQuestion.Click += btnAddQuestion_Click;
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
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.AutoEllipsis = true;
            lblError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(11, 495);
            lblError.Margin = new Padding(2, 0, 2, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(628, 40);
            lblError.TabIndex = 17;
            lblError.Text = "Error";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbCorrectAnswer
            // 
            tbCorrectAnswer.Anchor = AnchorStyles.None;
            tbCorrectAnswer.BackColor = Color.FromArgb(20, 20, 50);
            tbCorrectAnswer.BorderColor = Color.White;
            tbCorrectAnswer.BorderFocusColor = Color.White;
            tbCorrectAnswer.BorderSize = 2;
            tbCorrectAnswer.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbCorrectAnswer.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbCorrectAnswer.ForeColor = Color.White;
            tbCorrectAnswer.IsMultiline = false;
            tbCorrectAnswer.Location = new Point(137, 120);
            tbCorrectAnswer.Margin = new Padding(10);
            tbCorrectAnswer.Name = "tbCorrectAnswer";
            tbCorrectAnswer.Padding = new Padding(6, 5, 6, 5);
            tbCorrectAnswer.PlaceholderText = "Correct answer";
            tbCorrectAnswer.PlaceholderTextColor = Color.White;
            tbCorrectAnswer.ShortcutEnabled = true;
            tbCorrectAnswer.Size = new Size(367, 34);
            tbCorrectAnswer.TabIndex = 1;
            tbCorrectAnswer.UsePasswordChar = false;
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
            tbQuestionTitle.Location = new Point(137, 69);
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
            tbQuestion.Location = new Point(137, 173);
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
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(0, 150, 255);
            btnAdd.BorderColor = Color.White;
            btnAdd.BorderWidth = 2;
            btnAdd.CornerRadius = 15;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = null;
            btnAdd.ImageSize = new Size(150, 40);
            btnAdd.Location = new Point(442, 357);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.FromArgb(0, 150, 255);
            btnDelete.BorderColor = Color.White;
            btnDelete.BorderWidth = 2;
            btnDelete.CornerRadius = 15;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = null;
            btnDelete.ImageSize = new Size(150, 40);
            btnDelete.Location = new Point(442, 407);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.Anchor = AnchorStyles.None;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(0, 0, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 150, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.GridColor = Color.Black;
            dataGridView.Location = new Point(40, 331);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(392, 150);
            dataGridView.TabIndex = 1;
            // 
            // formAddMultipleChoiceQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(650, 600);
            Controls.Add(dataGridView);
            Controls.Add(tbQuestion);
            Controls.Add(lblError);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnAddQuestion);
            Controls.Add(tbCorrectAnswer);
            Controls.Add(tbQuestionTitle);
            Controls.Add(lblAdminInfo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formAddMultipleChoiceQuestion";
            Text = "formUserHome";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAdminInfo;
        private Custom_Controls.CustomButton btnAddQuestion;
        private Custom_Controls.CustomButton btnCancel;
        private Label lblError;
        private Custom_Controls.CustomTextbox tbCorrectAnswer;
        private Custom_Controls.CustomTextbox tbQuestionTitle;
        private Custom_Controls.CustomTextbox tbQuestion;
        private Custom_Controls.CustomButton btnAdd;
        private Custom_Controls.CustomButton btnDelete;
        private DataGridView dataGridView;
    }
}
