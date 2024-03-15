namespace AS_Coursework.View.Admin {
    partial class formAddFlashcardQuestion {
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
            lblError = new Label();
            tbBack = new Custom_Controls.CustomTextbox();
            tbFront = new Custom_Controls.CustomTextbox();
            SuspendLayout();
            // 
            // lblAdminInfo
            // 
            lblAdminInfo.Anchor = AnchorStyles.None;
            lblAdminInfo.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdminInfo.ForeColor = Color.White;
            lblAdminInfo.ImageAlign = ContentAlignment.TopCenter;
            lblAdminInfo.Location = new Point(36, 9);
            lblAdminInfo.Margin = new Padding(2, 0, 2, 0);
            lblAdminInfo.Name = "lblAdminInfo";
            lblAdminInfo.Size = new Size(628, 39);
            lblAdminInfo.TabIndex = 0;
            lblAdminInfo.Text = "To create an flashcard question, fill in the fields below.";
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
            tbQuestionTitle.Location = new Point(165, 56);
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
            btnAddQuesiton.Location = new Point(517, 540);
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
            btnCancel.Location = new Point(363, 540);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 40);
            btnCancel.TabIndex = 3;
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
            lblError.Location = new Point(0, 512);
            lblError.Margin = new Padding(2, 0, 2, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(699, 23);
            lblError.TabIndex = 17;
            lblError.Text = "Error";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbBack
            // 
            tbBack.Anchor = AnchorStyles.None;
            tbBack.BackColor = Color.FromArgb(20, 20, 50);
            tbBack.BorderColor = Color.White;
            tbBack.BorderFocusColor = Color.White;
            tbBack.BorderSize = 1;
            tbBack.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Rectangle;
            tbBack.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbBack.ForeColor = Color.White;
            tbBack.IsMultiline = true;
            tbBack.Location = new Point(165, 321);
            tbBack.Margin = new Padding(25);
            tbBack.Name = "tbBack";
            tbBack.Padding = new Padding(7);
            tbBack.PlaceholderText = "Back of the flashcard...";
            tbBack.PlaceholderTextColor = Color.White;
            tbBack.ShortcutEnabled = true;
            tbBack.Size = new Size(367, 183);
            tbBack.TabIndex = 2;
            tbBack.UsePasswordChar = false;
            // 
            // tbFront
            // 
            tbFront.Anchor = AnchorStyles.None;
            tbFront.BackColor = Color.FromArgb(20, 20, 50);
            tbFront.BorderColor = Color.White;
            tbFront.BorderFocusColor = Color.White;
            tbFront.BorderSize = 1;
            tbFront.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Rectangle;
            tbFront.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbFront.ForeColor = Color.White;
            tbFront.IsMultiline = true;
            tbFront.Location = new Point(165, 112);
            tbFront.Margin = new Padding(25);
            tbFront.Name = "tbFront";
            tbFront.Padding = new Padding(7);
            tbFront.PlaceholderText = "Front of the flashcard...";
            tbFront.PlaceholderTextColor = Color.White;
            tbFront.ShortcutEnabled = true;
            tbFront.Size = new Size(367, 183);
            tbFront.TabIndex = 2;
            tbFront.UsePasswordChar = false;
            // 
            // formAddFlashcardQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(700, 600);
            Controls.Add(tbFront);
            Controls.Add(tbBack);
            Controls.Add(lblError);
            Controls.Add(btnCancel);
            Controls.Add(btnAddQuesiton);
            Controls.Add(tbQuestionTitle);
            Controls.Add(lblAdminInfo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formAddFlashcardQuestion";
            Text = "formUserHome";
            ResumeLayout(false);
        }

        #endregion

        private Label lblAdminInfo;
        private Custom_Controls.CustomButton btnAddImage;
        private Custom_Controls.CustomTextbox tbQuestionTitle;
        private Custom_Controls.CustomButton btnAddQuesiton;
        private Custom_Controls.CustomButton btnCancel;
        private Label lblFilePath;
        private Label lblError;
        private Custom_Controls.CustomTextbox tbBack;
        private Custom_Controls.CustomTextbox tbFront;
    }
}
