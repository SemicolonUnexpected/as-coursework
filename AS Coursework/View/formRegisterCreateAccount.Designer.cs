namespace AS_Coursework.View {
    partial class formRegisterCreateAccount {
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
            btnReturnToLogin = new Custom_Controls.CustomButton();
            lblCreateAccount = new Label();
            SuspendLayout();
            // 
            // btnReturnToLogin
            // 
            btnReturnToLogin.Anchor = AnchorStyles.None;
            btnReturnToLogin.BackColor = Color.FromArgb(0, 150, 255);
            btnReturnToLogin.BorderColor = Color.White;
            btnReturnToLogin.BorderWidth = 2;
            btnReturnToLogin.CornerRadius = 20;
            btnReturnToLogin.FlatAppearance.BorderSize = 0;
            btnReturnToLogin.FlatStyle = FlatStyle.Flat;
            btnReturnToLogin.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturnToLogin.ForeColor = Color.White;
            btnReturnToLogin.Location = new Point(111, 498);
            btnReturnToLogin.Margin = new Padding(28, 31, 28, 31);
            btnReturnToLogin.Name = "btnReturnToLogin";
            btnReturnToLogin.Size = new Size(244, 62);
            btnReturnToLogin.TabIndex = 2;
            btnReturnToLogin.Text = "Return to login";
            btnReturnToLogin.UseVisualStyleBackColor = false;
            btnReturnToLogin.Click += btnCreateAccount_Click;
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.Anchor = AnchorStyles.None;
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreateAccount.ForeColor = Color.White;
            lblCreateAccount.Location = new Point(29, 52);
            lblCreateAccount.MaximumSize = new Size(416, 0);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(375, 58);
            lblCreateAccount.TabIndex = 4;
            lblCreateAccount.Text = "Your account has been created. Return to the login screen to login";
            lblCreateAccount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formRegisterCreateAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(456, 600);
            Controls.Add(btnReturnToLogin);
            Controls.Add(lblCreateAccount);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formRegisterCreateAccount";
            Text = "RegisterCreateAccountView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom_Controls.CustomButton btnReturnToLogin;
        private Label lblCreateAccount;
    }
}