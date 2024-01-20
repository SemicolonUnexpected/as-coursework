namespace AS_Coursework.View.QuizView {
    partial class formQuiz {
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
            pnlQuestionDisplay = new Panel();
            btnExit = new Custom_Controls.CustomButton();
            SuspendLayout();
            // 
            // pnlQuestionDisplay
            // 
            pnlQuestionDisplay.Anchor = AnchorStyles.None;
            pnlQuestionDisplay.Location = new Point(75, 0);
            pnlQuestionDisplay.Margin = new Padding(0);
            pnlQuestionDisplay.Name = "pnlQuestionDisplay";
            pnlQuestionDisplay.Size = new Size(975, 900);
            pnlQuestionDisplay.TabIndex = 0;
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
            btnExit.Location = new Point(1050, 0);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 75);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // formQuiz
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(1125, 900);
            Controls.Add(btnExit);
            Controls.Add(pnlQuestionDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formQuiz";
            Text = "formUserHome";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlQuestionDisplay;
        private Custom_Controls.CustomButton btnExit;
    }
}