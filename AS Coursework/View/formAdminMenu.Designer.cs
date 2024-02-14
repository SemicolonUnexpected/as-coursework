namespace AS_Coursework.View {
    partial class formAdminMenu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdminMenu));
            lblAdminInfo = new Label();
            clbUserSelector = new CheckedListBox();
            btnViewUser = new Custom_Controls.CustomButton();
            tbNewUsername = new Custom_Controls.CustomTextbox();
            btnSearch = new Custom_Controls.CustomButton();
            SuspendLayout();
            // 
            // lblAdminInfo
            // 
            lblAdminInfo.Anchor = AnchorStyles.None;
            lblAdminInfo.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdminInfo.ForeColor = Color.White;
            lblAdminInfo.Location = new Point(11, 9);
            lblAdminInfo.Margin = new Padding(2, 0, 2, 0);
            lblAdminInfo.Name = "lblAdminInfo";
            lblAdminInfo.Size = new Size(628, 152);
            lblAdminInfo.TabIndex = 0;
            lblAdminInfo.Text = resources.GetString("lblAdminInfo.Text");
            lblAdminInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clbUserSelector
            // 
            clbUserSelector.Anchor = AnchorStyles.None;
            clbUserSelector.BorderStyle = BorderStyle.None;
            clbUserSelector.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            clbUserSelector.FormattingEnabled = true;
            clbUserSelector.Items.AddRange(new object[] { "0", "11", "12", "4", "5", "6", "7", "8", "9", "Test ", "Test2", "Test3" });
            clbUserSelector.Location = new Point(80, 224);
            clbUserSelector.Name = "clbUserSelector";
            clbUserSelector.Size = new Size(500, 275);
            clbUserSelector.TabIndex = 3;
            clbUserSelector.ItemCheck += clbUserSelector_ItemCheck;
            // 
            // btnViewUser
            // 
            btnViewUser.Anchor = AnchorStyles.None;
            btnViewUser.BackColor = Color.FromArgb(0, 150, 255);
            btnViewUser.BorderColor = Color.White;
            btnViewUser.BorderWidth = 2;
            btnViewUser.CornerRadius = 15;
            btnViewUser.FlatAppearance.BorderSize = 0;
            btnViewUser.FlatStyle = FlatStyle.Flat;
            btnViewUser.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewUser.ForeColor = Color.White;
            btnViewUser.Image = null;
            btnViewUser.ImageSize = new Size(150, 40);
            btnViewUser.Location = new Point(455, 511);
            btnViewUser.Margin = new Padding(5);
            btnViewUser.Name = "btnViewUser";
            btnViewUser.Size = new Size(125, 40);
            btnViewUser.TabIndex = 4;
            btnViewUser.Text = "View user";
            btnViewUser.UseVisualStyleBackColor = false;
            btnViewUser.Click += btnViewUser_Click;
            // 
            // tbNewUsername
            // 
            tbNewUsername.Anchor = AnchorStyles.None;
            tbNewUsername.BackColor = Color.FromArgb(20, 20, 50);
            tbNewUsername.BorderColor = Color.White;
            tbNewUsername.BorderFocusColor = Color.White;
            tbNewUsername.BorderSize = 4;
            tbNewUsername.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbNewUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNewUsername.ForeColor = Color.White;
            tbNewUsername.IsMultiline = false;
            tbNewUsername.Location = new Point(80, 181);
            tbNewUsername.Margin = new Padding(18, 0, 18, 0);
            tbNewUsername.Name = "tbNewUsername";
            tbNewUsername.Padding = new Padding(6, 5, 6, 5);
            tbNewUsername.PlaceholderText = "Username";
            tbNewUsername.PlaceholderTextColor = Color.White;
            tbNewUsername.ShortcutEnabled = true;
            tbNewUsername.Size = new Size(367, 31);
            tbNewUsername.TabIndex = 1;
            tbNewUsername.UsePasswordChar = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.BackColor = Color.FromArgb(0, 150, 255);
            btnSearch.BorderColor = Color.White;
            btnSearch.BorderWidth = 2;
            btnSearch.CornerRadius = 15;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = null;
            btnSearch.ImageSize = new Size(150, 40);
            btnSearch.Location = new Point(455, 176);
            btnSearch.Margin = new Padding(5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 40);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // formAdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(650, 600);
            Controls.Add(tbNewUsername);
            Controls.Add(btnSearch);
            Controls.Add(btnViewUser);
            Controls.Add(clbUserSelector);
            Controls.Add(lblAdminInfo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formAdminMenu";
            Text = "formUserHome";
            ResumeLayout(false);
        }

        #endregion

        private Label lblAdminInfo;
        private CheckedListBox clbUserSelector;
        private Custom_Controls.CustomButton btnViewUser;
        private Custom_Controls.CustomTextbox tbNewUsername;
        private Custom_Controls.CustomButton btnSearch;
    }
}