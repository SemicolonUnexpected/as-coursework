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
            lblAdminInfo.TabIndex = 2;
            lblAdminInfo.Text = resources.GetString("lblAdminInfo.Text");
            lblAdminInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clbUserSelector
            // 
            clbUserSelector.Anchor = AnchorStyles.None;
            clbUserSelector.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            clbUserSelector.FormattingEnabled = true;
            clbUserSelector.Items.AddRange(new object[] { "Test ", "Test2", "Test3" });
            clbUserSelector.Location = new Point(80, 174);
            clbUserSelector.Name = "clbUserSelector";
            clbUserSelector.Size = new Size(500, 329);
            clbUserSelector.TabIndex = 3;
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
            btnViewUser.Location = new Point(463, 527);
            btnViewUser.Margin = new Padding(19, 21, 19, 21);
            btnViewUser.Name = "btnViewUser";
            btnViewUser.Size = new Size(117, 40);
            btnViewUser.TabIndex = 4;
            btnViewUser.Text = "View user";
            btnViewUser.UseVisualStyleBackColor = false;
            // 
            // formAdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(650, 600);
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
    }
}