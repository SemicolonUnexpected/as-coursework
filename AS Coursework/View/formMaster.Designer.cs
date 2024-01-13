namespace AS_Coursework.View {
    partial class formMaster {
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
            pnlFormHolder = new Panel();
            SuspendLayout();
            // 
            // pnlFormHolder
            // 
            pnlFormHolder.BackColor = Color.FromArgb(20, 20, 50);
            pnlFormHolder.Dock = DockStyle.Fill;
            pnlFormHolder.Location = new Point(0, 0);
            pnlFormHolder.Margin = new Padding(3, 4, 3, 4);
            pnlFormHolder.Name = "pnlFormHolder";
            pnlFormHolder.Size = new Size(1200, 900);
            pnlFormHolder.TabIndex = 0;
            // 
            // formMaster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 900);
            Controls.Add(pnlFormHolder);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1222, 956);
            Name = "formMaster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChemQuiz";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFormHolder;
    }
}