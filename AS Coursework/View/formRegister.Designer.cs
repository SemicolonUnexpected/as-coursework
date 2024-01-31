namespace AS_Coursework.View {
    partial class RegisterView {
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
            pnlRight = new Panel();
            lblSignIn = new Label();
            pnlRegisterForm = new Panel();
            lblRegisterTitle = new Label();
            pnlRightGradTwo = new Panel();
            pnlRightGradOne = new Panel();
            pbBackground = new Custom_Controls.PicturePanel();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(20, 20, 50);
            pnlRight.Controls.Add(lblSignIn);
            pnlRight.Controls.Add(pnlRegisterForm);
            pnlRight.Controls.Add(lblRegisterTitle);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(497, 0);
            pnlRight.Margin = new Padding(2, 2, 2, 2);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(323, 650);
            pnlRight.TabIndex = 0;
            // 
            // lblSignIn
            // 
            lblSignIn.Anchor = AnchorStyles.None;
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSignIn.ForeColor = Color.White;
            lblSignIn.Location = new Point(26, 507);
            lblSignIn.Margin = new Padding(2, 0, 2, 0);
            lblSignIn.MaximumSize = new Size(291, 0);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(290, 57);
            lblSignIn.TabIndex = 7;
            lblSignIn.Text = "Already have an account? Click here to sign in\r\n\r\n";
            lblSignIn.TextAlign = ContentAlignment.MiddleCenter;
            lblSignIn.Click += lblSignIn_Click;
            lblSignIn.MouseEnter += lblSignIn_MouseEnter;
            lblSignIn.MouseLeave += LblSignIn_MouseLeave;
            // 
            // pnlRegisterForm
            // 
            pnlRegisterForm.Anchor = AnchorStyles.None;
            pnlRegisterForm.Location = new Point(0, 125);
            pnlRegisterForm.Margin = new Padding(2, 2, 2, 2);
            pnlRegisterForm.Name = "pnlRegisterForm";
            pnlRegisterForm.Size = new Size(323, 360);
            pnlRegisterForm.TabIndex = 6;
            // 
            // lblRegisterTitle
            // 
            lblRegisterTitle.Anchor = AnchorStyles.None;
            lblRegisterTitle.AutoSize = true;
            lblRegisterTitle.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegisterTitle.ForeColor = Color.White;
            lblRegisterTitle.Location = new Point(102, 80);
            lblRegisterTitle.Margin = new Padding(2, 0, 2, 0);
            lblRegisterTitle.Name = "lblRegisterTitle";
            lblRegisterTitle.Size = new Size(117, 33);
            lblRegisterTitle.TabIndex = 5;
            lblRegisterTitle.Text = "Register";
            // 
            // pnlRightGradTwo
            // 
            pnlRightGradTwo.BackColor = Color.FromArgb(40, 40, 90);
            pnlRightGradTwo.Dock = DockStyle.Right;
            pnlRightGradTwo.Location = new Point(451, 0);
            pnlRightGradTwo.Margin = new Padding(2, 2, 2, 2);
            pnlRightGradTwo.Name = "pnlRightGradTwo";
            pnlRightGradTwo.Size = new Size(23, 650);
            pnlRightGradTwo.TabIndex = 4;
            // 
            // pnlRightGradOne
            // 
            pnlRightGradOne.BackColor = Color.FromArgb(30, 30, 70);
            pnlRightGradOne.Dock = DockStyle.Right;
            pnlRightGradOne.Location = new Point(474, 0);
            pnlRightGradOne.Margin = new Padding(2, 2, 2, 2);
            pnlRightGradOne.Name = "pnlRightGradOne";
            pnlRightGradOne.Size = new Size(23, 650);
            pnlRightGradOne.TabIndex = 3;
            // 
            // pbBackground
            // 
            pbBackground.Dock = DockStyle.Fill;
            pbBackground.Image = Resources.Images.Test_Tube_and_Dropper;
            pbBackground.ImagePortion = new Rectangle(0, 0, 1042, 1334);
            pbBackground.Location = new Point(0, 0);
            pbBackground.Margin = new Padding(2, 2, 2, 2);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(451, 650);
            pbBackground.TabIndex = 5;
            pbBackground.Text = "customPictureBox1";
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 150, 255);
            ClientSize = new Size(820, 650);
            Controls.Add(pbBackground);
            Controls.Add(pnlRightGradTwo);
            Controls.Add(pnlRightGradOne);
            Controls.Add(pnlRight);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "RegisterView";
            Text = "LoginView";
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRight;
        private Panel pnlRightGradTwo;
        private Panel pnlRightGradOne;
        private Label lblRegisterTitle;
        private Panel pnlRegisterForm;
        private Label lblSignIn;
        private Custom_Controls.PicturePanel pbBackground;
    }
}