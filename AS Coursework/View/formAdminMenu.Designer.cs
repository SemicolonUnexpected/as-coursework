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
            lblDangerZoneDescription = new Label();
            SuspendLayout();
            // 
            // lblDangerZoneDescription
            // 
            lblDangerZoneDescription.Anchor = AnchorStyles.None;
            lblDangerZoneDescription.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDangerZoneDescription.ForeColor = Color.White;
            lblDangerZoneDescription.Location = new Point(11, 9);
            lblDangerZoneDescription.Margin = new Padding(2, 0, 2, 0);
            lblDangerZoneDescription.Name = "lblDangerZoneDescription";
            lblDangerZoneDescription.Size = new Size(628, 95);
            lblDangerZoneDescription.TabIndex = 2;
            lblDangerZoneDescription.Text = "Welcome to the admin menu. Here you can Change who has admin permissions and access each user's settings page to change any details (such as a password reset).";
            lblDangerZoneDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formAdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(650, 600);
            Controls.Add(lblDangerZoneDescription);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formAdminMenu";
            Text = "formUserHome";
            ResumeLayout(false);
        }

        #endregion

        private Label lblDangerZoneDescription;
    }
}