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
            btnResetStatistics = new Custom_Controls.CustomButton();
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
            btnChangePassword = new Custom_Controls.CustomButton();
            lblDetailsTitle = new Label();
            pnlDetails = new Custom_Controls.CustomRectangle();
            dtpDateOfBirth = new DateTimePicker();
            lblDateOfBirth = new Label();
            lblChangeDateOfBirthError = new Label();
            lblGender = new Label();
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
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pbUserProfile
            // 
            pbUserProfile.Anchor = AnchorStyles.Top;
            pbUserProfile.BorderColorOne = Color.FromArgb(0, 100, 255);
            pbUserProfile.BorderColorTwo = Color.FromArgb(50, 200, 255);
            pbUserProfile.BorderStyle = Custom_Controls.PictureFrame.BorderType.Circle;
            pbUserProfile.BorderWidth = 15;
            pbUserProfile.GradientAngle = 45;
            pbUserProfile.GradientRectangle = new Rectangle(0, 0, 222, 222);
            pbUserProfile.Image = Resources.Icons.Icons.User;
            pbUserProfile.ImagePortion = new Rectangle(-256, -256, 1024, 1024);
            pbUserProfile.Location = new Point(0, 0);
            pbUserProfile.Margin = new Padding(2);
            pbUserProfile.Name = "pbUserProfile";
            pbUserProfile.Size = new Size(222, 222);
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
            btnProfilePicturePrevious.Location = new Point(12, 221);
            btnProfilePicturePrevious.Margin = new Padding(12, 0, 12, 0);
            btnProfilePicturePrevious.Name = "btnProfilePicturePrevious";
            btnProfilePicturePrevious.Size = new Size(40, 40);
            btnProfilePicturePrevious.TabIndex = 3;
            btnProfilePicturePrevious.Text = "<";
            btnProfilePicturePrevious.UseVisualStyleBackColor = false;
            btnProfilePicturePrevious.Click += btnProfilePicturePrevious_Click;
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
            btnProfilePictureNext.Location = new Point(168, 221);
            btnProfilePictureNext.Margin = new Padding(12, 0, 12, 0);
            btnProfilePictureNext.Name = "btnProfilePictureNext";
            btnProfilePictureNext.Size = new Size(40, 40);
            btnProfilePictureNext.TabIndex = 3;
            btnProfilePictureNext.Tag = "";
            btnProfilePictureNext.Text = ">";
            btnProfilePictureNext.UseVisualStyleBackColor = false;
            btnProfilePictureNext.Click += btnProfilePictureNext_Click;
            // 
            // pnlProfilePicture
            // 
            pnlProfilePicture.Anchor = AnchorStyles.None;
            pnlProfilePicture.Controls.Add(pbUserProfile);
            pnlProfilePicture.Controls.Add(btnProfilePicturePrevious);
            pnlProfilePicture.Controls.Add(btnProfilePictureNext);
            pnlProfilePicture.Location = new Point(21, 11);
            pnlProfilePicture.Margin = new Padding(12);
            pnlProfilePicture.Name = "pnlProfilePicture";
            pnlProfilePicture.Size = new Size(222, 261);
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
            pnlAccount.Location = new Point(267, 11);
            pnlAccount.Margin = new Padding(12);
            pnlAccount.Name = "pnlAccount";
            pnlAccount.Size = new Size(362, 556);
            pnlAccount.TabIndex = 5;
            pnlAccount.Text = "customRectangle1";
            // 
            // lblChangeSurnameTitle
            // 
            lblChangeSurnameTitle.Anchor = AnchorStyles.Left;
            lblChangeSurnameTitle.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeSurnameTitle.ForeColor = Color.White;
            lblChangeSurnameTitle.Location = new Point(18, 429);
            lblChangeSurnameTitle.Margin = new Padding(18, 0, 18, 0);
            lblChangeSurnameTitle.Name = "lblChangeSurnameTitle";
            lblChangeSurnameTitle.Size = new Size(155, 23);
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
            tbNewSurname.Location = new Point(18, 458);
            tbNewSurname.Margin = new Padding(18, 0, 18, 0);
            tbNewSurname.Name = "tbNewSurname";
            tbNewSurname.Padding = new Padding(6, 5, 6, 5);
            tbNewSurname.PlaceholderText = "New surname";
            tbNewSurname.PlaceholderTextColor = Color.White;
            tbNewSurname.ShortcutEnabled = true;
            tbNewSurname.Size = new Size(241, 31);
            tbNewSurname.TabIndex = 15;
            tbNewSurname.UsePasswordChar = false;
            // 
            // btnChangeSurname
            // 
            btnChangeSurname.Anchor = AnchorStyles.Right;
            btnChangeSurname.BackColor = Color.FromArgb(0, 150, 255);
            btnChangeSurname.BorderColor = Color.White;
            btnChangeSurname.BorderWidth = 2;
            btnChangeSurname.CornerRadius = 10;
            btnChangeSurname.FlatAppearance.BorderSize = 0;
            btnChangeSurname.FlatStyle = FlatStyle.Popup;
            btnChangeSurname.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeSurname.ForeColor = Color.BlanchedAlmond;
            btnChangeSurname.Image = null;
            btnChangeSurname.ImageSize = new Size(150, 40);
            btnChangeSurname.Location = new Point(276, 462);
            btnChangeSurname.Margin = new Padding(18, 0, 18, 0);
            btnChangeSurname.Name = "btnChangeSurname";
            btnChangeSurname.Size = new Size(70, 30);
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
            lblChangeSurnameError.Location = new Point(160, 494);
            lblChangeSurnameError.Margin = new Padding(2, 0, 2, 0);
            lblChangeSurnameError.Name = "lblChangeSurnameError";
            lblChangeSurnameError.Size = new Size(49, 19);
            lblChangeSurnameError.TabIndex = 16;
            lblChangeSurnameError.Text = "Error";
            lblChangeSurnameError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChangeForename
            // 
            lblChangeForename.Anchor = AnchorStyles.Left;
            lblChangeForename.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeForename.ForeColor = Color.White;
            lblChangeForename.Location = new Point(18, 351);
            lblChangeForename.Margin = new Padding(18, 0, 18, 0);
            lblChangeForename.Name = "lblChangeForename";
            lblChangeForename.Size = new Size(160, 23);
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
            tbNewForename.Location = new Point(18, 374);
            tbNewForename.Margin = new Padding(18, 0, 18, 0);
            tbNewForename.Name = "tbNewForename";
            tbNewForename.Padding = new Padding(6, 5, 6, 5);
            tbNewForename.PlaceholderText = "New forename";
            tbNewForename.PlaceholderTextColor = Color.White;
            tbNewForename.ShortcutEnabled = true;
            tbNewForename.Size = new Size(241, 31);
            tbNewForename.TabIndex = 11;
            tbNewForename.UsePasswordChar = false;
            // 
            // btnChangeForename
            // 
            btnChangeForename.Anchor = AnchorStyles.Right;
            btnChangeForename.BackColor = Color.FromArgb(0, 150, 255);
            btnChangeForename.BorderColor = Color.White;
            btnChangeForename.BorderWidth = 2;
            btnChangeForename.CornerRadius = 10;
            btnChangeForename.FlatAppearance.BorderSize = 0;
            btnChangeForename.FlatStyle = FlatStyle.Popup;
            btnChangeForename.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeForename.ForeColor = Color.BlanchedAlmond;
            btnChangeForename.Image = null;
            btnChangeForename.ImageSize = new Size(150, 40);
            btnChangeForename.Location = new Point(276, 374);
            btnChangeForename.Margin = new Padding(18, 0, 18, 0);
            btnChangeForename.Name = "btnChangeForename";
            btnChangeForename.Size = new Size(70, 30);
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
            lblChangeForenameError.Location = new Point(160, 410);
            lblChangeForenameError.Margin = new Padding(2, 0, 2, 0);
            lblChangeForenameError.Name = "lblChangeForenameError";
            lblChangeForenameError.Size = new Size(49, 19);
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
            lblAccountTitle.Location = new Point(14, 12);
            lblAccountTitle.Margin = new Padding(14, 12, 14, 12);
            lblAccountTitle.Name = "lblAccountTitle";
            lblAccountTitle.Size = new Size(100, 29);
            lblAccountTitle.TabIndex = 2;
            lblAccountTitle.Text = "Account";
            // 
            // lblChangeEmailTitle
            // 
            lblChangeEmailTitle.Anchor = AnchorStyles.Left;
            lblChangeEmailTitle.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeEmailTitle.ForeColor = Color.White;
            lblChangeEmailTitle.Location = new Point(18, 261);
            lblChangeEmailTitle.Margin = new Padding(18, 0, 18, 0);
            lblChangeEmailTitle.Name = "lblChangeEmailTitle";
            lblChangeEmailTitle.Size = new Size(126, 23);
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
            tbNewEmail.Location = new Point(18, 290);
            tbNewEmail.Margin = new Padding(18, 0, 18, 0);
            tbNewEmail.Name = "tbNewEmail";
            tbNewEmail.Padding = new Padding(6, 5, 6, 5);
            tbNewEmail.PlaceholderText = "New email";
            tbNewEmail.PlaceholderTextColor = Color.White;
            tbNewEmail.ShortcutEnabled = true;
            tbNewEmail.Size = new Size(241, 31);
            tbNewEmail.TabIndex = 1;
            tbNewEmail.UsePasswordChar = false;
            // 
            // lblSurnameDetail
            // 
            lblSurnameDetail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSurnameDetail.AutoEllipsis = true;
            lblSurnameDetail.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSurnameDetail.ForeColor = Color.White;
            lblSurnameDetail.Location = new Point(16, 138);
            lblSurnameDetail.Margin = new Padding(12, 4, 12, 4);
            lblSurnameDetail.Name = "lblSurnameDetail";
            lblSurnameDetail.Size = new Size(332, 20);
            lblSurnameDetail.TabIndex = 1;
            lblSurnameDetail.Text = "Surname :";
            lblSurnameDetail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblForenameDetail
            // 
            lblForenameDetail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblForenameDetail.AutoEllipsis = true;
            lblForenameDetail.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblForenameDetail.ForeColor = Color.White;
            lblForenameDetail.Location = new Point(14, 110);
            lblForenameDetail.Margin = new Padding(12, 4, 12, 4);
            lblForenameDetail.Name = "lblForenameDetail";
            lblForenameDetail.Size = new Size(332, 20);
            lblForenameDetail.TabIndex = 1;
            lblForenameDetail.Text = "Forename :";
            lblForenameDetail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmailDetail
            // 
            lblEmailDetail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblEmailDetail.AutoEllipsis = true;
            lblEmailDetail.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailDetail.ForeColor = Color.White;
            lblEmailDetail.Location = new Point(16, 82);
            lblEmailDetail.Margin = new Padding(12, 4, 12, 4);
            lblEmailDetail.Name = "lblEmailDetail";
            lblEmailDetail.Size = new Size(332, 20);
            lblEmailDetail.TabIndex = 1;
            lblEmailDetail.Text = "Email : ";
            lblEmailDetail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsernameDetail
            // 
            lblUsernameDetail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUsernameDetail.AutoEllipsis = true;
            lblUsernameDetail.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsernameDetail.ForeColor = Color.White;
            lblUsernameDetail.Location = new Point(16, 54);
            lblUsernameDetail.Margin = new Padding(12, 4, 12, 4);
            lblUsernameDetail.Name = "lblUsernameDetail";
            lblUsernameDetail.Size = new Size(334, 20);
            lblUsernameDetail.TabIndex = 1;
            lblUsernameDetail.Text = "Username : ";
            lblUsernameDetail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChangeUsernameTitle
            // 
            lblChangeUsernameTitle.Anchor = AnchorStyles.Left;
            lblChangeUsernameTitle.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeUsernameTitle.ForeColor = Color.White;
            lblChangeUsernameTitle.Location = new Point(18, 183);
            lblChangeUsernameTitle.Margin = new Padding(18, 0, 18, 0);
            lblChangeUsernameTitle.Name = "lblChangeUsernameTitle";
            lblChangeUsernameTitle.Size = new Size(165, 23);
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
            btnChangeEmail.CornerRadius = 10;
            btnChangeEmail.FlatAppearance.BorderSize = 0;
            btnChangeEmail.FlatStyle = FlatStyle.Popup;
            btnChangeEmail.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeEmail.ForeColor = Color.BlanchedAlmond;
            btnChangeEmail.Image = null;
            btnChangeEmail.ImageSize = new Size(150, 40);
            btnChangeEmail.Location = new Point(278, 290);
            btnChangeEmail.Margin = new Padding(18, 0, 18, 0);
            btnChangeEmail.Name = "btnChangeEmail";
            btnChangeEmail.Size = new Size(70, 30);
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
            tbNewUsername.Location = new Point(18, 206);
            tbNewUsername.Margin = new Padding(18, 0, 18, 0);
            tbNewUsername.Name = "tbNewUsername";
            tbNewUsername.Padding = new Padding(6, 5, 6, 5);
            tbNewUsername.PlaceholderText = "New username";
            tbNewUsername.PlaceholderTextColor = Color.White;
            tbNewUsername.ShortcutEnabled = true;
            tbNewUsername.Size = new Size(241, 31);
            tbNewUsername.TabIndex = 1;
            tbNewUsername.UsePasswordChar = false;
            // 
            // lblChangeEmailError
            // 
            lblChangeEmailError.Anchor = AnchorStyles.None;
            lblChangeEmailError.AutoSize = true;
            lblChangeEmailError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeEmailError.ForeColor = Color.Red;
            lblChangeEmailError.Location = new Point(160, 332);
            lblChangeEmailError.Margin = new Padding(2, 0, 2, 0);
            lblChangeEmailError.Name = "lblChangeEmailError";
            lblChangeEmailError.Size = new Size(49, 19);
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
            btnChangeUsername.CornerRadius = 10;
            btnChangeUsername.FlatAppearance.BorderSize = 0;
            btnChangeUsername.FlatStyle = FlatStyle.Popup;
            btnChangeUsername.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeUsername.ForeColor = Color.BlanchedAlmond;
            btnChangeUsername.Image = null;
            btnChangeUsername.ImageSize = new Size(150, 40);
            btnChangeUsername.Location = new Point(276, 207);
            btnChangeUsername.Margin = new Padding(18, 0, 18, 0);
            btnChangeUsername.Name = "btnChangeUsername";
            btnChangeUsername.Size = new Size(70, 30);
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
            lblChangeUsernameError.Location = new Point(157, 242);
            lblChangeUsernameError.Margin = new Padding(2, 0, 2, 0);
            lblChangeUsernameError.Name = "lblChangeUsernameError";
            lblChangeUsernameError.Size = new Size(49, 19);
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
            pnlDangerZone.Controls.Add(btnResetStatistics);
            pnlDangerZone.Controls.Add(tbNewPassword);
            pnlDangerZone.Controls.Add(tbConfirmPassword);
            pnlDangerZone.Controls.Add(pnlPasswordStrength);
            pnlDangerZone.Controls.Add(btnChangePassword);
            pnlDangerZone.CornerRadius = 20;
            pnlDangerZone.Location = new Point(21, 591);
            pnlDangerZone.Margin = new Padding(12);
            pnlDangerZone.Name = "pnlDangerZone";
            pnlDangerZone.Size = new Size(608, 308);
            pnlDangerZone.TabIndex = 6;
            pnlDangerZone.Text = "customRectangle1";
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.FromArgb(0, 150, 255);
            btnDeleteAccount.BorderColor = Color.White;
            btnDeleteAccount.BorderWidth = 2;
            btnDeleteAccount.CornerRadius = 10;
            btnDeleteAccount.FlatAppearance.BorderSize = 0;
            btnDeleteAccount.FlatStyle = FlatStyle.Popup;
            btnDeleteAccount.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteAccount.ForeColor = Color.BlanchedAlmond;
            btnDeleteAccount.Image = null;
            btnDeleteAccount.ImageSize = new Size(150, 40);
            btnDeleteAccount.Location = new Point(84, 227);
            btnDeleteAccount.Margin = new Padding(7, 6, 7, 6);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(178, 30);
            btnDeleteAccount.TabIndex = 4;
            btnDeleteAccount.Text = "Delete account";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // lblConfirmPasswordError
            // 
            lblConfirmPasswordError.Anchor = AnchorStyles.None;
            lblConfirmPasswordError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmPasswordError.ForeColor = Color.Red;
            lblConfirmPasswordError.Location = new Point(344, 247);
            lblConfirmPasswordError.Margin = new Padding(2, 0, 2, 0);
            lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            lblConfirmPasswordError.Size = new Size(250, 19);
            lblConfirmPasswordError.TabIndex = 3;
            lblConfirmPasswordError.Text = "Error";
            lblConfirmPasswordError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDangerZoneDescription
            // 
            lblDangerZoneDescription.Anchor = AnchorStyles.None;
            lblDangerZoneDescription.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDangerZoneDescription.ForeColor = Color.White;
            lblDangerZoneDescription.Location = new Point(12, 53);
            lblDangerZoneDescription.Margin = new Padding(2, 0, 2, 0);
            lblDangerZoneDescription.Name = "lblDangerZoneDescription";
            lblDangerZoneDescription.Size = new Size(306, 95);
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
            lblDangerZoneTitle.Location = new Point(14, 12);
            lblDangerZoneTitle.Margin = new Padding(14, 12, 14, 12);
            lblDangerZoneTitle.Name = "lblDangerZoneTitle";
            lblDangerZoneTitle.Size = new Size(149, 29);
            lblDangerZoneTitle.TabIndex = 2;
            lblDangerZoneTitle.Text = "Danger Zone";
            // 
            // lblPasswordError
            // 
            lblPasswordError.Anchor = AnchorStyles.None;
            lblPasswordError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(344, 181);
            lblPasswordError.Margin = new Padding(2, 0, 2, 0);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(250, 19);
            lblPasswordError.TabIndex = 3;
            lblPasswordError.Text = "Error";
            lblPasswordError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnResetStatistics
            // 
            btnResetStatistics.BackColor = Color.FromArgb(0, 150, 255);
            btnResetStatistics.BorderColor = Color.White;
            btnResetStatistics.BorderWidth = 2;
            btnResetStatistics.CornerRadius = 10;
            btnResetStatistics.FlatAppearance.BorderSize = 0;
            btnResetStatistics.FlatStyle = FlatStyle.Popup;
            btnResetStatistics.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetStatistics.ForeColor = Color.BlanchedAlmond;
            btnResetStatistics.Image = null;
            btnResetStatistics.ImageSize = new Size(150, 40);
            btnResetStatistics.Location = new Point(84, 170);
            btnResetStatistics.Margin = new Padding(7, 6, 7, 6);
            btnResetStatistics.Name = "btnResetStatistics";
            btnResetStatistics.Size = new Size(178, 30);
            btnResetStatistics.TabIndex = 0;
            btnResetStatistics.Text = "Reset statistics";
            btnResetStatistics.UseVisualStyleBackColor = false;
            btnResetStatistics.Click += btnReset_Click;
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
            tbNewPassword.Location = new Point(355, 19);
            tbNewPassword.Margin = new Padding(20, 19, 20, 19);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Padding = new Padding(6, 5, 27, 5);
            tbNewPassword.PlaceholderText = "New password";
            tbNewPassword.PlaceholderTextColor = Color.White;
            tbNewPassword.ShortcutEnabled = true;
            tbNewPassword.Size = new Size(233, 31);
            tbNewPassword.TabIndex = 1;
            tbNewPassword.UsePasswordChar = true;
            tbNewPassword.TextChanged += tbNewPassword_TextChanged;
            // 
            // pbPasswordView
            // 
            pbPasswordView.Image = Resources.Icons.Icons.Eye;
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
            tbConfirmPassword.Location = new Point(356, 212);
            tbConfirmPassword.Margin = new Padding(20, 19, 20, 19);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Padding = new Padding(6, 5, 6, 5);
            tbConfirmPassword.PlaceholderText = "Confirm password";
            tbConfirmPassword.PlaceholderTextColor = Color.White;
            tbConfirmPassword.ShortcutEnabled = true;
            tbConfirmPassword.Size = new Size(233, 31);
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
            pnlPasswordStrength.Location = new Point(355, 69);
            pnlPasswordStrength.Margin = new Padding(20, 0, 20, 0);
            pnlPasswordStrength.Name = "pnlPasswordStrength";
            pnlPasswordStrength.Size = new Size(233, 109);
            pnlPasswordStrength.TabIndex = 1;
            // 
            // lblSpecialCharacters
            // 
            lblSpecialCharacters.Anchor = AnchorStyles.None;
            lblSpecialCharacters.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpecialCharacters.ForeColor = Color.White;
            lblSpecialCharacters.Location = new Point(41, 82);
            lblSpecialCharacters.Margin = new Padding(2, 0, 2, 0);
            lblSpecialCharacters.Name = "lblSpecialCharacters";
            lblSpecialCharacters.Size = new Size(146, 19);
            lblSpecialCharacters.TabIndex = 1;
            lblSpecialCharacters.Text = "Special characters";
            lblSpecialCharacters.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLettersNumbers
            // 
            lblLettersNumbers.Anchor = AnchorStyles.None;
            lblLettersNumbers.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLettersNumbers.ForeColor = Color.White;
            lblLettersNumbers.Location = new Point(41, 44);
            lblLettersNumbers.Margin = new Padding(2, 0, 2, 0);
            lblLettersNumbers.Name = "lblLettersNumbers";
            lblLettersNumbers.Size = new Size(161, 19);
            lblLettersNumbers.TabIndex = 1;
            lblLettersNumbers.Text = "Letters and numbers";
            lblLettersNumbers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPasswordLength
            // 
            lblPasswordLength.Anchor = AnchorStyles.None;
            lblPasswordLength.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordLength.ForeColor = Color.White;
            lblPasswordLength.Location = new Point(41, 7);
            lblPasswordLength.Margin = new Padding(2, 0, 2, 0);
            lblPasswordLength.Name = "lblPasswordLength";
            lblPasswordLength.Size = new Size(165, 19);
            lblPasswordLength.TabIndex = 1;
            lblPasswordLength.Text = "Eight characters long";
            lblPasswordLength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbSpecialCharacters
            // 
            pbSpecialCharacters.Anchor = AnchorStyles.None;
            pbSpecialCharacters.Image = (Image)resources.GetObject("pbSpecialCharacters.Image");
            pbSpecialCharacters.Location = new Point(12, 81);
            pbSpecialCharacters.Margin = new Padding(4);
            pbSpecialCharacters.Name = "pbSpecialCharacters";
            pbSpecialCharacters.Size = new Size(24, 21);
            pbSpecialCharacters.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSpecialCharacters.TabIndex = 0;
            pbSpecialCharacters.TabStop = false;
            // 
            // pbLettersNumbers
            // 
            pbLettersNumbers.Anchor = AnchorStyles.None;
            pbLettersNumbers.Image = Resources.Icons.Icons.Red_Cross_Circle;
            pbLettersNumbers.Location = new Point(12, 44);
            pbLettersNumbers.Margin = new Padding(4);
            pbLettersNumbers.Name = "pbLettersNumbers";
            pbLettersNumbers.Size = new Size(24, 21);
            pbLettersNumbers.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLettersNumbers.TabIndex = 0;
            pbLettersNumbers.TabStop = false;
            // 
            // pbPasswordLength
            // 
            pbPasswordLength.Anchor = AnchorStyles.None;
            pbPasswordLength.Image = (Image)resources.GetObject("pbPasswordLength.Image");
            pbPasswordLength.Location = new Point(12, 8);
            pbPasswordLength.Margin = new Padding(4);
            pbPasswordLength.Name = "pbPasswordLength";
            pbPasswordLength.Size = new Size(24, 21);
            pbPasswordLength.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPasswordLength.TabIndex = 0;
            pbPasswordLength.TabStop = false;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(0, 150, 255);
            btnChangePassword.BorderColor = Color.White;
            btnChangePassword.BorderWidth = 2;
            btnChangePassword.CornerRadius = 10;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Popup;
            btnChangePassword.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangePassword.ForeColor = Color.BlanchedAlmond;
            btnChangePassword.Image = null;
            btnChangePassword.ImageSize = new Size(150, 40);
            btnChangePassword.Location = new Point(524, 266);
            btnChangePassword.Margin = new Padding(14, 12, 14, 12);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(70, 30);
            btnChangePassword.TabIndex = 0;
            btnChangePassword.Text = "Done";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // lblDetailsTitle
            // 
            lblDetailsTitle.AutoEllipsis = true;
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDetailsTitle.ForeColor = Color.White;
            lblDetailsTitle.Location = new Point(14, 12);
            lblDetailsTitle.Margin = new Padding(14, 12, 14, 12);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new Size(88, 29);
            lblDetailsTitle.TabIndex = 2;
            lblDetailsTitle.Text = "Details";
            // 
            // pnlDetails
            // 
            pnlDetails.Anchor = AnchorStyles.None;
            pnlDetails.BackColor = Color.FromArgb(30, 30, 70);
            pnlDetails.BorderColor = Color.White;
            pnlDetails.BorderWidth = 0;
            pnlDetails.Controls.Add(dtpDateOfBirth);
            pnlDetails.Controls.Add(lblDateOfBirth);
            pnlDetails.Controls.Add(lblChangeDateOfBirthError);
            pnlDetails.Controls.Add(lblGender);
            pnlDetails.Controls.Add(cbGender);
            pnlDetails.Controls.Add(lblDetailsTitle);
            pnlDetails.CornerRadius = 20;
            pnlDetails.Location = new Point(21, 332);
            pnlDetails.Margin = new Padding(12);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(223, 235);
            pnlDetails.TabIndex = 6;
            pnlDetails.Text = "customRectangle1";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.None;
            dtpDateOfBirth.CalendarFont = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateOfBirth.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(14, 156);
            dtpDateOfBirth.Margin = new Padding(18, 0, 18, 0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(187, 27);
            dtpDateOfBirth.TabIndex = 9;
            dtpDateOfBirth.CloseUp += dtpDateOfBirth_CloseUp;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Anchor = AnchorStyles.None;
            lblDateOfBirth.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirth.ForeColor = Color.White;
            lblDateOfBirth.Location = new Point(18, 127);
            lblDateOfBirth.Margin = new Padding(0, 6, 0, 6);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(123, 23);
            lblDateOfBirth.TabIndex = 10;
            lblDateOfBirth.Text = "Date of birth :";
            lblDateOfBirth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChangeDateOfBirthError
            // 
            lblChangeDateOfBirthError.Anchor = AnchorStyles.None;
            lblChangeDateOfBirthError.AutoSize = true;
            lblChangeDateOfBirthError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeDateOfBirthError.ForeColor = Color.Red;
            lblChangeDateOfBirthError.Location = new Point(74, 192);
            lblChangeDateOfBirthError.Margin = new Padding(0, 9, 0, 9);
            lblChangeDateOfBirthError.Name = "lblChangeDateOfBirthError";
            lblChangeDateOfBirthError.Size = new Size(49, 19);
            lblChangeDateOfBirthError.TabIndex = 11;
            lblChangeDateOfBirthError.Text = "Error";
            lblChangeDateOfBirthError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.None;
            lblGender.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(18, 49);
            lblGender.Margin = new Padding(0, 6, 0, 6);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(80, 23);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender :";
            lblGender.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(14, 78);
            cbGender.Margin = new Padding(18, 0, 18, 0);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(187, 27);
            cbGender.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoEllipsis = true;
            lblUsername.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(27, 287);
            lblUsername.Margin = new Padding(18, 15, 18, 15);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(210, 30);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username is far too long fo this";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(650, 920);
            Controls.Add(lblUsername);
            Controls.Add(pnlDetails);
            Controls.Add(pnlDangerZone);
            Controls.Add(pnlAccount);
            Controls.Add(pnlProfilePicture);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)pbSpecialCharacters).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLettersNumbers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPasswordLength).EndInit();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ResumeLayout(false);
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
        private Custom_Controls.CustomRectangle pnlDetails;
        private Label lblDangerZoneTitle;
        private Custom_Controls.CustomButton btnResetStatistics;
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
        private Custom_Controls.CustomButton btnChangePassword;
        private Label lblUsernameDetail;
        private Label lblChangeUsernameTitle;
        private Custom_Controls.CustomButton btnChangeUsername;
        private Label lblUsername;
        private Label lblGender;
        private ComboBox cbGender;
        private DateTimePicker dtpDateOfBirth;
        private Label lblDateOfBirth;
        private Label lblChangeDateOfBirthError;
        private Label lblChangeForename;
        private Custom_Controls.CustomTextbox tbNewForename;
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
        private Custom_Controls.CustomButton btnChangeForename;
    }
}