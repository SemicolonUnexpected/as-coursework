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
            btnProfilePicturePrevious = new Custom_Controls.CustomButton();
            btnProfilePictureNext = new Custom_Controls.CustomButton();
            pnlProfilePicture = new Panel();
            pnlAccount = new Custom_Controls.CustomRectangle();
            lblChangeSurnameTitle = new Label();
            tbNewSurname = new Custom_Controls.CustomTextbox();
            btnChangeSurname = new Custom_Controls.CustomButton();
            lblChangeSurnameError = new Label();
            lblChangeForename = new Label();
            tbNewForename = new Custom_Controls.CustomTextbox();
            btnChangeForename = new Custom_Controls.CustomButton();
            lblChangeForenameError = new Label();
            lblAccountTitle = new Label();
            lblChangeEmailTitle = new Label();
            tbNewEmail = new Custom_Controls.CustomTextbox();
            lblSurnameDetail = new Label();
            lblForenameDetail = new Label();
            lblEmailDetail = new Label();
            lblUsernameDetail = new Label();
            lblChangeUsernameTitle = new Label();
            btnChangeEmail = new Custom_Controls.CustomButton();
            tbNewUsername = new Custom_Controls.CustomTextbox();
            lblChangeEmailError = new Label();
            btnChangeUsername = new Custom_Controls.CustomButton();
            lblChangeUsernameError = new Label();
            pnlDangerZone = new Custom_Controls.CustomRectangle();
            btnDeleteAccount = new Custom_Controls.CustomButton();
            lblConfirmPasswordError = new Label();
            lblDangerZoneDescription = new Label();
            lblDangerZoneTitle = new Label();
            lblPasswordError = new Label();
            btnResetScore = new Custom_Controls.CustomButton();
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
            // btnProfilePicturePrevious
            // 
            btnProfilePicturePrevious.Anchor = AnchorStyles.Top;
            btnProfilePicturePrevious.BackColor = Color.FromArgb(0, 150, 255);
            btnProfilePicturePrevious.BorderColor = Color.White;
            btnProfilePicturePrevious.BorderWidth = 2;
            btnProfilePicturePrevious.CornerRadius = 20;
            btnProfilePicturePrevious.FlatAppearance.BorderSize = 0;
            btnProfilePicturePrevious.FlatStyle = FlatStyle.Flat;
            btnProfilePicturePrevious.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfilePicturePrevious.ForeColor = Color.White;
            btnProfilePicturePrevious.Image = null;
            btnProfilePicturePrevious.ImageSize = new Size(150, 40);
            btnProfilePicturePrevious.Location = new Point(44, 310);
            btnProfilePicturePrevious.Margin = new Padding(0);
            btnProfilePicturePrevious.Name = "btnProfilePicturePrevious";
            btnProfilePicturePrevious.Size = new Size(60, 60);
            btnProfilePicturePrevious.TabIndex = 3;
            btnProfilePicturePrevious.Text = "<";
            btnProfilePicturePrevious.UseVisualStyleBackColor = false;
            // 
            // btnProfilePictureNext
            // 
            btnProfilePictureNext.Anchor = AnchorStyles.Top;
            btnProfilePictureNext.BackColor = Color.FromArgb(0, 150, 255);
            btnProfilePictureNext.BorderColor = Color.White;
            btnProfilePictureNext.BorderWidth = 2;
            btnProfilePictureNext.CornerRadius = 20;
            btnProfilePictureNext.FlatAppearance.BorderSize = 0;
            btnProfilePictureNext.FlatStyle = FlatStyle.Flat;
            btnProfilePictureNext.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfilePictureNext.ForeColor = Color.White;
            btnProfilePictureNext.Image = null;
            btnProfilePictureNext.ImageSize = new Size(150, 40);
            btnProfilePictureNext.Location = new Point(184, 312);
            btnProfilePictureNext.Margin = new Padding(0);
            btnProfilePictureNext.Name = "btnProfilePictureNext";
            btnProfilePictureNext.Size = new Size(60, 60);
            btnProfilePictureNext.TabIndex = 3;
            btnProfilePictureNext.Tag = "";
            btnProfilePictureNext.Text = ">";
            btnProfilePictureNext.UseVisualStyleBackColor = false;
            // 
            // pnlProfilePicture
            // 
            pnlProfilePicture.Anchor = AnchorStyles.None;
            pnlProfilePicture.Controls.Add(pbUserProfile);
            pnlProfilePicture.Controls.Add(btnProfilePicturePrevious);
            pnlProfilePicture.Controls.Add(btnProfilePictureNext);
            pnlProfilePicture.Location = new Point(44, 29);
            pnlProfilePicture.Margin = new Padding(0);
            pnlProfilePicture.Name = "pnlProfilePicture";
            pnlProfilePicture.Size = new Size(300, 384);
            pnlProfilePicture.TabIndex = 4;
            // 
            // pnlAccount
            // 
            pnlAccount.Anchor = AnchorStyles.None;
            pnlAccount.BackColor = Color.FromArgb(30, 30, 70);
            pnlAccount.BorderColor = Color.White;
            pnlAccount.BorderWidth = 0;
            pnlAccount.Controls.Add(lblChangeSurnameTitle);
            pnlAccount.Controls.Add(tbNewSurname);
            pnlAccount.Controls.Add(btnChangeSurname);
            pnlAccount.Controls.Add(lblChangeSurnameError);
            pnlAccount.Controls.Add(lblChangeForename);
            pnlAccount.Controls.Add(tbNewForename);
            pnlAccount.Controls.Add(btnChangeForename);
            pnlAccount.Controls.Add(lblChangeForenameError);
            pnlAccount.Controls.Add(lblAccountTitle);
            pnlAccount.Controls.Add(lblChangeEmailTitle);
            pnlAccount.Controls.Add(tbNewEmail);
            pnlAccount.Controls.Add(lblSurnameDetail);
            pnlAccount.Controls.Add(lblForenameDetail);
            pnlAccount.Controls.Add(lblEmailDetail);
            pnlAccount.Controls.Add(lblUsernameDetail);
            pnlAccount.Controls.Add(lblChangeUsernameTitle);
            pnlAccount.Controls.Add(btnChangeEmail);
            pnlAccount.Controls.Add(tbNewUsername);
            pnlAccount.Controls.Add(lblChangeEmailError);
            pnlAccount.Controls.Add(btnChangeUsername);
            pnlAccount.Controls.Add(lblChangeUsernameError);
            pnlAccount.CornerRadius = 20;
            pnlAccount.Location = new Point(402, 29);
            pnlAccount.Margin = new Padding(20);
            pnlAccount.Name = "pnlAccount";
            pnlAccount.Size = new Size(544, 868);
            pnlAccount.TabIndex = 5;
            pnlAccount.Text = "customRectangle1";
            // 
            // lblChangeSurnameTitle
            // 
            lblChangeSurnameTitle.Anchor = AnchorStyles.Left;
            lblChangeSurnameTitle.AutoSize = true;
            lblChangeSurnameTitle.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeSurnameTitle.ForeColor = Color.White;
            lblChangeSurnameTitle.Location = new Point(25, 724);
            lblChangeSurnameTitle.Margin = new Padding(25, 0, 25, 0);
            lblChangeSurnameTitle.MaximumSize = new Size(450, 0);
            lblChangeSurnameTitle.Name = "lblChangeSurnameTitle";
            lblChangeSurnameTitle.Size = new Size(230, 34);
            lblChangeSurnameTitle.TabIndex = 14;
            lblChangeSurnameTitle.Text = "Change surname";
            lblChangeSurnameTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbNewSurname
            // 
            tbNewSurname.Anchor = AnchorStyles.Left;
            tbNewSurname.BackColor = Color.FromArgb(30, 30, 70);
            tbNewSurname.BorderColor = Color.White;
            tbNewSurname.BorderFocusColor = Color.White;
            tbNewSurname.BorderSize = 4;
            tbNewSurname.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbNewSurname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNewSurname.ForeColor = Color.White;
            tbNewSurname.IsMultiline = false;
            tbNewSurname.Location = new Point(25, 764);
            tbNewSurname.Margin = new Padding(25, 0, 25, 0);
            tbNewSurname.Name = "tbNewSurname";
            tbNewSurname.Padding = new Padding(8, 9, 8, 9);
            tbNewSurname.PlaceholderText = "New surname";
            tbNewSurname.PlaceholderTextColor = Color.White;
            tbNewSurname.ShortcutEnabled = true;
            tbNewSurname.Size = new Size(344, 48);
            tbNewSurname.TabIndex = 15;
            tbNewSurname.UsePasswordChar = false;
            // 
            // btnChangeSurname
            // 
            btnChangeSurname.Anchor = AnchorStyles.Right;
            btnChangeSurname.BackColor = Color.FromArgb(0, 150, 255);
            btnChangeSurname.BorderColor = Color.White;
            btnChangeSurname.BorderWidth = 2;
            btnChangeSurname.CornerRadius = 20;
            btnChangeSurname.FlatAppearance.BorderSize = 0;
            btnChangeSurname.FlatStyle = FlatStyle.Popup;
            btnChangeSurname.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeSurname.ForeColor = Color.BlanchedAlmond;
            btnChangeSurname.Image = null;
            btnChangeSurname.ImageSize = new Size(150, 40);
            btnChangeSurname.Location = new Point(419, 762);
            btnChangeSurname.Margin = new Padding(25, 0, 25, 0);
            btnChangeSurname.Name = "btnChangeSurname";
            btnChangeSurname.Size = new Size(100, 50);
            btnChangeSurname.TabIndex = 13;
            btnChangeSurname.Text = "Done";
            btnChangeSurname.UseVisualStyleBackColor = false;
            btnChangeSurname.Click += btnChangeSurname_Click;
            // 
            // lblChangeSurnameError
            // 
            lblChangeSurnameError.Anchor = AnchorStyles.None;
            lblChangeSurnameError.AutoSize = true;
            lblChangeSurnameError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeSurnameError.ForeColor = Color.Red;
            lblChangeSurnameError.Location = new Point(229, 824);
            lblChangeSurnameError.Name = "lblChangeSurnameError";
            lblChangeSurnameError.Size = new Size(70, 29);
            lblChangeSurnameError.TabIndex = 16;
            lblChangeSurnameError.Text = "Error";
            lblChangeSurnameError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChangeForename
            // 
            lblChangeForename.Anchor = AnchorStyles.Left;
            lblChangeForename.AutoSize = true;
            lblChangeForename.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeForename.ForeColor = Color.White;
            lblChangeForename.Location = new Point(25, 574);
            lblChangeForename.Margin = new Padding(25, 0, 25, 0);
            lblChangeForename.MaximumSize = new Size(450, 0);
            lblChangeForename.Name = "lblChangeForename";
            lblChangeForename.Size = new Size(238, 34);
            lblChangeForename.TabIndex = 10;
            lblChangeForename.Text = "Change forename";
            lblChangeForename.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbNewForename
            // 
            tbNewForename.Anchor = AnchorStyles.Left;
            tbNewForename.BackColor = Color.FromArgb(30, 30, 70);
            tbNewForename.BorderColor = Color.White;
            tbNewForename.BorderFocusColor = Color.White;
            tbNewForename.BorderSize = 4;
            tbNewForename.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbNewForename.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNewForename.ForeColor = Color.White;
            tbNewForename.IsMultiline = false;
            tbNewForename.Location = new Point(25, 624);
            tbNewForename.Margin = new Padding(25, 0, 25, 0);
            tbNewForename.Name = "tbNewForename";
            tbNewForename.Padding = new Padding(8, 9, 8, 9);
            tbNewForename.PlaceholderText = "New forename";
            tbNewForename.PlaceholderTextColor = Color.White;
            tbNewForename.ShortcutEnabled = true;
            tbNewForename.Size = new Size(344, 48);
            tbNewForename.TabIndex = 11;
            tbNewForename.UsePasswordChar = false;
            // 
            // btnChangeForename
            // 
            btnChangeForename.Anchor = AnchorStyles.Right;
            btnChangeForename.BackColor = Color.FromArgb(0, 150, 255);
            btnChangeForename.BorderColor = Color.White;
            btnChangeForename.BorderWidth = 2;
            btnChangeForename.CornerRadius = 20;
            btnChangeForename.FlatAppearance.BorderSize = 0;
            btnChangeForename.FlatStyle = FlatStyle.Popup;
            btnChangeForename.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeForename.ForeColor = Color.BlanchedAlmond;
            btnChangeForename.Image = null;
            btnChangeForename.ImageSize = new Size(150, 40);
            btnChangeForename.Location = new Point(419, 622);
            btnChangeForename.Margin = new Padding(25, 0, 25, 0);
            btnChangeForename.Name = "btnChangeForename";
            btnChangeForename.Size = new Size(100, 50);
            btnChangeForename.TabIndex = 9;
            btnChangeForename.Text = "Done";
            btnChangeForename.UseVisualStyleBackColor = false;
            btnChangeForename.Click += btnChangeForename_Click;
            // 
            // lblChangeForenameError
            // 
            lblChangeForenameError.Anchor = AnchorStyles.None;
            lblChangeForenameError.AutoSize = true;
            lblChangeForenameError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeForenameError.ForeColor = Color.Red;
            lblChangeForenameError.Location = new Point(229, 684);
            lblChangeForenameError.Name = "lblChangeForenameError";
            lblChangeForenameError.Size = new Size(70, 29);
            lblChangeForenameError.TabIndex = 12;
            lblChangeForenameError.Text = "Error";
            lblChangeForenameError.TextAlign = ContentAlignment.MiddleCenter;
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
            lblChangeEmailTitle.Anchor = AnchorStyles.Left;
            lblChangeEmailTitle.AutoSize = true;
            lblChangeEmailTitle.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeEmailTitle.ForeColor = Color.White;
            lblChangeEmailTitle.Location = new Point(20, 434);
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
            tbNewEmail.Anchor = AnchorStyles.Left;
            tbNewEmail.BackColor = Color.FromArgb(30, 30, 70);
            tbNewEmail.BorderColor = Color.White;
            tbNewEmail.BorderFocusColor = Color.White;
            tbNewEmail.BorderSize = 4;
            tbNewEmail.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbNewEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNewEmail.ForeColor = Color.White;
            tbNewEmail.IsMultiline = false;
            tbNewEmail.Location = new Point(20, 474);
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
            // lblSurnameDetail
            // 
            lblSurnameDetail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSurnameDetail.AutoSize = true;
            lblSurnameDetail.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSurnameDetail.ForeColor = Color.White;
            lblSurnameDetail.Location = new Point(25, 234);
            lblSurnameDetail.Margin = new Padding(25, 0, 25, 0);
            lblSurnameDetail.MaximumSize = new Size(494, 34);
            lblSurnameDetail.MinimumSize = new Size(494, 34);
            lblSurnameDetail.Name = "lblSurnameDetail";
            lblSurnameDetail.Size = new Size(494, 34);
            lblSurnameDetail.TabIndex = 1;
            lblSurnameDetail.Text = "Surname :";
            lblSurnameDetail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblForenameDetail
            // 
            lblForenameDetail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblForenameDetail.AutoSize = true;
            lblForenameDetail.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblForenameDetail.ForeColor = Color.White;
            lblForenameDetail.Location = new Point(25, 185);
            lblForenameDetail.Margin = new Padding(25, 0, 25, 0);
            lblForenameDetail.MaximumSize = new Size(494, 34);
            lblForenameDetail.MinimumSize = new Size(494, 34);
            lblForenameDetail.Name = "lblForenameDetail";
            lblForenameDetail.Size = new Size(494, 34);
            lblForenameDetail.TabIndex = 1;
            lblForenameDetail.Text = "Forename :";
            lblForenameDetail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmailDetail
            // 
            lblEmailDetail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblEmailDetail.AutoSize = true;
            lblEmailDetail.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailDetail.ForeColor = Color.White;
            lblEmailDetail.Location = new Point(25, 133);
            lblEmailDetail.Margin = new Padding(25, 0, 25, 0);
            lblEmailDetail.MaximumSize = new Size(494, 34);
            lblEmailDetail.MinimumSize = new Size(494, 34);
            lblEmailDetail.Name = "lblEmailDetail";
            lblEmailDetail.Size = new Size(494, 34);
            lblEmailDetail.TabIndex = 1;
            lblEmailDetail.Text = "Email : ";
            lblEmailDetail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsernameDetail
            // 
            lblUsernameDetail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUsernameDetail.AutoSize = true;
            lblUsernameDetail.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsernameDetail.ForeColor = Color.White;
            lblUsernameDetail.Location = new Point(25, 83);
            lblUsernameDetail.Margin = new Padding(25, 0, 25, 0);
            lblUsernameDetail.MaximumSize = new Size(494, 34);
            lblUsernameDetail.MinimumSize = new Size(494, 34);
            lblUsernameDetail.Name = "lblUsernameDetail";
            lblUsernameDetail.Size = new Size(494, 34);
            lblUsernameDetail.TabIndex = 1;
            lblUsernameDetail.Text = "Username : ";
            lblUsernameDetail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChangeUsernameTitle
            // 
            lblChangeUsernameTitle.Anchor = AnchorStyles.Left;
            lblChangeUsernameTitle.AutoSize = true;
            lblChangeUsernameTitle.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeUsernameTitle.ForeColor = Color.White;
            lblChangeUsernameTitle.Location = new Point(25, 293);
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
            btnChangeEmail.Anchor = AnchorStyles.Right;
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
            btnChangeEmail.Location = new Point(419, 472);
            btnChangeEmail.Margin = new Padding(25, 0, 25, 0);
            btnChangeEmail.Name = "btnChangeEmail";
            btnChangeEmail.Size = new Size(100, 50);
            btnChangeEmail.TabIndex = 0;
            btnChangeEmail.Text = "Done";
            btnChangeEmail.UseVisualStyleBackColor = false;
            btnChangeEmail.Click += btnChangeEmail_Click;
            // 
            // tbNewUsername
            // 
            tbNewUsername.Anchor = AnchorStyles.Left;
            tbNewUsername.BackColor = Color.FromArgb(30, 30, 70);
            tbNewUsername.BorderColor = Color.White;
            tbNewUsername.BorderFocusColor = Color.White;
            tbNewUsername.BorderSize = 4;
            tbNewUsername.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbNewUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNewUsername.ForeColor = Color.White;
            tbNewUsername.IsMultiline = false;
            tbNewUsername.Location = new Point(25, 344);
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
            lblChangeEmailError.Location = new Point(224, 535);
            lblChangeEmailError.Name = "lblChangeEmailError";
            lblChangeEmailError.Size = new Size(70, 29);
            lblChangeEmailError.TabIndex = 8;
            lblChangeEmailError.Text = "Error";
            lblChangeEmailError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnChangeUsername
            // 
            btnChangeUsername.Anchor = AnchorStyles.Right;
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
            btnChangeUsername.Location = new Point(419, 338);
            btnChangeUsername.Margin = new Padding(25, 0, 25, 0);
            btnChangeUsername.Name = "btnChangeUsername";
            btnChangeUsername.Size = new Size(100, 50);
            btnChangeUsername.TabIndex = 0;
            btnChangeUsername.Text = "Done";
            btnChangeUsername.UseVisualStyleBackColor = false;
            btnChangeUsername.Click += btnChangeUsername_Click;
            // 
            // lblChangeUsernameError
            // 
            lblChangeUsernameError.Anchor = AnchorStyles.None;
            lblChangeUsernameError.AutoSize = true;
            lblChangeUsernameError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeUsernameError.ForeColor = Color.Red;
            lblChangeUsernameError.Location = new Point(224, 404);
            lblChangeUsernameError.Name = "lblChangeUsernameError";
            lblChangeUsernameError.Size = new Size(70, 29);
            lblChangeUsernameError.TabIndex = 8;
            lblChangeUsernameError.Text = "Error";
            lblChangeUsernameError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDangerZone
            // 
            pnlDangerZone.Anchor = AnchorStyles.None;
            pnlDangerZone.BackColor = Color.FromArgb(30, 30, 70);
            pnlDangerZone.BorderColor = Color.White;
            pnlDangerZone.BorderWidth = 0;
            pnlDangerZone.Controls.Add(btnDeleteAccount);
            pnlDangerZone.Controls.Add(lblConfirmPasswordError);
            pnlDangerZone.Controls.Add(lblDangerZoneDescription);
            pnlDangerZone.Controls.Add(lblDangerZoneTitle);
            pnlDangerZone.Controls.Add(lblPasswordError);
            pnlDangerZone.Controls.Add(btnResetScore);
            pnlDangerZone.Controls.Add(tbNewPassword);
            pnlDangerZone.Controls.Add(tbConfirmPassword);
            pnlDangerZone.Controls.Add(pnlPasswordStrength);
            pnlDangerZone.Controls.Add(btnDone);
            pnlDangerZone.CornerRadius = 20;
            pnlDangerZone.Location = new Point(29, 937);
            pnlDangerZone.Margin = new Padding(20);
            pnlDangerZone.Name = "pnlDangerZone";
            pnlDangerZone.Size = new Size(917, 500);
            pnlDangerZone.TabIndex = 6;
            pnlDangerZone.Text = "customRectangle1";
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
            btnDeleteAccount.Location = new Point(119, 384);
            btnDeleteAccount.Margin = new Padding(10);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(235, 50);
            btnDeleteAccount.TabIndex = 4;
            btnDeleteAccount.Text = "Delete Account";
            btnDeleteAccount.UseVisualStyleBackColor = false;
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
            // btnResetScore
            // 
            btnResetScore.BackColor = Color.FromArgb(0, 150, 255);
            btnResetScore.BorderColor = Color.White;
            btnResetScore.BorderWidth = 2;
            btnResetScore.CornerRadius = 20;
            btnResetScore.FlatAppearance.BorderSize = 0;
            btnResetScore.FlatStyle = FlatStyle.Popup;
            btnResetScore.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetScore.ForeColor = Color.BlanchedAlmond;
            btnResetScore.Image = null;
            btnResetScore.ImageSize = new Size(150, 40);
            btnResetScore.Location = new Point(119, 293);
            btnResetScore.Margin = new Padding(10);
            btnResetScore.Name = "btnResetScore";
            btnResetScore.Size = new Size(235, 50);
            btnResetScore.TabIndex = 0;
            btnResetScore.Text = "Reset Score";
            btnResetScore.UseVisualStyleBackColor = false;
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
            pblAppearance.Anchor = AnchorStyles.None;
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
            pblAppearance.Location = new Point(29, 505);
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
            dtpDateOfBirth.Margin = new Padding(25, 0, 25, 0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(283, 36);
            dtpDateOfBirth.TabIndex = 9;
            dtpDateOfBirth.CloseUp += dtpDateOfBirth_CloseUp;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Anchor = AnchorStyles.None;
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirth.ForeColor = Color.White;
            lblDateOfBirth.Location = new Point(25, 235);
            lblDateOfBirth.Margin = new Padding(0, 10, 0, 10);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(185, 34);
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
            lblDateOfBirthError.Location = new Point(119, 330);
            lblDateOfBirthError.Margin = new Padding(0, 15, 0, 15);
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
            lblGender.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(22, 81);
            lblGender.Margin = new Padding(0, 10, 0, 10);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(120, 34);
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
            lblGenderError.Location = new Point(119, 177);
            lblGenderError.Margin = new Padding(0, 15, 0, 15);
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
            cbGender.Location = new Point(22, 125);
            cbGender.Margin = new Padding(25, 0, 25, 0);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(286, 37);
            cbGender.TabIndex = 4;
            cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Bottom;
            lblUsername.AutoEllipsis = true;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(44, 430);
            lblUsername.Margin = new Padding(25);
            lblUsername.MaximumSize = new Size(300, 50);
            lblUsername.MinimumSize = new Size(300, 50);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(300, 50);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username is far too long fo this";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(975, 1466);
            Controls.Add(lblUsername);
            Controls.Add(pblAppearance);
            Controls.Add(pnlDangerZone);
            Controls.Add(pnlAccount);
            Controls.Add(pnlProfilePicture);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(975, 1500);
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
        private Custom_Controls.CustomButton btnProfilePicturePrevious;
        private Custom_Controls.CustomButton btnProfilePictureNext;
        private Panel pnlProfilePicture;
        private Custom_Controls.CustomRectangle pnlAccount;
        private Label lblAccountTitle;
        private Custom_Controls.CustomRectangle pnlDangerZone;
        private Label lblDetailsTitle;
        private Custom_Controls.CustomRectangle pblAppearance;
        private Label lblDangerZoneTitle;
        private Custom_Controls.CustomButton btnResetScore;
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
        private Custom_Controls.CustomButton btnDeleteAccount;
        private Label lblPasswordError;
        private Custom_Controls.CustomTextbox tbNewUsername;
        private Label lblDangerZoneDescription;
        private Custom_Controls.CustomButton btnDone;
        private Label lblUsernameDetail;
        private Label lblChangeUsernameTitle;
        private Custom_Controls.CustomButton btnChangeUsername;
        private Label lblUsername;
        private Label lblGender;
        private Label lblGenderError;
        private ComboBox cbGender;
        private DateTimePicker dtpDateOfBirth;
        private Label lblDateOfBirth;
        private Label lblDateOfBirthError;
        private Label lblChangeForename;
        private Custom_Controls.CustomTextbox tbNewForename;
        private Custom_Controls.CustomButton btnChangeForename;
        private Label lblChangeForenameError;
        private Label lblChangeEmailTitle;
        private Custom_Controls.CustomTextbox tbNewEmail;
        private Custom_Controls.CustomButton btnChangeEmail;
        private Label lblChangeEmailError;
        private Label lblChangeUsernameError;
        private Label lblChangeSurnameTitle;
        private Custom_Controls.CustomTextbox tbNewSurname;
        private Custom_Controls.CustomButton btnChangeSurname;
        private Label lblChangeSurnameError;
        private Label lblSurnameDetail;
        private Label lblForenameDetail;
        private Label lblEmailDetail;
    }
}