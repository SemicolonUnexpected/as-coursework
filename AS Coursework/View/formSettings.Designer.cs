namespace AS_Coursework.View {
    partial class formSettings {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSettings));
            pbUserProfile = new Custom_Controls.PictureFrame();
            btnLogin = new Custom_Controls.CustomButton();
            customButton1 = new Custom_Controls.CustomButton();
            pnlProfilePicture = new Panel();
            pnlAccount = new Custom_Controls.CustomRectangle();
            label7 = new Label();
            customTextbox3 = new Custom_Controls.CustomTextbox();
            customButton6 = new Custom_Controls.CustomButton();
            label8 = new Label();
            label5 = new Label();
            customTextbox2 = new Custom_Controls.CustomTextbox();
            customButton5 = new Custom_Controls.CustomButton();
            label6 = new Label();
            lblAccountTitle = new Label();
            lblChangeEmailTitle = new Label();
            tbNewEmail = new Custom_Controls.CustomTextbox();
            lblChangeUsernameTitle = new Label();
            btnChangeEmail = new Custom_Controls.CustomButton();
            tbNewUsername = new Custom_Controls.CustomTextbox();
            lblChangeEmailError = new Label();
            btnChangeUsername = new Custom_Controls.CustomButton();
            lblChangeUsernameError = new Label();
            pnlDangerZone = new Custom_Controls.CustomRectangle();
            customButton2 = new Custom_Controls.CustomButton();
            lblConfirmPasswordError = new Label();
            lblDangerZoneDescription = new Label();
            lblDangerZoneTitle = new Label();
            lblPasswordError = new Label();
            btnDeleteAccount = new Custom_Controls.CustomButton();
            tbNewPassword = new Custom_Controls.CustomTextbox();
            pbPasswordView = new PictureBox();
            tbConfirmPassword = new Custom_Controls.CustomTextbox();
            pnlPasswordStrength = new Panel();
            lblSpecialCharacters = new Label();
            lblLettersNumbers = new Label();
            lblPasswordLength = new Label();
            pbSpecialCharacters = new PictureBox();
            pbLettersNumbers = new PictureBox();
            pbPasswordLength = new PictureBox();
            btnDone = new Custom_Controls.CustomButton();
            lblDetailsTitle = new Label();
            pblAppearance = new Custom_Controls.CustomRectangle();
            dtpDateOfBirth = new DateTimePicker();
            lblDateOfBirth = new Label();
            lblDateOfBirthError = new Label();
            lblGender = new Label();
            lblGenderError = new Label();
            cbGender = new ComboBox();
            lblUsername = new Label();
            pnlProfilePicture.SuspendLayout();
            pnlAccount.SuspendLayout();
            pnlDangerZone.SuspendLayout();
            tbNewPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPasswordView).BeginInit();
            pnlPasswordStrength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpecialCharacters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLettersNumbers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPasswordLength).BeginInit();
            pblAppearance.SuspendLayout();
            SuspendLayout();
            // 
            // pbUserProfile
            // 
            pbUserProfile.Anchor = AnchorStyles.Top;
            pbUserProfile.BorderColorOne = Color.FromArgb(0, 100, 255);
            pbUserProfile.BorderColorTwo = Color.FromArgb(50, 200, 255);
            pbUserProfile.BorderWidth = 30;
            pbUserProfile.GradientAngle = 45;
            pbUserProfile.GradientRectangle = new Rectangle(0, 0, 350, 350);
            pbUserProfile.Image = Resources.Icons.User;
            pbUserProfile.ImagePortion = new Rectangle(-256, -256, 1024, 1024);
            pbUserProfile.Location = new Point(0, 0);
            pbUserProfile.Name = "pbUserProfile";
            pbUserProfile.Size = new Size(300, 300);
            pbUserProfile.TabIndex = 0;
            pbUserProfile.Text = "pbProfile";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = Color.FromArgb(0, 150, 255);
            btnLogin.BorderColor = Color.White;
            btnLogin.BorderWidth = 2;
            btnLogin.CornerRadius = 20;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Image = null;
            btnLogin.ImageSize = new Size(150, 40);
            btnLogin.Location = new Point(44, 310);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(60, 60);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "<";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            customButton1.Anchor = AnchorStyles.Top;
            customButton1.BackColor = Color.FromArgb(0, 150, 255);
            customButton1.BorderColor = Color.White;
            customButton1.BorderWidth = 2;
            customButton1.CornerRadius = 20;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.Image = null;
            customButton1.ImageSize = new Size(150, 40);
            customButton1.Location = new Point(184, 312);
            customButton1.Margin = new Padding(0);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(60, 60);
            customButton1.TabIndex = 3;
            customButton1.Tag = "";
            customButton1.Text = ">";
            customButton1.UseVisualStyleBackColor = false;
            // 
            // pnlProfilePicture
            // 
            pnlProfilePicture.Anchor = AnchorStyles.None;
            pnlProfilePicture.Controls.Add(pbUserProfile);
            pnlProfilePicture.Controls.Add(btnLogin);
            pnlProfilePicture.Controls.Add(customButton1);
            pnlProfilePicture.Location = new Point(44, 23);
            pnlProfilePicture.Margin = new Padding(0);
            pnlProfilePicture.Name = "pnlProfilePicture";
            pnlProfilePicture.Size = new Size(300, 384);
            pnlProfilePicture.TabIndex = 4;
            // 
            // pnlAccount
            // 
            pnlAccount.Anchor = AnchorStyles.Top;
            pnlAccount.BackColor = Color.FromArgb(30, 30, 70);
            pnlAccount.BorderColor = Color.White;
            pnlAccount.BorderWidth = 0;
            pnlAccount.Controls.Add(label7);
            pnlAccount.Controls.Add(customTextbox3);
            pnlAccount.Controls.Add(customButton6);
            pnlAccount.Controls.Add(label8);
            pnlAccount.Controls.Add(label5);
            pnlAccount.Controls.Add(customTextbox2);
            pnlAccount.Controls.Add(customButton5);
            pnlAccount.Controls.Add(label6);
            pnlAccount.Controls.Add(lblAccountTitle);
            pnlAccount.Controls.Add(lblChangeEmailTitle);
            pnlAccount.Controls.Add(tbNewEmail);
            pnlAccount.Controls.Add(lblChangeUsernameTitle);
            pnlAccount.Controls.Add(btnChangeEmail);
            pnlAccount.Controls.Add(tbNewUsername);
            pnlAccount.Controls.Add(lblChangeEmailError);
            pnlAccount.Controls.Add(btnChangeUsername);
            pnlAccount.Controls.Add(lblChangeUsernameError);
            pnlAccount.CornerRadius = 20;
            pnlAccount.Location = new Point(402, 23);
            pnlAccount.Margin = new Padding(20);
            pnlAccount.Name = "pnlAccount";
            pnlAccount.Size = new Size(544, 848);
            pnlAccount.TabIndex = 5;
            pnlAccount.Text = "customRectangle1";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(25, 625);
            label7.Margin = new Padding(25, 0, 25, 0);
            label7.MaximumSize = new Size(450, 0);
            label7.Name = "label7";
            label7.Size = new Size(245, 34);
            label7.TabIndex = 14;
            label7.Text = "Change username";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customTextbox3
            // 
            customTextbox3.Anchor = AnchorStyles.None;
            customTextbox3.BackColor = Color.FromArgb(30, 30, 70);
            customTextbox3.BorderColor = Color.White;
            customTextbox3.BorderFocusColor = Color.White;
            customTextbox3.BorderSize = 4;
            customTextbox3.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            customTextbox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customTextbox3.ForeColor = Color.White;
            customTextbox3.IsMultiline = false;
            customTextbox3.Location = new Point(25, 676);
            customTextbox3.Margin = new Padding(25, 0, 25, 0);
            customTextbox3.Name = "customTextbox3";
            customTextbox3.Padding = new Padding(8, 9, 8, 9);
            customTextbox3.PlaceholderText = "New username";
            customTextbox3.PlaceholderTextColor = Color.White;
            customTextbox3.ShortcutEnabled = true;
            customTextbox3.Size = new Size(344, 48);
            customTextbox3.TabIndex = 15;
            customTextbox3.UsePasswordChar = false;
            // 
            // customButton6
            // 
            customButton6.BackColor = Color.FromArgb(0, 150, 255);
            customButton6.BorderColor = Color.White;
            customButton6.BorderWidth = 2;
            customButton6.CornerRadius = 20;
            customButton6.FlatAppearance.BorderSize = 0;
            customButton6.FlatStyle = FlatStyle.Popup;
            customButton6.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            customButton6.ForeColor = Color.BlanchedAlmond;
            customButton6.Image = null;
            customButton6.ImageSize = new Size(150, 40);
            customButton6.Location = new Point(419, 674);
            customButton6.Margin = new Padding(25, 0, 25, 0);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(100, 50);
            customButton6.TabIndex = 13;
            customButton6.Text = "Done";
            customButton6.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(229, 746);
            label8.Name = "label8";
            label8.Size = new Size(70, 29);
            label8.TabIndex = 16;
            label8.Text = "Error";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 456);
            label5.Margin = new Padding(25, 0, 25, 0);
            label5.MaximumSize = new Size(450, 0);
            label5.Name = "label5";
            label5.Size = new Size(245, 34);
            label5.TabIndex = 10;
            label5.Text = "Change username";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customTextbox2
            // 
            customTextbox2.Anchor = AnchorStyles.None;
            customTextbox2.BackColor = Color.FromArgb(30, 30, 70);
            customTextbox2.BorderColor = Color.White;
            customTextbox2.BorderFocusColor = Color.White;
            customTextbox2.BorderSize = 4;
            customTextbox2.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            customTextbox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customTextbox2.ForeColor = Color.White;
            customTextbox2.IsMultiline = false;
            customTextbox2.Location = new Point(25, 506);
            customTextbox2.Margin = new Padding(25, 0, 25, 0);
            customTextbox2.Name = "customTextbox2";
            customTextbox2.Padding = new Padding(8, 9, 8, 9);
            customTextbox2.PlaceholderText = "New username";
            customTextbox2.PlaceholderTextColor = Color.White;
            customTextbox2.ShortcutEnabled = true;
            customTextbox2.Size = new Size(344, 48);
            customTextbox2.TabIndex = 11;
            customTextbox2.UsePasswordChar = false;
            // 
            // customButton5
            // 
            customButton5.BackColor = Color.FromArgb(0, 150, 255);
            customButton5.BorderColor = Color.White;
            customButton5.BorderWidth = 0;
            customButton5.CornerRadius = 20;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatStyle = FlatStyle.Popup;
            customButton5.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            customButton5.ForeColor = Color.BlanchedAlmond;
            customButton5.Image = null;
            customButton5.ImageSize = new Size(150, 40);
            customButton5.Location = new Point(419, 504);
            customButton5.Margin = new Padding(25, 0, 25, 0);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(100, 50);
            customButton5.TabIndex = 9;
            customButton5.Text = "Done";
            customButton5.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(229, 576);
            label6.Name = "label6";
            label6.Size = new Size(70, 29);
            label6.TabIndex = 12;
            label6.Text = "Error";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAccountTitle
            // 
            lblAccountTitle.AutoEllipsis = true;
            lblAccountTitle.AutoSize = true;
            lblAccountTitle.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccountTitle.ForeColor = Color.White;
            lblAccountTitle.Location = new Point(20, 20);
            lblAccountTitle.Margin = new Padding(20);
            lblAccountTitle.Name = "lblAccountTitle";
            lblAccountTitle.Size = new Size(150, 43);
            lblAccountTitle.TabIndex = 2;
            lblAccountTitle.Text = "Account";
            // 
            // lblChangeEmailTitle
            // 
            lblChangeEmailTitle.Anchor = AnchorStyles.None;
            lblChangeEmailTitle.AutoSize = true;
            lblChangeEmailTitle.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeEmailTitle.ForeColor = Color.White;
            lblChangeEmailTitle.Location = new Point(20, 291);
            lblChangeEmailTitle.Margin = new Padding(25, 0, 25, 0);
            lblChangeEmailTitle.MaximumSize = new Size(450, 0);
            lblChangeEmailTitle.Name = "lblChangeEmailTitle";
            lblChangeEmailTitle.Size = new Size(186, 34);
            lblChangeEmailTitle.TabIndex = 1;
            lblChangeEmailTitle.Text = "Change email";
            lblChangeEmailTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbNewEmail
            // 
            tbNewEmail.Anchor = AnchorStyles.None;
            tbNewEmail.BackColor = Color.FromArgb(30, 30, 70);
            tbNewEmail.BorderColor = Color.White;
            tbNewEmail.BorderFocusColor = Color.White;
            tbNewEmail.BorderSize = 4;
            tbNewEmail.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbNewEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNewEmail.ForeColor = Color.White;
            tbNewEmail.IsMultiline = false;
            tbNewEmail.Location = new Point(20, 336);
            tbNewEmail.Margin = new Padding(25, 0, 25, 0);
            tbNewEmail.Name = "tbNewEmail";
            tbNewEmail.Padding = new Padding(8, 9, 8, 9);
            tbNewEmail.PlaceholderText = "New email";
            tbNewEmail.PlaceholderTextColor = Color.White;
            tbNewEmail.ShortcutEnabled = true;
            tbNewEmail.Size = new Size(344, 48);
            tbNewEmail.TabIndex = 1;
            tbNewEmail.UsePasswordChar = false;
            // 
            // lblChangeUsernameTitle
            // 
            lblChangeUsernameTitle.Anchor = AnchorStyles.None;
            lblChangeUsernameTitle.AutoSize = true;
            lblChangeUsernameTitle.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeUsernameTitle.ForeColor = Color.White;
            lblChangeUsernameTitle.Location = new Point(25, 116);
            lblChangeUsernameTitle.Margin = new Padding(25, 0, 25, 0);
            lblChangeUsernameTitle.MaximumSize = new Size(450, 0);
            lblChangeUsernameTitle.Name = "lblChangeUsernameTitle";
            lblChangeUsernameTitle.Size = new Size(245, 34);
            lblChangeUsernameTitle.TabIndex = 1;
            lblChangeUsernameTitle.Text = "Change username";
            lblChangeUsernameTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnChangeEmail
            // 
            btnChangeEmail.BackColor = Color.FromArgb(0, 150, 255);
            btnChangeEmail.BorderColor = Color.White;
            btnChangeEmail.BorderWidth = 2;
            btnChangeEmail.CornerRadius = 20;
            btnChangeEmail.FlatAppearance.BorderSize = 0;
            btnChangeEmail.FlatStyle = FlatStyle.Popup;
            btnChangeEmail.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeEmail.ForeColor = Color.BlanchedAlmond;
            btnChangeEmail.Image = null;
            btnChangeEmail.ImageSize = new Size(150, 40);
            btnChangeEmail.Location = new Point(419, 334);
            btnChangeEmail.Margin = new Padding(25, 0, 25, 0);
            btnChangeEmail.Name = "btnChangeEmail";
            btnChangeEmail.Size = new Size(100, 50);
            btnChangeEmail.TabIndex = 0;
            btnChangeEmail.Text = "Done";
            btnChangeEmail.UseVisualStyleBackColor = false;
            // 
            // tbNewUsername
            // 
            tbNewUsername.Anchor = AnchorStyles.None;
            tbNewUsername.BackColor = Color.FromArgb(30, 30, 70);
            tbNewUsername.BorderColor = Color.White;
            tbNewUsername.BorderFocusColor = Color.White;
            tbNewUsername.BorderSize = 4;
            tbNewUsername.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbNewUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNewUsername.ForeColor = Color.White;
            tbNewUsername.IsMultiline = false;
            tbNewUsername.Location = new Point(25, 164);
            tbNewUsername.Margin = new Padding(25, 0, 25, 0);
            tbNewUsername.Name = "tbNewUsername";
            tbNewUsername.Padding = new Padding(8, 9, 8, 9);
            tbNewUsername.PlaceholderText = "New username";
            tbNewUsername.PlaceholderTextColor = Color.White;
            tbNewUsername.ShortcutEnabled = true;
            tbNewUsername.Size = new Size(344, 48);
            tbNewUsername.TabIndex = 1;
            tbNewUsername.UsePasswordChar = false;
            // 
            // lblChangeEmailError
            // 
            lblChangeEmailError.Anchor = AnchorStyles.None;
            lblChangeEmailError.AutoSize = true;
            lblChangeEmailError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeEmailError.ForeColor = Color.Red;
            lblChangeEmailError.Location = new Point(224, 406);
            lblChangeEmailError.Name = "lblChangeEmailError";
            lblChangeEmailError.Size = new Size(70, 29);
            lblChangeEmailError.TabIndex = 8;
            lblChangeEmailError.Text = "Error";
            lblChangeEmailError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnChangeUsername
            // 
            btnChangeUsername.BackColor = Color.FromArgb(0, 150, 255);
            btnChangeUsername.BorderColor = Color.White;
            btnChangeUsername.BorderWidth = 2;
            btnChangeUsername.CornerRadius = 20;
            btnChangeUsername.FlatAppearance.BorderSize = 0;
            btnChangeUsername.FlatStyle = FlatStyle.Popup;
            btnChangeUsername.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeUsername.ForeColor = Color.BlanchedAlmond;
            btnChangeUsername.Image = null;
            btnChangeUsername.ImageSize = new Size(150, 40);
            btnChangeUsername.Location = new Point(419, 162);
            btnChangeUsername.Margin = new Padding(25, 0, 25, 0);
            btnChangeUsername.Name = "btnChangeUsername";
            btnChangeUsername.Size = new Size(100, 50);
            btnChangeUsername.TabIndex = 0;
            btnChangeUsername.Text = "Done";
            btnChangeUsername.UseVisualStyleBackColor = false;
            // 
            // lblChangeUsernameError
            // 
            lblChangeUsernameError.Anchor = AnchorStyles.None;
            lblChangeUsernameError.AutoSize = true;
            lblChangeUsernameError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeUsernameError.ForeColor = Color.Red;
            lblChangeUsernameError.Location = new Point(224, 236);
            lblChangeUsernameError.Name = "lblChangeUsernameError";
            lblChangeUsernameError.Size = new Size(70, 29);
            lblChangeUsernameError.TabIndex = 8;
            lblChangeUsernameError.Text = "Error";
            lblChangeUsernameError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDangerZone
            // 
            pnlDangerZone.Anchor = AnchorStyles.Top;
            pnlDangerZone.BackColor = Color.FromArgb(30, 30, 70);
            pnlDangerZone.BorderColor = Color.White;
            pnlDangerZone.BorderWidth = 0;
            pnlDangerZone.Controls.Add(customButton2);
            pnlDangerZone.Controls.Add(lblConfirmPasswordError);
            pnlDangerZone.Controls.Add(lblDangerZoneDescription);
            pnlDangerZone.Controls.Add(lblDangerZoneTitle);
            pnlDangerZone.Controls.Add(lblPasswordError);
            pnlDangerZone.Controls.Add(btnDeleteAccount);
            pnlDangerZone.Controls.Add(tbNewPassword);
            pnlDangerZone.Controls.Add(tbConfirmPassword);
            pnlDangerZone.Controls.Add(pnlPasswordStrength);
            pnlDangerZone.Controls.Add(btnDone);
            pnlDangerZone.CornerRadius = 20;
            pnlDangerZone.Location = new Point(29, 911);
            pnlDangerZone.Margin = new Padding(20);
            pnlDangerZone.Name = "pnlDangerZone";
            pnlDangerZone.Size = new Size(917, 500);
            pnlDangerZone.TabIndex = 6;
            pnlDangerZone.Text = "customRectangle1";
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.FromArgb(0, 150, 255);
            customButton2.BorderColor = Color.White;
            customButton2.BorderWidth = 2;
            customButton2.CornerRadius = 20;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Popup;
            customButton2.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            customButton2.ForeColor = Color.BlanchedAlmond;
            customButton2.Image = null;
            customButton2.ImageSize = new Size(150, 40);
            customButton2.Location = new Point(119, 384);
            customButton2.Margin = new Padding(10);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(235, 50);
            customButton2.TabIndex = 4;
            customButton2.Text = "Delete Account";
            customButton2.UseVisualStyleBackColor = false;
            // 
            // lblConfirmPasswordError
            // 
            lblConfirmPasswordError.Anchor = AnchorStyles.None;
            lblConfirmPasswordError.AutoSize = true;
            lblConfirmPasswordError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmPasswordError.ForeColor = Color.Red;
            lblConfirmPasswordError.Location = new Point(625, 414);
            lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            lblConfirmPasswordError.Size = new Size(70, 29);
            lblConfirmPasswordError.TabIndex = 3;
            lblConfirmPasswordError.Text = "Error";
            lblConfirmPasswordError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDangerZoneDescription
            // 
            lblDangerZoneDescription.Anchor = AnchorStyles.None;
            lblDangerZoneDescription.AutoSize = true;
            lblDangerZoneDescription.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDangerZoneDescription.ForeColor = Color.White;
            lblDangerZoneDescription.Location = new Point(22, 93);
            lblDangerZoneDescription.MaximumSize = new Size(450, 0);
            lblDangerZoneDescription.Name = "lblDangerZoneDescription";
            lblDangerZoneDescription.Size = new Size(449, 145);
            lblDangerZoneDescription.TabIndex = 1;
            lblDangerZoneDescription.Text = "Welcome to the 'Danger Zone' (duh duh duuuh).  Here you can change your password, reset or delete your account. You have been warned, these actions can be dangerous";
            lblDangerZoneDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDangerZoneTitle
            // 
            lblDangerZoneTitle.AutoEllipsis = true;
            lblDangerZoneTitle.AutoSize = true;
            lblDangerZoneTitle.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDangerZoneTitle.ForeColor = Color.White;
            lblDangerZoneTitle.Location = new Point(20, 20);
            lblDangerZoneTitle.Margin = new Padding(20);
            lblDangerZoneTitle.Name = "lblDangerZoneTitle";
            lblDangerZoneTitle.Size = new Size(224, 43);
            lblDangerZoneTitle.TabIndex = 2;
            lblDangerZoneTitle.Text = "Danger Zone";
            // 
            // lblPasswordError
            // 
            lblPasswordError.Anchor = AnchorStyles.None;
            lblPasswordError.AutoSize = true;
            lblPasswordError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(625, 314);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(70, 29);
            lblPasswordError.TabIndex = 3;
            lblPasswordError.Text = "Error";
            lblPasswordError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.FromArgb(0, 150, 255);
            btnDeleteAccount.BorderColor = Color.White;
            btnDeleteAccount.BorderWidth = 2;
            btnDeleteAccount.CornerRadius = 20;
            btnDeleteAccount.FlatAppearance.BorderSize = 0;
            btnDeleteAccount.FlatStyle = FlatStyle.Popup;
            btnDeleteAccount.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteAccount.ForeColor = Color.BlanchedAlmond;
            btnDeleteAccount.Image = null;
            btnDeleteAccount.ImageSize = new Size(150, 40);
            btnDeleteAccount.Location = new Point(119, 293);
            btnDeleteAccount.Margin = new Padding(10);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(235, 50);
            btnDeleteAccount.TabIndex = 0;
            btnDeleteAccount.Text = "Reset Score";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Anchor = AnchorStyles.None;
            tbNewPassword.BackColor = Color.FromArgb(30, 30, 70);
            tbNewPassword.BorderColor = Color.White;
            tbNewPassword.BorderFocusColor = Color.White;
            tbNewPassword.BorderSize = 4;
            tbNewPassword.Controls.Add(pbPasswordView);
            tbNewPassword.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbNewPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNewPassword.ForeColor = Color.White;
            tbNewPassword.IsMultiline = false;
            tbNewPassword.Location = new Point(509, 53);
            tbNewPassword.Margin = new Padding(28, 31, 28, 31);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Padding = new Padding(8, 9, 39, 9);
            tbNewPassword.PlaceholderText = "New password";
            tbNewPassword.PlaceholderTextColor = Color.White;
            tbNewPassword.ShortcutEnabled = true;
            tbNewPassword.Size = new Size(333, 48);
            tbNewPassword.TabIndex = 1;
            tbNewPassword.UsePasswordChar = true;
            // 
            // pbPasswordView
            // 
            pbPasswordView.Image = Resources.Icons.Eye;
            pbPasswordView.Location = new Point(300, 8);
            pbPasswordView.Name = "pbPasswordView";
            pbPasswordView.Size = new Size(30, 30);
            pbPasswordView.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPasswordView.TabIndex = 2;
            pbPasswordView.TabStop = false;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Anchor = AnchorStyles.None;
            tbConfirmPassword.BackColor = Color.FromArgb(30, 30, 70);
            tbConfirmPassword.BorderColor = Color.White;
            tbConfirmPassword.BorderFocusColor = Color.White;
            tbConfirmPassword.BorderSize = 4;
            tbConfirmPassword.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbConfirmPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbConfirmPassword.ForeColor = Color.White;
            tbConfirmPassword.IsMultiline = false;
            tbConfirmPassword.Location = new Point(509, 347);
            tbConfirmPassword.Margin = new Padding(28, 31, 28, 31);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Padding = new Padding(8, 9, 8, 9);
            tbConfirmPassword.PlaceholderText = "Confirm password";
            tbConfirmPassword.PlaceholderTextColor = Color.White;
            tbConfirmPassword.ShortcutEnabled = true;
            tbConfirmPassword.Size = new Size(333, 48);
            tbConfirmPassword.TabIndex = 1;
            tbConfirmPassword.UsePasswordChar = true;
            // 
            // pnlPasswordStrength
            // 
            pnlPasswordStrength.Anchor = AnchorStyles.None;
            pnlPasswordStrength.BackColor = Color.FromArgb(30, 30, 70);
            pnlPasswordStrength.Controls.Add(lblSpecialCharacters);
            pnlPasswordStrength.Controls.Add(lblLettersNumbers);
            pnlPasswordStrength.Controls.Add(lblPasswordLength);
            pnlPasswordStrength.Controls.Add(pbSpecialCharacters);
            pnlPasswordStrength.Controls.Add(pbLettersNumbers);
            pnlPasswordStrength.Controls.Add(pbPasswordLength);
            pnlPasswordStrength.Location = new Point(509, 120);
            pnlPasswordStrength.Margin = new Padding(28, 0, 28, 31);
            pnlPasswordStrength.Name = "pnlPasswordStrength";
            pnlPasswordStrength.Size = new Size(333, 182);
            pnlPasswordStrength.TabIndex = 1;
            // 
            // lblSpecialCharacters
            // 
            lblSpecialCharacters.Anchor = AnchorStyles.None;
            lblSpecialCharacters.AutoSize = true;
            lblSpecialCharacters.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpecialCharacters.ForeColor = Color.White;
            lblSpecialCharacters.Location = new Point(59, 136);
            lblSpecialCharacters.Name = "lblSpecialCharacters";
            lblSpecialCharacters.Size = new Size(214, 29);
            lblSpecialCharacters.TabIndex = 1;
            lblSpecialCharacters.Text = "Special characters";
            lblSpecialCharacters.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLettersNumbers
            // 
            lblLettersNumbers.Anchor = AnchorStyles.None;
            lblLettersNumbers.AutoSize = true;
            lblLettersNumbers.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLettersNumbers.ForeColor = Color.White;
            lblLettersNumbers.Location = new Point(59, 74);
            lblLettersNumbers.Name = "lblLettersNumbers";
            lblLettersNumbers.Size = new Size(237, 29);
            lblLettersNumbers.TabIndex = 1;
            lblLettersNumbers.Text = "Letters and numbers";
            lblLettersNumbers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPasswordLength
            // 
            lblPasswordLength.Anchor = AnchorStyles.None;
            lblPasswordLength.AutoSize = true;
            lblPasswordLength.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordLength.ForeColor = Color.White;
            lblPasswordLength.Location = new Point(59, 11);
            lblPasswordLength.Name = "lblPasswordLength";
            lblPasswordLength.Size = new Size(241, 29);
            lblPasswordLength.TabIndex = 1;
            lblPasswordLength.Text = "Eight characters long";
            lblPasswordLength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbSpecialCharacters
            // 
            pbSpecialCharacters.Anchor = AnchorStyles.None;
            pbSpecialCharacters.Image = (Image)resources.GetObject("pbSpecialCharacters.Image");
            pbSpecialCharacters.Location = new Point(17, 135);
            pbSpecialCharacters.Margin = new Padding(6);
            pbSpecialCharacters.Name = "pbSpecialCharacters";
            pbSpecialCharacters.Size = new Size(35, 35);
            pbSpecialCharacters.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSpecialCharacters.TabIndex = 0;
            pbSpecialCharacters.TabStop = false;
            // 
            // pbLettersNumbers
            // 
            pbLettersNumbers.Anchor = AnchorStyles.None;
            pbLettersNumbers.Image = Resources.Icons.Red_Cross_Circle;
            pbLettersNumbers.Location = new Point(17, 73);
            pbLettersNumbers.Margin = new Padding(6);
            pbLettersNumbers.Name = "pbLettersNumbers";
            pbLettersNumbers.Size = new Size(35, 35);
            pbLettersNumbers.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLettersNumbers.TabIndex = 0;
            pbLettersNumbers.TabStop = false;
            // 
            // pbPasswordLength
            // 
            pbPasswordLength.Anchor = AnchorStyles.None;
            pbPasswordLength.Image = (Image)resources.GetObject("pbPasswordLength.Image");
            pbPasswordLength.Location = new Point(17, 13);
            pbPasswordLength.Margin = new Padding(6);
            pbPasswordLength.Name = "pbPasswordLength";
            pbPasswordLength.Size = new Size(35, 35);
            pbPasswordLength.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPasswordLength.TabIndex = 0;
            pbPasswordLength.TabStop = false;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(0, 150, 255);
            btnDone.BorderColor = Color.White;
            btnDone.BorderWidth = 2;
            btnDone.CornerRadius = 20;
            btnDone.FlatAppearance.BorderSize = 0;
            btnDone.FlatStyle = FlatStyle.Popup;
            btnDone.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDone.ForeColor = Color.BlanchedAlmond;
            btnDone.Image = null;
            btnDone.ImageSize = new Size(150, 40);
            btnDone.Location = new Point(797, 430);
            btnDone.Margin = new Padding(20);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(100, 50);
            btnDone.TabIndex = 0;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            // 
            // lblDetailsTitle
            // 
            lblDetailsTitle.AutoEllipsis = true;
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDetailsTitle.ForeColor = Color.White;
            lblDetailsTitle.Location = new Point(20, 20);
            lblDetailsTitle.Margin = new Padding(20);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new Size(131, 43);
            lblDetailsTitle.TabIndex = 2;
            lblDetailsTitle.Text = "Details";
            // 
            // pblAppearance
            // 
            pblAppearance.Anchor = AnchorStyles.Top;
            pblAppearance.BackColor = Color.FromArgb(30, 30, 70);
            pblAppearance.BorderColor = Color.White;
            pblAppearance.BorderWidth = 0;
            pblAppearance.Controls.Add(dtpDateOfBirth);
            pblAppearance.Controls.Add(lblDateOfBirth);
            pblAppearance.Controls.Add(lblDateOfBirthError);
            pblAppearance.Controls.Add(lblGender);
            pblAppearance.Controls.Add(lblGenderError);
            pblAppearance.Controls.Add(cbGender);
            pblAppearance.Controls.Add(lblDetailsTitle);
            pblAppearance.CornerRadius = 20;
            pblAppearance.Location = new Point(29, 479);
            pblAppearance.Margin = new Padding(20);
            pblAppearance.Name = "pblAppearance";
            pblAppearance.Size = new Size(333, 392);
            pblAppearance.TabIndex = 6;
            pblAppearance.Text = "customRectangle1";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.None;
            dtpDateOfBirth.CalendarFont = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateOfBirth.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(25, 279);
            dtpDateOfBirth.Margin = new Padding(4);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(281, 36);
            dtpDateOfBirth.TabIndex = 9;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Anchor = AnchorStyles.None;
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirth.ForeColor = Color.White;
            lblDateOfBirth.Location = new Point(22, 224);
            lblDateOfBirth.Margin = new Padding(5);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(157, 29);
            lblDateOfBirth.TabIndex = 10;
            lblDateOfBirth.Text = "Date of birth :";
            lblDateOfBirth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateOfBirthError
            // 
            lblDateOfBirthError.Anchor = AnchorStyles.None;
            lblDateOfBirthError.AutoSize = true;
            lblDateOfBirthError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirthError.ForeColor = Color.Red;
            lblDateOfBirthError.Location = new Point(119, 324);
            lblDateOfBirthError.Margin = new Padding(5);
            lblDateOfBirthError.Name = "lblDateOfBirthError";
            lblDateOfBirthError.Size = new Size(70, 29);
            lblDateOfBirthError.TabIndex = 11;
            lblDateOfBirthError.Text = "Error";
            lblDateOfBirthError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.None;
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(20, 71);
            lblGender.Margin = new Padding(0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(102, 29);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender :";
            lblGender.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGenderError
            // 
            lblGenderError.Anchor = AnchorStyles.None;
            lblGenderError.AutoSize = true;
            lblGenderError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenderError.ForeColor = Color.Red;
            lblGenderError.Location = new Point(119, 173);
            lblGenderError.Name = "lblGenderError";
            lblGenderError.Size = new Size(70, 29);
            lblGenderError.TabIndex = 8;
            lblGenderError.Text = "Error";
            lblGenderError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(20, 120);
            cbGender.Margin = new Padding(20);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(293, 37);
            cbGender.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoEllipsis = true;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(103, 420);
            lblUsername.Margin = new Padding(25);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(185, 43);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // formSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(975, 1440);
            Controls.Add(lblUsername);
            Controls.Add(pblAppearance);
            Controls.Add(pnlDangerZone);
            Controls.Add(pnlAccount);
            Controls.Add(pnlProfilePicture);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formSettings";
            Text = "formSettings";
            pnlProfilePicture.ResumeLayout(false);
            pnlAccount.ResumeLayout(false);
            pnlAccount.PerformLayout();
            pnlDangerZone.ResumeLayout(false);
            pnlDangerZone.PerformLayout();
            tbNewPassword.ResumeLayout(false);
            tbNewPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPasswordView).EndInit();
            pnlPasswordStrength.ResumeLayout(false);
            pnlPasswordStrength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpecialCharacters).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLettersNumbers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPasswordLength).EndInit();
            pblAppearance.ResumeLayout(false);
            pblAppearance.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom_Controls.PictureFrame pbUserProfile;
        private Custom_Controls.CustomButton btnLogin;
        private Custom_Controls.CustomButton customButton1;
        private Panel pnlProfilePicture;
        private Custom_Controls.CustomRectangle pnlAccount;
        private Label lblAccountTitle;
        private Custom_Controls.CustomRectangle pnlDangerZone;
        private Label lblDetailsTitle;
        private Custom_Controls.CustomRectangle pblAppearance;
        private Label lblDangerZoneTitle;
        private Custom_Controls.CustomButton btnDeleteAccount;
        private Label lblConfirmPasswordError;
        private Custom_Controls.CustomTextbox tbNewPassword;
        private PictureBox pbPasswordView;
        private Custom_Controls.CustomTextbox tbConfirmPassword;
        private Panel pnlPasswordStrength;
        private Label lblSpecialCharacters;
        private Label lblLettersNumbers;
        private Label lblPasswordLength;
        private PictureBox pbSpecialCharacters;
        private PictureBox pbLettersNumbers;
        private PictureBox pbPasswordLength;
        private Custom_Controls.CustomButton customButton2;
        private Label lblPasswordError;
        private Custom_Controls.CustomTextbox tbNewUsername;
        private Label lblDangerZoneDescription;
        private Custom_Controls.CustomButton btnDone;
        private Label label1;
        private Label lblChangeUsernameTitle;
        private Custom_Controls.CustomButton btnChangeUsername;
        private Label lblUsername;
        private Label lblGender;
        private Label lblGenderError;
        private ComboBox cbGender;
        private DateTimePicker dtpDateOfBirth;
        private Label lblDateOfBirth;
        private Label lblDateOfBirthError;
        private Label label5;
        private Custom_Controls.CustomTextbox customTextbox2;
        private Custom_Controls.CustomButton customButton5;
        private Label label6;
        private Label lblChangeEmailTitle;
        private Custom_Controls.CustomTextbox tbNewEmail;
        private Custom_Controls.CustomButton btnChangeEmail;
        private Label lblChangeEmailError;
        private Label lblChangeUsernameError;
        private Label label7;
        private Custom_Controls.CustomTextbox customTextbox3;
        private Custom_Controls.CustomButton customButton6;
        private Label label8;
    }
}