namespace AS_Coursework.View {
    partial class formMainMenu {
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
            pnlMenuStrip = new Panel();
            miSignOut = new Custom_Controls.MenuItem();
            miAdmin = new Custom_Controls.MenuItem();
            miSettings = new Custom_Controls.MenuItem();
            miRanks = new Custom_Controls.MenuItem();
            miQuiz = new Custom_Controls.MenuItem();
            miHome = new Custom_Controls.MenuItem();
            pnlMenuDivider = new Panel();
            miMenu = new Custom_Controls.MenuItem();
            pnlUserViewHolder = new Panel();
            sb = new Custom_Controls.CustomScrollBar();
            pnlMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuStrip
            // 
            pnlMenuStrip.BackColor = Color.FromArgb(40, 40, 90);
            pnlMenuStrip.Controls.Add(miSignOut);
            pnlMenuStrip.Controls.Add(miAdmin);
            pnlMenuStrip.Controls.Add(miSettings);
            pnlMenuStrip.Controls.Add(miRanks);
            pnlMenuStrip.Controls.Add(miQuiz);
            pnlMenuStrip.Controls.Add(miHome);
            pnlMenuStrip.Controls.Add(pnlMenuDivider);
            pnlMenuStrip.Controls.Add(miMenu);
            pnlMenuStrip.Dock = DockStyle.Left;
            pnlMenuStrip.Location = new Point(0, 0);
            pnlMenuStrip.Name = "pnlMenuStrip";
            pnlMenuStrip.Size = new Size(200, 900);
            pnlMenuStrip.TabIndex = 0;
            // 
            // miSignOut
            // 
            miSignOut.BackColor = Color.FromArgb(40, 40, 90);
            miSignOut.BaseColor = Color.FromArgb(40, 40, 90);
            miSignOut.Dock = DockStyle.Bottom;
            miSignOut.HoverColour = Color.FromArgb(50, 50, 100);
            miSignOut.Image = Resources.Icons.Sign_out;
            miSignOut.ImagePadding = 20;
            miSignOut.Location = new Point(0, 820);
            miSignOut.MenuText = "Sign out";
            miSignOut.Name = "miSignOut";
            miSignOut.Size = new Size(200, 80);
            miSignOut.TabIndex = 8;
            miSignOut.MenuClick += miSignOut_MenuClick;
            // 
            // miAdmin
            // 
            miAdmin.BackColor = Color.FromArgb(40, 40, 90);
            miAdmin.BaseColor = Color.FromArgb(40, 40, 90);
            miAdmin.Dock = DockStyle.Top;
            miAdmin.HoverColour = Color.FromArgb(50, 50, 100);
            miAdmin.Image = Resources.Icons.Admin;
            miAdmin.ImagePadding = 20;
            miAdmin.Location = new Point(0, 407);
            miAdmin.MenuText = "Admin";
            miAdmin.Name = "miAdmin";
            miAdmin.Size = new Size(200, 80);
            miAdmin.TabIndex = 7;
            miAdmin.MenuClick += miAdmin_MenuClick;
            // 
            // miSettings
            // 
            miSettings.BackColor = Color.FromArgb(40, 40, 90);
            miSettings.BaseColor = Color.FromArgb(40, 40, 90);
            miSettings.Dock = DockStyle.Top;
            miSettings.HoverColour = Color.FromArgb(50, 50, 100);
            miSettings.Image = Resources.Icons.Settings;
            miSettings.ImagePadding = 20;
            miSettings.Location = new Point(0, 327);
            miSettings.MenuText = "Settings";
            miSettings.Name = "miSettings";
            miSettings.Size = new Size(200, 80);
            miSettings.TabIndex = 6;
            miSettings.MenuClick += miSettings_MenuClick;
            // 
            // miRanks
            // 
            miRanks.BackColor = Color.FromArgb(40, 40, 90);
            miRanks.BaseColor = Color.FromArgb(40, 40, 90);
            miRanks.Dock = DockStyle.Top;
            miRanks.HoverColour = Color.FromArgb(50, 50, 100);
            miRanks.Image = Resources.Icons.Medal;
            miRanks.ImagePadding = 20;
            miRanks.Location = new Point(0, 247);
            miRanks.MenuText = "Ranks";
            miRanks.Name = "miRanks";
            miRanks.Size = new Size(200, 80);
            miRanks.TabIndex = 9;
            miRanks.MenuClick += miRanks_Click;
            // 
            // miQuiz
            // 
            miQuiz.BackColor = Color.FromArgb(40, 40, 90);
            miQuiz.BaseColor = Color.FromArgb(40, 40, 90);
            miQuiz.Dock = DockStyle.Top;
            miQuiz.HoverColour = Color.FromArgb(50, 50, 100);
            miQuiz.Image = Resources.Icons.Notebook;
            miQuiz.ImagePadding = 20;
            miQuiz.Location = new Point(0, 167);
            miQuiz.MenuText = "Quiz";
            miQuiz.Name = "miQuiz";
            miQuiz.Size = new Size(200, 80);
            miQuiz.TabIndex = 4;
            miQuiz.MenuClick += miQuiz_MenuClick;
            // 
            // miHome
            // 
            miHome.BackColor = Color.FromArgb(40, 40, 90);
            miHome.BaseColor = Color.FromArgb(40, 40, 90);
            miHome.Dock = DockStyle.Top;
            miHome.HoverColour = Color.FromArgb(50, 50, 100);
            miHome.Image = Resources.Icons.Home;
            miHome.ImagePadding = 20;
            miHome.Location = new Point(0, 87);
            miHome.MenuText = "Home";
            miHome.Name = "miHome";
            miHome.Size = new Size(200, 80);
            miHome.TabIndex = 3;
            miHome.MenuClick += miHome_MenuClick;
            // 
            // pnlMenuDivider
            // 
            pnlMenuDivider.BackColor = Color.White;
            pnlMenuDivider.Dock = DockStyle.Top;
            pnlMenuDivider.Location = new Point(0, 80);
            pnlMenuDivider.Name = "pnlMenuDivider";
            pnlMenuDivider.Size = new Size(200, 7);
            pnlMenuDivider.TabIndex = 2;
            // 
            // miMenu
            // 
            miMenu.BackColor = Color.FromArgb(40, 40, 90);
            miMenu.BaseColor = Color.FromArgb(40, 40, 90);
            miMenu.Dock = DockStyle.Top;
            miMenu.HoverColour = Color.FromArgb(50, 50, 100);
            miMenu.Image = Resources.Icons.Menu_burger;
            miMenu.ImagePadding = 20;
            miMenu.Location = new Point(0, 0);
            miMenu.MenuText = "Menu";
            miMenu.Name = "miMenu";
            miMenu.Size = new Size(200, 80);
            miMenu.TabIndex = 1;
            miMenu.MenuClick += Menu_Click;
            // 
            // pnlUserViewHolder
            // 
            pnlUserViewHolder.Dock = DockStyle.Fill;
            pnlUserViewHolder.Location = new Point(200, 0);
            pnlUserViewHolder.Margin = new Padding(3, 4, 3, 4);
            pnlUserViewHolder.Name = "pnlUserViewHolder";
            pnlUserViewHolder.Size = new Size(975, 900);
            pnlUserViewHolder.TabIndex = 1;
            // 
            // sb
            // 
            sb.BorderColor = Color.Black;
            sb.BorderWidth = 0;
            sb.ChannelColor = Color.FromArgb(40, 40, 90);
            sb.ChannelPadding = new Padding(5);
            sb.Dock = DockStyle.Right;
            sb.Location = new Point(1175, 0);
            sb.Maximum = 100;
            sb.Minimum = 0;
            sb.MouseWheelSensitivity = 1;
            sb.Name = "sb";
            sb.Size = new Size(25, 900);
            sb.TabIndex = 0;
            sb.Text = "customScrollBar1";
            sb.ThumbColor = Color.White;
            sb.ThumbSize = new Size(15, 80);
            sb.Value = 0;
            sb.ValueChanged += sb_ValueChanged;
            // 
            // formMainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(1200, 900);
            Controls.Add(pnlUserViewHolder);
            Controls.Add(sb);
            Controls.Add(pnlMenuStrip);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formMainMenu";
            Text = "HomeView";
            pnlMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenuStrip;
        private Panel pnlUserViewHolder;
        private Custom_Controls.MenuItem miMenu;
        private Custom_Controls.MenuItem miAdmin;
        private Custom_Controls.MenuItem miSettings;
        private Custom_Controls.MenuItem miQuiz;
        private Custom_Controls.MenuItem miHome;
        private Panel pnlMenuDivider;
        private Custom_Controls.MenuItem miSignOut;
        private Custom_Controls.MenuItem miRanks;
        private Custom_Controls.CustomScrollBar sb;
    }
}