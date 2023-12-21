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
            vScrollBar1 = new VScrollBar();
            lblUsername = new Label();
            customScrollBar2 = new Custom_Controls.CustomScrollBar();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(434, 106);
            vScrollBar1.Maximum = 25;
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(46, 297);
            vScrollBar1.TabIndex = 1;
            vScrollBar1.Value = 25;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            vScrollBar1.ValueChanged += vScrollBar1_ValueChanged;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top;
            lblUsername.AutoEllipsis = true;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(421, 33);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(185, 43);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            lblUsername.Click += lblUsername_Click;
            // 
            // customScrollBar2
            // 
            customScrollBar2.BorderColor = Color.Black;
            customScrollBar2.BorderWidth = 0;
            customScrollBar2.ChannelColor = Color.White;
            customScrollBar2.ChannelPadding = new Padding(0);
            customScrollBar2.Location = new Point(566, 162);
            customScrollBar2.Maximum = 100;
            customScrollBar2.Minimum = 0;
            customScrollBar2.Name = "customScrollBar2";
            customScrollBar2.Size = new Size(61, 241);
            customScrollBar2.TabIndex = 4;
            customScrollBar2.Text = "customScrollBar2";
            customScrollBar2.ThumbColor = Color.Gray;
            customScrollBar2.ThumbSize = new Size(50, 50);
            customScrollBar2.Value = 100;
            customScrollBar2.Scroll += customScrollBar2_Scroll;
            customScrollBar2.ValueChanged += customScrollBar2_ValueChanged;
            // 
            // formTest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(793, 450);
            Controls.Add(customScrollBar2);
            Controls.Add(lblUsername);
            Controls.Add(vScrollBar1);
            Name = "formTest";
            Text = "dro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private VScrollBar vScrollBar1;
        private Label lblUsername;
        private Custom_Controls.CustomScrollBar customScrollBar1;
        private Custom_Controls.CustomScrollBar customScrollBar2;
    }
}