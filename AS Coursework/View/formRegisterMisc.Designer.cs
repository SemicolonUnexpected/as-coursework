namespace AS_Coursework.View {
    partial class formRegisterMisc {
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
            dtpDateOfBirth = new DateTimePicker();
            lblGender = new Label();
            lblDateOfBirth = new Label();
            pnlDateOfBirth = new Panel();
            pnlGender = new Panel();
            cbGender = new ComboBox();
            lblDateOfBirthError = new Label();
            lblNameError = new Label();
            lblGenderError = new Label();
            tbEmail = new Custom_Controls.CustomTextbox();
            tbSurname = new Custom_Controls.CustomTextbox();
            tbForename = new Custom_Controls.CustomTextbox();
            btnNext = new Custom_Controls.CustomButton();
            lblEmailError = new Label();
            pnlDateOfBirth.SuspendLayout();
            pnlGender.SuspendLayout();
            SuspendLayout();
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.None;
            dtpDateOfBirth.CalendarFont = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateOfBirth.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(188, 8);
            dtpDateOfBirth.Margin = new Padding(4);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(208, 36);
            dtpDateOfBirth.TabIndex = 1;
            dtpDateOfBirth.CloseUp += dtpDateOfBirth_CloseUp;
            dtpDateOfBirth.Leave += dtpDateOfBirth_Leave;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.None;
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(37, 9);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(102, 29);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender :";
            lblGender.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Anchor = AnchorStyles.None;
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirth.ForeColor = Color.White;
            lblDateOfBirth.Location = new Point(13, 5);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(157, 29);
            lblDateOfBirth.TabIndex = 4;
            lblDateOfBirth.Text = "Date of birth :";
            lblDateOfBirth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDateOfBirth
            // 
            pnlDateOfBirth.Anchor = AnchorStyles.None;
            pnlDateOfBirth.Controls.Add(dtpDateOfBirth);
            pnlDateOfBirth.Controls.Add(lblDateOfBirth);
            pnlDateOfBirth.Location = new Point(28, 17);
            pnlDateOfBirth.Margin = new Padding(0, 25, 0, 0);
            pnlDateOfBirth.Name = "pnlDateOfBirth";
            pnlDateOfBirth.Size = new Size(400, 50);
            pnlDateOfBirth.TabIndex = 0;
            // 
            // pnlGender
            // 
            pnlGender.Anchor = AnchorStyles.None;
            pnlGender.Controls.Add(lblGender);
            pnlGender.Controls.Add(cbGender);
            pnlGender.Location = new Point(28, 288);
            pnlGender.Margin = new Padding(0, 25, 0, 0);
            pnlGender.Name = "pnlGender";
            pnlGender.Padding = new Padding(4, 5, 4, 5);
            pnlGender.Size = new Size(400, 50);
            pnlGender.TabIndex = 5;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(178, 11);
            cbGender.Margin = new Padding(3, 4, 3, 4);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(200, 37);
            cbGender.TabIndex = 4;
            // 
            // lblDateOfBirthError
            // 
            lblDateOfBirthError.Anchor = AnchorStyles.None;
            lblDateOfBirthError.AutoSize = true;
            lblDateOfBirthError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirthError.ForeColor = Color.Red;
            lblDateOfBirthError.Location = new Point(190, 77);
            lblDateOfBirthError.Margin = new Padding(5);
            lblDateOfBirthError.Name = "lblDateOfBirthError";
            lblDateOfBirthError.Size = new Size(70, 29);
            lblDateOfBirthError.TabIndex = 6;
            lblDateOfBirthError.Text = "Error";
            lblDateOfBirthError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNameError
            // 
            lblNameError.Anchor = AnchorStyles.None;
            lblNameError.AutoSize = true;
            lblNameError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameError.ForeColor = Color.Red;
            lblNameError.Location = new Point(190, 246);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(70, 29);
            lblNameError.TabIndex = 6;
            lblNameError.Text = "Error";
            lblNameError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGenderError
            // 
            lblGenderError.Anchor = AnchorStyles.None;
            lblGenderError.AutoSize = true;
            lblGenderError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenderError.ForeColor = Color.Red;
            lblGenderError.Location = new Point(190, 353);
            lblGenderError.Name = "lblGenderError";
            lblGenderError.Size = new Size(70, 29);
            lblGenderError.TabIndex = 6;
            lblGenderError.Text = "Error";
            lblGenderError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.None;
            tbEmail.BackColor = Color.FromArgb(20, 20, 50);
            tbEmail.BorderColor = Color.White;
            tbEmail.BorderFocusColor = Color.White;
            tbEmail.BorderSize = 4;
            tbEmail.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbEmail.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.ForeColor = Color.White;
            tbEmail.IsMultiline = false;
            tbEmail.Location = new Point(53, 398);
            tbEmail.Margin = new Padding(0, 25, 0, 0);
            tbEmail.Name = "tbEmail";
            tbEmail.Padding = new Padding(8, 9, 8, 9);
            tbEmail.PlaceholderText = "E-mail";
            tbEmail.PlaceholderTextColor = Color.White;
            tbEmail.ShortcutEnabled = true;
            tbEmail.Size = new Size(350, 48);
            tbEmail.TabIndex = 5;
            tbEmail.UsePasswordChar = false;
            tbEmail.Leave += tbEmail_Leave;
            // 
            // tbSurname
            // 
            tbSurname.Anchor = AnchorStyles.None;
            tbSurname.BackColor = Color.FromArgb(20, 20, 50);
            tbSurname.BorderColor = Color.White;
            tbSurname.BorderFocusColor = Color.White;
            tbSurname.BorderSize = 4;
            tbSurname.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbSurname.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSurname.ForeColor = Color.White;
            tbSurname.IsMultiline = false;
            tbSurname.Location = new Point(53, 184);
            tbSurname.Margin = new Padding(0, 25, 0, 0);
            tbSurname.Name = "tbSurname";
            tbSurname.Padding = new Padding(8, 9, 8, 9);
            tbSurname.PlaceholderText = "Surname";
            tbSurname.PlaceholderTextColor = Color.White;
            tbSurname.ShortcutEnabled = true;
            tbSurname.Size = new Size(350, 48);
            tbSurname.TabIndex = 3;
            tbSurname.UsePasswordChar = false;
            tbSurname.Leave += tbSurname_Leave;
            // 
            // tbForename
            // 
            tbForename.Anchor = AnchorStyles.None;
            tbForename.BackColor = Color.FromArgb(20, 20, 50);
            tbForename.BorderColor = Color.White;
            tbForename.BorderFocusColor = Color.White;
            tbForename.BorderSize = 4;
            tbForename.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbForename.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbForename.ForeColor = Color.White;
            tbForename.IsMultiline = false;
            tbForename.Location = new Point(53, 111);
            tbForename.Margin = new Padding(0, 25, 0, 0);
            tbForename.Name = "tbForename";
            tbForename.Padding = new Padding(8, 9, 8, 9);
            tbForename.PlaceholderText = "Forename";
            tbForename.PlaceholderTextColor = Color.White;
            tbForename.ShortcutEnabled = true;
            tbForename.Size = new Size(350, 48);
            tbForename.TabIndex = 2;
            tbForename.UsePasswordChar = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(0, 150, 255);
            btnNext.BorderColor = Color.White;
            btnNext.BorderWidth = 2;
            btnNext.CornerRadius = 20;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.BlanchedAlmond;
            btnNext.Location = new Point(337, 531);
            btnNext.Margin = new Padding(10);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 50);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblEmailError
            // 
            lblEmailError.Anchor = AnchorStyles.None;
            lblEmailError.AutoSize = true;
            lblEmailError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(190, 468);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(70, 29);
            lblEmailError.TabIndex = 6;
            lblEmailError.Text = "Error";
            lblEmailError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formRegisterMisc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(456, 600);
            Controls.Add(lblEmailError);
            Controls.Add(lblGenderError);
            Controls.Add(lblNameError);
            Controls.Add(lblDateOfBirthError);
            Controls.Add(pnlGender);
            Controls.Add(pnlDateOfBirth);
            Controls.Add(tbEmail);
            Controls.Add(tbSurname);
            Controls.Add(tbForename);
            Controls.Add(btnNext);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formRegisterMisc";
            Text = "RegisterMiscView";
            pnlDateOfBirth.ResumeLayout(false);
            pnlDateOfBirth.PerformLayout();
            pnlGender.ResumeLayout(false);
            pnlGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDateOfBirth;
        private Custom_Controls.CustomTextbox tbForename;
        private Custom_Controls.CustomTextbox tbSurname;
        private Custom_Controls.CustomTextbox tbEmail;
        private Label lblGender;
        private Label lblDateOfBirth;
        private Panel pnlDateOfBirth;
        private Panel pnlGender;
        private Custom_Controls.CustomButton btnNext;
        private Label lblDateOfBirthError;
        private Label lblNameError;
        private Label lblGenderError;
        private ComboBox cbGender;
        private Label lblEmailError;
    }
}