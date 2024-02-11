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
            pnlQuestionDisplay.Location = new Point(50, 0);
            pnlQuestionDisplay.Margin = new Padding(0);
            pnlQuestionDisplay.Name = "pnlQuestionDisplay";
            pnlQuestionDisplay.Size = new Size(700, 600);
            pnlQuestionDisplay.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.FromArgb(20, 20, 50);
            btnExit.BorderColor = Color.WhiteSmoke;
            btnExit.BorderWidth = 0;
            btnExit.CornerRadius = 20;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Black;
            btnExit.Image = Resources.Icons.Icons.cross;
            btnExit.ImageSize = new Size(25, 25);
            btnExit.Location = new Point(755, 5);
            btnExit.Margin = new Padding(5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 40);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // formQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(800, 600);
            Controls.Add(btnExit);
            Controls.Add(pnlQuestionDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formQuiz";
            Text = "formUserHome";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlQuestionDisplay;
        private Custom_Controls.CustomButton btnExit;
    }
}