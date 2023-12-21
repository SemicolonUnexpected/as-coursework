namespace AS_Coursework.Custom_Controls {
    partial class formCustomMessageBox {
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
            pnlBottom = new Panel();
            btnOk = new CustomButton();
            btnCancel = new CustomButton();
            lblText = new Label();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.FromArgb(30, 30, 60);
            pnlBottom.Controls.Add(btnOk);
            pnlBottom.Controls.Add(btnCancel);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 269);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(578, 75);
            pnlBottom.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.None;
            btnOk.BackColor = Color.FromArgb(0, 150, 255);
            btnOk.BorderColor = Color.White;
            btnOk.BorderWidth = 2;
            btnOk.CornerRadius = 20;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.ForeColor = Color.White;
            btnOk.Image = null;
            btnOk.ImageSize = new Size(150, 40);
            btnOk.Location = new Point(326, 13);
            btnOk.Margin = new Padding(10);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 50);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.FromArgb(0, 150, 255);
            btnCancel.BorderColor = Color.White;
            btnCancel.BorderWidth = 2;
            btnCancel.CornerRadius = 20;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = null;
            btnCancel.ImageSize = new Size(150, 40);
            btnCancel.Location = new Point(446, 13);
            btnCancel.Margin = new Padding(10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 50);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblText.ForeColor = Color.White;
            lblText.ImageAlign = ContentAlignment.TopCenter;
            lblText.Location = new Point(10, 10);
            lblText.MinimumSize = new Size(558, 249);
            lblText.Name = "lblText";
            lblText.Size = new Size(558, 249);
            lblText.TabIndex = 2;
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formCustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(578, 344);
            Controls.Add(lblText);
            Controls.Add(pnlBottom);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "formCustomMessageBox";
            StartPosition = FormStartPosition.CenterParent;
            Text = "formCustomMessageBox";
            TopMost = true;
            pnlBottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBottom;
        private CustomButton btnOk;
        private CustomButton btnCancel;
        private Label lblText;
    }
}