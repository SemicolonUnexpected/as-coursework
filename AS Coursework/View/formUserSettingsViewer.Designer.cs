namespace AS_Coursework.View {
    partial class formUserSettingsViewer {
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
            pnlSettingsDisplay = new Panel();
            btnExit = new Custom_Controls.CustomButton();
            sb = new Custom_Controls.CustomScrollBar();
            SuspendLayout();
            // 
            // pnlSettingsDisplay
            // 
            pnlSettingsDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pnlSettingsDisplay.Location = new Point(40, 0);
            pnlSettingsDisplay.Margin = new Padding(0);
            pnlSettingsDisplay.Name = "pnlSettingsDisplay";
            pnlSettingsDisplay.Size = new Size(700, 600);
            pnlSettingsDisplay.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(20, 20, 50);
            btnExit.BorderColor = Color.WhiteSmoke;
            btnExit.BorderWidth = 0;
            btnExit.CornerRadius = 37;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Black;
            btnExit.Image = Resources.Icons.cross;
            btnExit.ImageSize = new Size(40, 40);
            btnExit.Location = new Point(750, 0);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // sb
            // 
            sb.BorderColor = Color.Black;
            sb.BorderWidth = 0;
            sb.ChannelColor = Color.FromArgb(40, 40, 90);
            sb.ChannelPadding = new Padding(5);
            sb.Location = new Point(740, 0);
            sb.Margin = new Padding(2);
            sb.Maximum = 100;
            sb.Minimum = 0;
            sb.MouseWheelSensitivity = 1;
            sb.Name = "sb";
            sb.Size = new Size(10, 600);
            sb.TabIndex = 2;
            sb.Text = "customScrollBar1";
            sb.ThumbColor = Color.White;
            sb.ThumbSize = new Size(15, 80);
            sb.Value = 0;
            // 
            // formUserSettingsViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(800, 600);
            Controls.Add(sb);
            Controls.Add(btnExit);
            Controls.Add(pnlSettingsDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formUserSettingsViewer";
            Text = "formUserHome";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSettingsDisplay;
        private Custom_Controls.CustomButton btnExit;
        private Custom_Controls.CustomScrollBar sb;
    }
}
