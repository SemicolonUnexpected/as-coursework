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
            menuItemHelp = new Custom_Controls.MenuItem();
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
            pnlMenuStrip.Controls.Add(menuItemHelp);
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
            pnlMenuStrip.Margin = new Padding(2);
            pnlMenuStrip.Name = "pnlMenuStrip";
            pnlMenuStrip.Size = new Size(140, 600);
            pnlMenuStrip.TabIndex = 0;
            pnlMenuStrip.MouseEnter += MinimiseOnMouseExit;
            pnlMenuStrip.MouseLeave += MinimiseOnMouseExit;
            // 
            // menuItemHelp
            // 
            menuItemHelp.BackColor = Color.FromArgb(40, 40, 90);
            menuItemHelp.BaseColor = Color.FromArgb(40, 40, 90);
            menuItemHelp.Dock = DockStyle.Bottom;
            menuItemHelp.HoverColour = Color.FromArgb(50, 50, 100);
            menuItemHelp.Image = Resources.Icons.Icons.Question;
            menuItemHelp.ImagePadding = 10;
            menuItemHelp.Location = new Point(0, 504);
            menuItemHelp.Margin = new Padding(1);
            menuItemHelp.MenuText = "Help";
            menuItemHelp.Name = "menuItemHelp";
            menuItemHelp.Size = new Size(140, 48);
            menuItemHelp.TabIndex = 7;
            menuItemHelp.MenuClick += miHelp_MenuClick;
            menuItemHelp.MouseEnter += MinimiseOnMouseExit;
            menuItemHelp.MouseLeave += MinimiseOnMouseExit;
            // 
            // miSignOut
            // 
            miSignOut.BackColor = Color.FromArgb(40, 40, 90);
            miSignOut.BaseColor = Color.FromArgb(40, 40, 90);
            miSignOut.Dock = DockStyle.Bottom;
            miSignOut.HoverColour = Color.FromArgb(50, 50, 100);
            miSignOut.Image = Resources.Icons.Icons.Sign_out;
            miSignOut.ImagePadding = 10;
            miSignOut.Location = new Point(0, 552);
            miSignOut.Margin = new Padding(1);
            miSignOut.MenuText = "Sign out";
            miSignOut.Name = "miSignOut";
            miSignOut.Size = new Size(140, 48);
            miSignOut.TabIndex = 6;
            miSignOut.MenuClick += miSignOut_MenuClick;
            miSignOut.MouseEnter += MinimiseOnMouseExit;
            miSignOut.MouseLeave += MinimiseOnMouseExit;
            // 
            // miAdmin
            // 
            miAdmin.BackColor = Color.FromArgb(40, 40, 90);
            miAdmin.BaseColor = Color.FromArgb(40, 40, 90);
            miAdmin.Dock = DockStyle.Top;
            miAdmin.HoverColour = Color.FromArgb(50, 50, 100);
            miAdmin.Image = Resources.Icons.Icons.Admin;
            miAdmin.ImagePadding = 10;
            miAdmin.Location = new Point(0, 244);
            miAdmin.Margin = new Padding(1);
            miAdmin.MenuText = "Admin";
            miAdmin.Name = "miAdmin";
            miAdmin.Size = new Size(140, 48);
            miAdmin.TabIndex = 5;
            miAdmin.MenuClick += miAdmin_MenuClick;
            miAdmin.MouseEnter += MinimiseOnMouseExit;
            miAdmin.MouseLeave += MinimiseOnMouseExit;
            // 
            // miSettings
            // 
            miSettings.BackColor = Color.FromArgb(40, 40, 90);
            miSettings.BaseColor = Color.FromArgb(40, 40, 90);
            miSettings.Dock = DockStyle.Top;
            miSettings.HoverColour = Color.FromArgb(50, 50, 100);
            miSettings.Image = Resources.Icons.Icons.Settings;
            miSettings.ImagePadding = 10;
            miSettings.Location = new Point(0, 196);
            miSettings.Margin = new Padding(1);
            miSettings.MenuText = "Settings";
            miSettings.Name = "miSettings";
            miSettings.Size = new Size(140, 48);
            miSettings.TabIndex = 4;
            miSettings.MenuClick += miSettings_MenuClick;
            miSettings.MouseEnter += MinimiseOnMouseExit;
            miSettings.MouseLeave += MinimiseOnMouseExit;
            // 
            // miRanks
            // 
            miRanks.BackColor = Color.FromArgb(40, 40, 90);
            miRanks.BaseColor = Color.FromArgb(40, 40, 90);
            miRanks.Dock = DockStyle.Top;
            miRanks.HoverColour = Color.FromArgb(50, 50, 100);
            miRanks.Image = Resources.Icons.Icons.Medal;
            miRanks.ImagePadding = 10;
            miRanks.Location = new Point(0, 148);
            miRanks.Margin = new Padding(1);
            miRanks.MenuText = "Ranks";
            miRanks.Name = "miRanks";
            miRanks.Size = new Size(140, 48);
            miRanks.TabIndex = 3;
            miRanks.MenuClick += miRanks_Click;
            miRanks.MouseEnter += MinimiseOnMouseExit;
            miRanks.MouseLeave += MinimiseOnMouseExit;
            // 
            // miQuiz
            // 
            miQuiz.BackColor = Color.FromArgb(40, 40, 90);
            miQuiz.BaseColor = Color.FromArgb(40, 40, 90);
            miQuiz.Dock = DockStyle.Top;
            miQuiz.HoverColour = Color.FromArgb(50, 50, 100);
            miQuiz.Image = Resources.Icons.Icons.Notebook;
            miQuiz.ImagePadding = 10;
            miQuiz.Location = new Point(0, 100);
            miQuiz.Margin = new Padding(1);
            miQuiz.MenuText = "Quiz";
            miQuiz.Name = "miQuiz";
            miQuiz.Size = new Size(140, 48);
            miQuiz.TabIndex = 2;
            miQuiz.MenuClick += miQuiz_MenuClick;
            miQuiz.MouseEnter += MinimiseOnMouseExit;
            miQuiz.MouseLeave += MinimiseOnMouseExit;
            // 
            // miHome
            // 
            miHome.BackColor = Color.FromArgb(40, 40, 90);
            miHome.BaseColor = Color.FromArgb(40, 40, 90);
            miHome.Dock = DockStyle.Top;
            miHome.HoverColour = Color.FromArgb(50, 50, 100);
            miHome.Image = Resources.Icons.Icons.Home;
            miHome.ImagePadding = 10;
            miHome.Location = new Point(0, 52);
            miHome.Margin = new Padding(1);
            miHome.MenuText = "Home";
            miHome.Name = "miHome";
            miHome.Size = new Size(140, 48);
            miHome.TabIndex = 1;
            miHome.MenuClick += miHome_MenuClick;
            miHome.MouseEnter += MinimiseOnMouseExit;
            miHome.MouseLeave += MinimiseOnMouseExit;
            // 
            // pnlMenuDivider
            // 
            pnlMenuDivider.BackColor = Color.White;
            pnlMenuDivider.Dock = DockStyle.Top;
            pnlMenuDivider.Location = new Point(0, 48);
            pnlMenuDivider.Margin = new Padding(2);
            pnlMenuDivider.Name = "pnlMenuDivider";
            pnlMenuDivider.Size = new Size(140, 4);
            pnlMenuDivider.TabIndex = 2;
            // 
            // miMenu
            // 
            miMenu.BackColor = Color.FromArgb(40, 40, 90);
            miMenu.BaseColor = Color.FromArgb(40, 40, 90);
            miMenu.Dock = DockStyle.Top;
            miMenu.HoverColour = Color.FromArgb(50, 50, 100);
            miMenu.Image = Resources.Icons.Icons.Menu_burger;
            miMenu.ImagePadding = 10;
            miMenu.Location = new Point(0, 0);
            miMenu.Margin = new Padding(1);
            miMenu.MenuText = "Menu";
            miMenu.Name = "miMenu";
            miMenu.Size = new Size(140, 48);
            miMenu.TabIndex = 0;
            miMenu.MenuClick += Menu_Click;
            miMenu.MouseEnter += MinimiseOnMouseExit;
            miMenu.MouseLeave += MinimiseOnMouseExit;
            // 
            // pnlUserViewHolder
            // 
            pnlUserViewHolder.Dock = DockStyle.Fill;
            pnlUserViewHolder.Location = new Point(140, 0);
            pnlUserViewHolder.Margin = new Padding(2);
            pnlUserViewHolder.Name = "pnlUserViewHolder";
            pnlUserViewHolder.Size = new Size(650, 600);
            pnlUserViewHolder.TabIndex = 0;
            // 
            // sb
            // 
            sb.BorderColor = Color.Black;
            sb.BorderWidth = 0;
            sb.ChannelColor = Color.FromArgb(40, 40, 90);
            sb.ChannelPadding = new Padding(0);
            sb.Dock = DockStyle.Right;
            sb.Location = new Point(790, 0);
            sb.Margin = new Padding(2);
            sb.Maximum = 100;
            sb.Minimum = 0;
            sb.MouseWheelSensitivity = 1;
            sb.Name = "sb";
            sb.Size = new Size(10, 600);
            sb.TabIndex = 0;
            sb.TabStop = false;
            sb.Text = "customScrollBar1";
            sb.ThumbColor = Color.White;
            sb.ThumbSize = new Size(15, 80);
            sb.Value = 0;
            // 
            // formMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(800, 600);
            Controls.Add(pnlUserViewHolder);
            Controls.Add(sb);
            Controls.Add(pnlMenuStrip);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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
        private Custom_Controls.MenuItem menuItemHelp;
    }
}