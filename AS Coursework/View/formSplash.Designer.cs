namespace AS_Coursework {
    partial class formSplash {
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
            lblQuizTitle = new Label();
            pb = new Custom_Controls.CustomProgressBar();
            SuspendLayout();
            // 
            // lblQuizTitle
            // 
            lblQuizTitle.Anchor = AnchorStyles.None;
            lblQuizTitle.AutoSize = true;
            lblQuizTitle.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuizTitle.ForeColor = Color.White;
            lblQuizTitle.Location = new Point(490, 330);
            lblQuizTitle.Name = "lblQuizTitle";
            lblQuizTitle.Size = new Size(211, 48);
            lblQuizTitle.TabIndex = 2;
            lblQuizTitle.Text = "Chem Quiz";
            // 
            // pb
            // 
            pb.Anchor = AnchorStyles.None;
            pb.Angle = 0;
            pb.BackingColor = Color.White;
            pb.EndColor = Color.FromArgb(50, 200, 255);
            pb.Location = new Point(358, 580);
            pb.Name = "pb";
            pb.Progress = 1F;
            pb.Size = new Size(500, 50);
            pb.StartColor = Color.FromArgb(0, 100, 255);
            pb.TabIndex = 3;
            pb.Text = "customProgressBar1";
            // 
            // formSplash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(1222, 1000);
            Controls.Add(pb);
            Controls.Add(lblQuizTitle);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formSplash";
            Text = "FormSplash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuizTitle;
        private Custom_Controls.CustomProgressBar pb;
    }
}