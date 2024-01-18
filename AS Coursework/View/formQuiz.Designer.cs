namespace AS_Coursework.View {
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
            SuspendLayout();
            // 
            // pnlQuestionDisplay
            // 
            pnlQuestionDisplay.Anchor = AnchorStyles.None;
            pnlQuestionDisplay.Location = new Point(75, 0);
            pnlQuestionDisplay.Name = "pnlQuestionDisplay";
            pnlQuestionDisplay.Size = new Size(975, 900);
            pnlQuestionDisplay.TabIndex = 0;
            // 
            // formQuiz
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(1125, 900);
            Controls.Add(pnlQuestionDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formQuiz";
            Text = "formUserHome";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlQuestionDisplay;
    }
}