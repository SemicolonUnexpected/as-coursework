namespace AS_Coursework.View {
    partial class formLogin {
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
            pnlLeft = new Panel();
            btnLogin = new Custom_Controls.CustomButton();
            lblError = new Label();
            lblRegister = new Label();
            lblLoginTitle = new Label();
            tbPassword = new Custom_Controls.CustomTextbox();
            pbPasswordView = new PictureBox();
            tbUsername = new Custom_Controls.CustomTextbox();
            pnlLeftGradOne = new Panel();
            pnlLeftGradTwo = new Panel();
            pnlWelcomeTitle = new Panel();
            lblWelcome = new Label();
            pnlDivider = new Panel();
            lblQuizName = new Label();
            pbBackground = new Custom_Controls.PicturePanel();
            pnlLeft.SuspendLayout();
            tbPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPasswordView).BeginInit();
            pnlWelcomeTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(20, 20, 50);
            pnlLeft.Controls.Add(btnLogin);
            pnlLeft.Controls.Add(lblError);
            pnlLeft.Controls.Add(lblRegister);
            pnlLeft.Controls.Add(lblLoginTitle);
            pnlLeft.Controls.Add(tbPassword);
            pnlLeft.Controls.Add(tbUsername);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(2, 3, 2, 3);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(308, 650);
            pnlLeft.TabIndex = 0;
            pnlLeft.TabStop = true;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(0, 150, 255);
            btnLogin.BorderColor = Color.White;
            btnLogin.BorderWidth = 2;
            btnLogin.CornerRadius = 15;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Image = null;
            btnLogin.ImageSize = new Size(150, 40);
            btnLogin.Location = new Point(112, 352);
            btnLogin.Margin = new Padding(19, 21, 19, 21);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 40);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.AutoSize = true;
            lblError.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(21, 419);
            lblError.Margin = new Padding(2, 0, 2, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 19);
            lblError.TabIndex = 0;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRegister
            // 
            lblRegister.Anchor = AnchorStyles.None;
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegister.ForeColor = Color.White;
            lblRegister.Location = new Point(21, 478);
            lblRegister.Margin = new Padding(2, 0, 2, 0);
            lblRegister.MaximumSize = new Size(277, 0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(252, 57);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Don't have an account? Click here and register now\r\n\r\n";
            lblRegister.TextAlign = ContentAlignment.MiddleCenter;
            lblRegister.Click += lblRegister_Click;
            lblRegister.MouseEnter += lblRegister_MouseEnter;
            lblRegister.MouseLeave += lblRegister_MouseLeave;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.Anchor = AnchorStyles.None;
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginTitle.ForeColor = Color.White;
            lblLoginTitle.Location = new Point(99, 95);
            lblLoginTitle.Margin = new Padding(2, 0, 2, 0);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(82, 33);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Login";
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
            tbPassword.Location = new Point(43, 279);
            tbPassword.Margin = new Padding(19, 21, 19, 21);
            tbPassword.Name = "tbPassword";
            tbPassword.Padding = new Padding(5, 6, 26, 6);
            tbPassword.PlaceholderText = "Password";
            tbPassword.PlaceholderTextColor = Color.White;
            tbPassword.ShortcutEnabled = false;
            tbPassword.Size = new Size(222, 33);
            tbPassword.TabIndex = 2;
            tbPassword.UsePasswordChar = true;
            tbPassword.KeyDown += tbPassword_KeyDown;
            // 
            // pbPasswordView
            // 
            pbPasswordView.Anchor = AnchorStyles.None;
            pbPasswordView.Image = Resources.Icons.Icons.Eye;
            pbPasswordView.Location = new Point(300, 8);
            pbPasswordView.Name = "pbPasswordView";
            pbPasswordView.Size = new Size(30, 30);
            pbPasswordView.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPasswordView.TabIndex = 1;
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
            tbUsername.Location = new Point(43, 200);
            tbUsername.Margin = new Padding(19, 21, 19, 21);
            tbUsername.Name = "tbUsername";
            tbUsername.Padding = new Padding(5, 6, 5, 6);
            tbUsername.PlaceholderText = "Username";
            tbUsername.PlaceholderTextColor = Color.White;
            tbUsername.ShortcutEnabled = false;
            tbUsername.Size = new Size(222, 33);
            tbUsername.TabIndex = 1;
            tbUsername.UsePasswordChar = false;
            // 
            // pnlLeftGradOne
            // 
            pnlLeftGradOne.BackColor = Color.FromArgb(30, 30, 70);
            pnlLeftGradOne.Dock = DockStyle.Left;
            pnlLeftGradOne.Location = new Point(308, 0);
            pnlLeftGradOne.Margin = new Padding(2, 3, 2, 3);
            pnlLeftGradOne.Name = "pnlLeftGradOne";
            pnlLeftGradOne.Size = new Size(22, 650);
            pnlLeftGradOne.TabIndex = 0;
            // 
            // pnlLeftGradTwo
            // 
            pnlLeftGradTwo.BackColor = Color.FromArgb(40, 40, 90);
            pnlLeftGradTwo.Dock = DockStyle.Left;
            pnlLeftGradTwo.Location = new Point(330, 0);
            pnlLeftGradTwo.Margin = new Padding(2, 3, 2, 3);
            pnlLeftGradTwo.Name = "pnlLeftGradTwo";
            pnlLeftGradTwo.Size = new Size(22, 650);
            pnlLeftGradTwo.TabIndex = 0;
            // 
            // pnlWelcomeTitle
            // 
            pnlWelcomeTitle.Anchor = AnchorStyles.None;
            pnlWelcomeTitle.BackColor = Color.Transparent;
            pnlWelcomeTitle.Controls.Add(lblWelcome);
            pnlWelcomeTitle.Controls.Add(pnlDivider);
            pnlWelcomeTitle.Controls.Add(lblQuizName);
            pnlWelcomeTitle.Location = new Point(167, 30);
            pnlWelcomeTitle.Name = "pnlWelcomeTitle";
            pnlWelcomeTitle.Size = new Size(226, 137);
            pnlWelcomeTitle.TabIndex = 5;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(5, 74);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(124, 33);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome";
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.White;
            pnlDivider.Location = new Point(13, 64);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(200, 7);
            pnlDivider.TabIndex = 4;
            // 
            // lblQuizName
            // 
            lblQuizName.AutoSize = true;
            lblQuizName.BackColor = Color.Transparent;
            lblQuizName.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuizName.ForeColor = Color.White;
            lblQuizName.Location = new Point(5, 13);
            lblQuizName.Name = "lblQuizName";
            lblQuizName.Size = new Size(144, 33);
            lblQuizName.TabIndex = 3;
            lblQuizName.Text = "Chem Quiz";
            // 
            // pbBackground
            // 
            pbBackground.Dock = DockStyle.Fill;
            pbBackground.Image = Resources.Images.Images.Flasks_close_up;
            pbBackground.ImagePortion = new Rectangle(1380, 0, 972, 1440);
            pbBackground.Location = new Point(352, 0);
            pbBackground.Margin = new Padding(2, 3, 2, 3);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(468, 650);
            pbBackground.TabIndex = 0;
            pbBackground.TabStop = false;
            pbBackground.Text = "customPictureBox1";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 150, 255);
            ClientSize = new Size(820, 650);
            Controls.Add(pbBackground);
            Controls.Add(pnlLeftGradTwo);
            Controls.Add(pnlLeftGradOne);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "formLogin";
            Text = "LoginView";
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            tbPassword.ResumeLayout(false);
            tbPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPasswordView).EndInit();
            pnlWelcomeTitle.ResumeLayout(false);
            pnlWelcomeTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlLeftGradOne;
        private Panel pnlLeftGradTwo;
        private Custom_Controls.CustomTextbox tbUsername;
        private Custom_Controls.CustomTextbox tbPassword;
        private Label lblLoginTitle;
        private Label lblRegister;
        private PictureBox pbPasswordView;
        private Custom_Controls.CustomButton btnLogin;
        private Panel pnlWelcomeTitle;
        private Label lblWelcome;
        private Panel pnlDivider;
        private Label lblQuizName;
        private Label lblError;
        private Custom_Controls.PicturePanel pbBackground;
    }
}