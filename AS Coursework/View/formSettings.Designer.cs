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
            pbUserProfile = new Custom_Controls.PictureFrame();
            btnLogin = new Custom_Controls.CustomButton();
            customButton1 = new Custom_Controls.CustomButton();
            panel1 = new Panel();
            pnlRank = new Custom_Controls.CustomRectangle();
            lblRankTitle = new Label();
            customRectangle1 = new Custom_Controls.CustomRectangle();
            label2 = new Label();
            customRectangle2 = new Custom_Controls.CustomRectangle();
            panel1.SuspendLayout();
            pnlRank.SuspendLayout();
            customRectangle1.SuspendLayout();
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
            pbUserProfile.Size = new Size(333, 333);
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
            btnLogin.Location = new Point(61, 350);
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
            customButton1.Location = new Point(211, 350);
            customButton1.Margin = new Padding(0);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(60, 60);
            customButton1.TabIndex = 3;
            customButton1.Tag = "";
            customButton1.Text = ">";
            customButton1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(pbUserProfile);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(customButton1);
            panel1.Location = new Point(29, 23);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 410);
            panel1.TabIndex = 4;
            // 
            // pnlRank
            // 
            pnlRank.Anchor = AnchorStyles.Top;
            pnlRank.BackColor = Color.FromArgb(30, 30, 70);
            pnlRank.BorderColor = Color.White;
            pnlRank.BorderWidth = 0;
            pnlRank.Controls.Add(lblRankTitle);
            pnlRank.CornerRadius = 20;
            pnlRank.Location = new Point(402, 23);
            pnlRank.Margin = new Padding(20);
            pnlRank.Name = "pnlRank";
            pnlRank.Size = new Size(544, 848);
            pnlRank.TabIndex = 5;
            pnlRank.Text = "customRectangle1";
            // 
            // lblRankTitle
            // 
            lblRankTitle.AutoEllipsis = true;
            lblRankTitle.AutoSize = true;
            lblRankTitle.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblRankTitle.ForeColor = Color.White;
            lblRankTitle.Location = new Point(25, 25);
            lblRankTitle.Margin = new Padding(25);
            lblRankTitle.Name = "lblRankTitle";
            lblRankTitle.Size = new Size(99, 43);
            lblRankTitle.TabIndex = 2;
            lblRankTitle.Text = "Rank";
            // 
            // customRectangle1
            // 
            customRectangle1.Anchor = AnchorStyles.Top;
            customRectangle1.BackColor = Color.FromArgb(30, 30, 70);
            customRectangle1.BorderColor = Color.White;
            customRectangle1.BorderWidth = 0;
            customRectangle1.Controls.Add(label2);
            customRectangle1.CornerRadius = 20;
            customRectangle1.Location = new Point(29, 911);
            customRectangle1.Margin = new Padding(20);
            customRectangle1.Name = "customRectangle1";
            customRectangle1.Size = new Size(917, 500);
            customRectangle1.TabIndex = 6;
            customRectangle1.Text = "customRectangle1";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 25);
            label2.Margin = new Padding(25);
            label2.Name = "label2";
            label2.Size = new Size(99, 43);
            label2.TabIndex = 2;
            label2.Text = "Rank";
            // 
            // customRectangle2
            // 
            customRectangle2.Anchor = AnchorStyles.Top;
            customRectangle2.BackColor = Color.FromArgb(30, 30, 70);
            customRectangle2.BorderColor = Color.White;
            customRectangle2.BorderWidth = 0;
            customRectangle2.CornerRadius = 20;
            customRectangle2.Location = new Point(29, 453);
            customRectangle2.Margin = new Padding(20);
            customRectangle2.Name = "customRectangle2";
            customRectangle2.Size = new Size(333, 418);
            customRectangle2.TabIndex = 6;
            customRectangle2.Text = "customRectangle1";
            // 
            // formSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(975, 1440);
            Controls.Add(customRectangle2);
            Controls.Add(customRectangle1);
            Controls.Add(pnlRank);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formSettings";
            Text = "formSettings";
            panel1.ResumeLayout(false);
            pnlRank.ResumeLayout(false);
            pnlRank.PerformLayout();
            customRectangle1.ResumeLayout(false);
            customRectangle1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Custom_Controls.PictureFrame pbUserProfile;
        private Custom_Controls.CustomButton btnLogin;
        private Custom_Controls.CustomButton customButton1;
        private Panel panel1;
        private Custom_Controls.CustomRectangle pnlRank;
        private Label lblRankTitle;
        private Custom_Controls.CustomRectangle customRectangle1;
        private Label label2;
        private Custom_Controls.CustomRectangle customRectangle2;
    }
}