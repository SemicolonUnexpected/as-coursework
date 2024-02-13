namespace AS_Coursework {
    partial class formTest {
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
            sb = new Custom_Controls.CustomScrollBar();
            SuspendLayout();
            // 
            // sb
            // 
            sb.BorderColor = Color.Black;
            sb.BorderWidth = 0;
            sb.ChannelColor = Color.FromArgb(40, 40, 90);
            sb.ChannelPadding = new Padding(0);
            sb.Dock = DockStyle.Right;
            sb.Location = new Point(702, 0);
            sb.Margin = new Padding(2);
            sb.Maximum = 100;
            sb.Minimum = 0;
            sb.MouseWheelSensitivity = 1;
            sb.Name = "sb";
            sb.Size = new Size(10, 598);
            sb.TabIndex = 1;
            sb.Text = "customScrollBar1";
            sb.ThumbColor = Color.White;
            sb.ThumbSize = new Size(15, 80);
            sb.Value = 0;
            // 
            // formTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(712, 598);
            Controls.Add(sb);
            Margin = new Padding(2, 2, 2, 2);
            Name = "formTest";
            Text = "dro";
            ResumeLayout(false);
        }

        #endregion
        private Custom_Controls.CustomScrollBar customScrollBar1;
        private Custom_Controls.CustomScrollBar sb;
    }
}