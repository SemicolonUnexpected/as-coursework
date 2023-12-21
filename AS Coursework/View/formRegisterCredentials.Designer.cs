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
            pnlPasswordStrength.Location = new Point(61, 180);
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
            // lblPasswordError
            // 
            lblPasswordError.Anchor = AnchorStyles.None;
            lblPasswordError.AutoSize = true;
            lblPasswordError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(177, 368);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(70, 29);
            lblPasswordError.TabIndex = 3;
            lblPasswordError.Text = "Error";
            lblPasswordError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsernameError
            // 
            lblUsernameError.Anchor = AnchorStyles.None;
            lblUsernameError.AutoSize = true;
            lblUsernameError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsernameError.ForeColor = Color.Red;
            lblUsernameError.Location = new Point(177, 77);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(70, 29);
            lblUsernameError.TabIndex = 3;
            lblUsernameError.Text = "Error";
            lblUsernameError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfirmPasswordError
            // 
            lblConfirmPasswordError.Anchor = AnchorStyles.None;
            lblConfirmPasswordError.AutoSize = true;
            lblConfirmPasswordError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmPasswordError.ForeColor = Color.Red;
            lblConfirmPasswordError.Location = new Point(177, 474);
            lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            lblConfirmPasswordError.Size = new Size(70, 29);
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
            btnBack.CornerRadius = 20;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(19, 531);
            btnBack.Margin = new Padding(10);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 50);
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
            tbConfirmPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbConfirmPassword.ForeColor = Color.White;
            tbConfirmPassword.IsMultiline = false;
            tbConfirmPassword.Location = new Point(61, 407);
            tbConfirmPassword.Margin = new Padding(28, 31, 28, 31);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Padding = new Padding(8, 9, 8, 9);
            tbConfirmPassword.PlaceholderText = "Confirm password";
            tbConfirmPassword.PlaceholderTextColor = Color.White;
            tbConfirmPassword.ShortcutEnabled = true;
            tbConfirmPassword.Size = new Size(333, 48);
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
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.ForeColor = Color.White;
            tbPassword.IsMultiline = false;
            tbPassword.Location = new Point(61, 113);
            tbPassword.Margin = new Padding(28, 31, 28, 31);
            tbPassword.Name = "tbPassword";
            tbPassword.Padding = new Padding(8, 9, 39, 9);
            tbPassword.PlaceholderText = "Password";
            tbPassword.PlaceholderTextColor = Color.White;
            tbPassword.ShortcutEnabled = true;
            tbPassword.Size = new Size(333, 48);
            tbPassword.TabIndex = 1;
            tbPassword.UsePasswordChar = true;
            tbPassword.TextChanged += tbPassword_TextChanged;
            tbPassword.Leave += tbPassword_Leave;
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
            tbUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.ForeColor = Color.White;
            tbUsername.IsMultiline = false;
            tbUsername.Location = new Point(61, 21);
            tbUsername.Margin = new Padding(28, 31, 28, 31);
            tbUsername.Name = "tbUsername";
            tbUsername.Padding = new Padding(8, 9, 8, 9);
            tbUsername.PlaceholderText = "Username";
            tbUsername.PlaceholderTextColor = Color.White;
            tbUsername.ShortcutEnabled = true;
            tbUsername.Size = new Size(333, 48);
            tbUsername.TabIndex = 1;
            tbUsername.UsePasswordChar = false;
            tbUsername.Leave += tbUsername_Leave;
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
            btnDone.Location = new Point(337, 531);
            btnDone.Margin = new Padding(10);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(100, 50);
            btnDone.TabIndex = 0;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // RegisterCredentialsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(456, 600);
            Controls.Add(lblConfirmPasswordError);
            Controls.Add(lblUsernameError);
            Controls.Add(lblPasswordError);
            Controls.Add(btnBack);
            Controls.Add(pnlPasswordStrength);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(btnDone);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
            PerformLayout();
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