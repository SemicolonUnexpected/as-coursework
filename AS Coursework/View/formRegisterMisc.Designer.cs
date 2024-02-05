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
            dtpDateOfBirth.CalendarFont = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateOfBirth.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(110, 0);
            dtpDateOfBirth.Margin = new Padding(0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(170, 30);
            dtpDateOfBirth.TabIndex = 1;
            dtpDateOfBirth.CloseUp += dtpDateOfBirth_CloseUp;
            dtpDateOfBirth.Leave += dtpDateOfBirth_Leave;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.None;
            lblGender.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(0, 0);
            lblGender.Margin = new Padding(0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 30);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender :";
            lblGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Anchor = AnchorStyles.None;
            lblDateOfBirth.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirth.ForeColor = Color.White;
            lblDateOfBirth.Location = new Point(0, 0);
            lblDateOfBirth.Margin = new Padding(0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(110, 30);
            lblDateOfBirth.TabIndex = 4;
            lblDateOfBirth.Text = "Date of birth :";
            lblDateOfBirth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDateOfBirth
            // 
            pnlDateOfBirth.Anchor = AnchorStyles.None;
            pnlDateOfBirth.Controls.Add(dtpDateOfBirth);
            pnlDateOfBirth.Controls.Add(lblDateOfBirth);
            pnlDateOfBirth.Location = new Point(23, 14);
            pnlDateOfBirth.Margin = new Padding(5);
            pnlDateOfBirth.Name = "pnlDateOfBirth";
            pnlDateOfBirth.Size = new Size(280, 30);
            pnlDateOfBirth.TabIndex = 0;
            // 
            // pnlGender
            // 
            pnlGender.Anchor = AnchorStyles.None;
            pnlGender.Controls.Add(lblGender);
            pnlGender.Controls.Add(cbGender);
            pnlGender.Location = new Point(26, 192);
            pnlGender.Margin = new Padding(5);
            pnlGender.Name = "pnlGender";
            pnlGender.Padding = new Padding(3);
            pnlGender.Size = new Size(280, 30);
            pnlGender.TabIndex = 5;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Bahnschrift", 13.5F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(74, 0);
            cbGender.Margin = new Padding(0);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(206, 30);
            cbGender.TabIndex = 4;
            // 
            // lblDateOfBirthError
            // 
            lblDateOfBirthError.Anchor = AnchorStyles.None;
            lblDateOfBirthError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirthError.ForeColor = Color.Red;
            lblDateOfBirthError.Location = new Point(13, 54);
            lblDateOfBirthError.Margin = new Padding(5);
            lblDateOfBirthError.Name = "lblDateOfBirthError";
            lblDateOfBirthError.Size = new Size(292, 19);
            lblDateOfBirthError.TabIndex = 6;
            lblDateOfBirthError.Text = "Error";
            lblDateOfBirthError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNameError
            // 
            lblNameError.Anchor = AnchorStyles.None;
            lblNameError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameError.ForeColor = Color.Red;
            lblNameError.Location = new Point(23, 163);
            lblNameError.Margin = new Padding(5);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(292, 19);
            lblNameError.TabIndex = 6;
            lblNameError.Text = "Error";
            lblNameError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGenderError
            // 
            lblGenderError.Anchor = AnchorStyles.None;
            lblGenderError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenderError.ForeColor = Color.Red;
            lblGenderError.Location = new Point(14, 232);
            lblGenderError.Margin = new Padding(5);
            lblGenderError.Name = "lblGenderError";
            lblGenderError.Size = new Size(292, 19);
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
            tbEmail.Location = new Point(45, 261);
            tbEmail.Margin = new Padding(5);
            tbEmail.Name = "tbEmail";
            tbEmail.Padding = new Padding(6, 5, 6, 5);
            tbEmail.PlaceholderText = "E-mail";
            tbEmail.PlaceholderTextColor = Color.White;
            tbEmail.ShortcutEnabled = true;
            tbEmail.Size = new Size(245, 30);
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
            tbSurname.Location = new Point(45, 123);
            tbSurname.Margin = new Padding(5);
            tbSurname.Name = "tbSurname";
            tbSurname.Padding = new Padding(6, 5, 6, 5);
            tbSurname.PlaceholderText = "Surname";
            tbSurname.PlaceholderTextColor = Color.White;
            tbSurname.ShortcutEnabled = true;
            tbSurname.Size = new Size(245, 30);
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
            tbForename.Location = new Point(45, 83);
            tbForename.Margin = new Padding(5);
            tbForename.Name = "tbForename";
            tbForename.Padding = new Padding(6, 5, 6, 5);
            tbForename.PlaceholderText = "Forename";
            tbForename.PlaceholderTextColor = Color.White;
            tbForename.ShortcutEnabled = true;
            tbForename.Size = new Size(245, 30);
            tbForename.TabIndex = 2;
            tbForename.UsePasswordChar = false;
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
            btnNext.Location = new Point(236, 356);
            btnNext.Margin = new Padding(5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(70, 30);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblEmailError
            // 
            lblEmailError.Anchor = AnchorStyles.None;
            lblEmailError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(14, 301);
            lblEmailError.Margin = new Padding(5);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(292, 19);
            lblEmailError.TabIndex = 6;
            lblEmailError.Text = "Error";
            lblEmailError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formRegisterMisc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(320, 400);
            Controls.Add(lblEmailError);
            Controls.Add(lblDateOfBirthError);
            Controls.Add(lblGenderError);
            Controls.Add(lblNameError);
            Controls.Add(pnlGender);
            Controls.Add(pnlDateOfBirth);
            Controls.Add(tbEmail);
            Controls.Add(tbSurname);
            Controls.Add(tbForename);
            Controls.Add(btnNext);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formRegisterMisc";
            Text = "RegisterMiscView";
            pnlDateOfBirth.ResumeLayout(false);
            pnlGender.ResumeLayout(false);
            ResumeLayout(false);
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