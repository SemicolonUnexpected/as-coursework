namespace AS_Coursework.View {
    partial class RegisterCredentialsView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterCredentialsView));
            pnlPasswordStrength = new Panel();
            lblSpecialCharacters = new Label();
            lblLettersNumbers = new Label();
            lblPasswordLength = new Label();
            pbSpecialCharacters = new PictureBox();
            pbLettersNumbers = new PictureBox();
            pbPasswordLength = new PictureBox();
            lblPasswordError = new Label();
            lblUsernameError = new Label();
            lblConfirmPasswordError = new Label();
            btnBack = new Custom_Controls.CustomButton();
            tbConfirmPassword = new Custom_Controls.CustomTextbox();
            tbPassword = new Custom_Controls.CustomTextbox();
            pbPasswordView = new PictureBox();
            tbUsername = new Custom_Controls.CustomTextbox();
            btnDone = new Custom_Controls.CustomButton();
            pnlPasswordStrength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpecialCharacters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLettersNumbers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPasswordLength).BeginInit();
            tbPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPasswordView).BeginInit();
            SuspendLayout();
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
            pnlPasswordStrength.Location = new Point(45, 125);
            pnlPasswordStrength.Margin = new Padding(5);
            pnlPasswordStrength.Name = "pnlPasswordStrength";
            pnlPasswordStrength.Size = new Size(230, 109);
            pnlPasswordStrength.TabIndex = 1;
            // 
            // lblSpecialCharacters
            // 
            lblSpecialCharacters.Anchor = AnchorStyles.None;
            lblSpecialCharacters.AutoSize = true;
            lblSpecialCharacters.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpecialCharacters.ForeColor = Color.White;
            lblSpecialCharacters.Location = new Point(40, 82);
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
            lblLettersNumbers.AutoSize = true;
            lblLettersNumbers.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLettersNumbers.ForeColor = Color.White;
            lblLettersNumbers.Location = new Point(40, 44);
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
            lblPasswordLength.AutoSize = true;
            lblPasswordLength.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordLength.ForeColor = Color.White;
            lblPasswordLength.Location = new Point(40, 7);
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
            pbSpecialCharacters.Location = new Point(11, 81);
            pbSpecialCharacters.Margin = new Padding(4);
            pbSpecialCharacters.Name = "pbSpecialCharacters";
            pbSpecialCharacters.Size = new Size(20, 20);
            pbSpecialCharacters.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSpecialCharacters.TabIndex = 0;
            pbSpecialCharacters.TabStop = false;
            // 
            // pbLettersNumbers
            // 
            pbLettersNumbers.Anchor = AnchorStyles.None;
            pbLettersNumbers.Image = Resources.Icons.Icons.Red_Cross_Circle;
            pbLettersNumbers.Location = new Point(11, 44);
            pbLettersNumbers.Margin = new Padding(4);
            pbLettersNumbers.Name = "pbLettersNumbers";
            pbLettersNumbers.Size = new Size(20, 20);
            pbLettersNumbers.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLettersNumbers.TabIndex = 0;
            pbLettersNumbers.TabStop = false;
            // 
            // pbPasswordLength
            // 
            pbPasswordLength.Anchor = AnchorStyles.None;
            pbPasswordLength.Image = (Image)resources.GetObject("pbPasswordLength.Image");
            pbPasswordLength.Location = new Point(11, 8);
            pbPasswordLength.Margin = new Padding(4);
            pbPasswordLength.Name = "pbPasswordLength";
            pbPasswordLength.Size = new Size(20, 20);
            pbPasswordLength.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPasswordLength.TabIndex = 0;
            pbPasswordLength.TabStop = false;
            // 
            // lblPasswordError
            // 
            lblPasswordError.Anchor = AnchorStyles.None;
            lblPasswordError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(15, 244);
            lblPasswordError.Margin = new Padding(5);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(292, 19);
            lblPasswordError.TabIndex = 3;
            lblPasswordError.Text = "Error";
            lblPasswordError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsernameError
            // 
            lblUsernameError.Anchor = AnchorStyles.None;
            lblUsernameError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsernameError.ForeColor = Color.Red;
            lblUsernameError.Location = new Point(15, 55);
            lblUsernameError.Margin = new Padding(5);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(292, 19);
            lblUsernameError.TabIndex = 3;
            lblUsernameError.Text = "Error";
            lblUsernameError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfirmPasswordError
            // 
            lblConfirmPasswordError.Anchor = AnchorStyles.None;
            lblConfirmPasswordError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmPasswordError.ForeColor = Color.Red;
            lblConfirmPasswordError.Location = new Point(15, 314);
            lblConfirmPasswordError.Margin = new Padding(5);
            lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            lblConfirmPasswordError.Size = new Size(292, 19);
            lblConfirmPasswordError.TabIndex = 3;
            lblConfirmPasswordError.Text = "Error";
            lblConfirmPasswordError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(0, 150, 255);
            btnBack.BorderColor = Color.White;
            btnBack.BorderWidth = 2;
            btnBack.CornerRadius = 10;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Image = null;
            btnBack.ImageSize = new Size(150, 40);
            btnBack.Location = new Point(14, 356);
            btnBack.Margin = new Padding(5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 30);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Anchor = AnchorStyles.None;
            tbConfirmPassword.BackColor = Color.FromArgb(20, 20, 50);
            tbConfirmPassword.BorderColor = Color.White;
            tbConfirmPassword.BorderFocusColor = Color.White;
            tbConfirmPassword.BorderSize = 4;
            tbConfirmPassword.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbConfirmPassword.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbConfirmPassword.ForeColor = Color.White;
            tbConfirmPassword.IsMultiline = false;
            tbConfirmPassword.Location = new Point(45, 273);
            tbConfirmPassword.Margin = new Padding(5);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Padding = new Padding(6, 5, 6, 5);
            tbConfirmPassword.PlaceholderText = "Confirm password";
            tbConfirmPassword.PlaceholderTextColor = Color.White;
            tbConfirmPassword.ShortcutEnabled = true;
            tbConfirmPassword.Size = new Size(230, 30);
            tbConfirmPassword.TabIndex = 1;
            tbConfirmPassword.UsePasswordChar = true;
            tbConfirmPassword.Leave += tbConfirmPassword_Leave;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.None;
            tbPassword.BackColor = Color.FromArgb(20, 20, 50);
            tbPassword.BorderColor = Color.White;
            tbPassword.BorderFocusColor = Color.White;
            tbPassword.BorderSize = 4;
            tbPassword.Controls.Add(pbPasswordView);
            tbPassword.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbPassword.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.ForeColor = Color.White;
            tbPassword.IsMultiline = false;
            tbPassword.Location = new Point(45, 84);
            tbPassword.Margin = new Padding(5);
            tbPassword.Name = "tbPassword";
            tbPassword.Padding = new Padding(6, 5, 27, 5);
            tbPassword.PlaceholderText = "Password";
            tbPassword.PlaceholderTextColor = Color.White;
            tbPassword.ShortcutEnabled = true;
            tbPassword.Size = new Size(230, 30);
            tbPassword.TabIndex = 1;
            tbPassword.UsePasswordChar = true;
            tbPassword.TextChanged += tbPassword_TextChanged;
            tbPassword.Leave += tbPassword_Leave;
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
            pbPasswordView.MouseDown += pbPasswordView_MouseDown;
            pbPasswordView.MouseUp += pbPasswordView_MouseUp;
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.None;
            tbUsername.BackColor = Color.FromArgb(20, 20, 50);
            tbUsername.BorderColor = Color.White;
            tbUsername.BorderFocusColor = Color.White;
            tbUsername.BorderSize = 4;
            tbUsername.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbUsername.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.ForeColor = Color.White;
            tbUsername.IsMultiline = false;
            tbUsername.Location = new Point(45, 14);
            tbUsername.Margin = new Padding(5);
            tbUsername.Name = "tbUsername";
            tbUsername.Padding = new Padding(5);
            tbUsername.PlaceholderText = "Username";
            tbUsername.PlaceholderTextColor = Color.White;
            tbUsername.ShortcutEnabled = true;
            tbUsername.Size = new Size(230, 30);
            tbUsername.TabIndex = 1;
            tbUsername.UsePasswordChar = false;
            tbUsername.Leave += tbUsername_Leave;
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.None;
            btnDone.BackColor = Color.FromArgb(0, 150, 255);
            btnDone.BorderColor = Color.White;
            btnDone.BorderWidth = 2;
            btnDone.CornerRadius = 10;
            btnDone.FlatAppearance.BorderSize = 0;
            btnDone.FlatStyle = FlatStyle.Popup;
            btnDone.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDone.ForeColor = Color.BlanchedAlmond;
            btnDone.Image = null;
            btnDone.ImageSize = new Size(150, 40);
            btnDone.Location = new Point(236, 356);
            btnDone.Margin = new Padding(5);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(70, 30);
            btnDone.TabIndex = 0;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // RegisterCredentialsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(320, 400);
            Controls.Add(lblConfirmPasswordError);
            Controls.Add(lblPasswordError);
            Controls.Add(lblUsernameError);
            Controls.Add(btnBack);
            Controls.Add(pnlPasswordStrength);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(btnDone);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "RegisterCredentialsView";
            Text = "RegisterMisc";
            pnlPasswordStrength.ResumeLayout(false);
            pnlPasswordStrength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpecialCharacters).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLettersNumbers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPasswordLength).EndInit();
            tbPassword.ResumeLayout(false);
            tbPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPasswordView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Custom_Controls.CustomTextbox tbUsername;
        private Custom_Controls.CustomTextbox tbPassword;
        private Custom_Controls.CustomTextbox tbConfirmPassword;
        private Panel pnlPasswordStrength;
        private PictureBox pbLettersNumbers;
        private PictureBox pbPasswordLength;
        private PictureBox pbSpecialCharacters;
        private Label lblSpecialCharacters;
        private Label lblLettersNumbers;
        private Label lblPasswordLength;
        private Custom_Controls.CustomButton btnBack;
        private Custom_Controls.CustomButton btnDone;
        private PictureBox pbPasswordView;
        private Label lblPasswordError;
        private Label lblUsernameError;
        private Label lblConfirmPasswordError;
    }
}