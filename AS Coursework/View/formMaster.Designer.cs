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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMaster));
            pnlFormHolder = new Panel();
            SuspendLayout();
            // 
            // pnlFormHolder
            // 
            pnlFormHolder.BackColor = Color.FromArgb(20, 20, 50);
            pnlFormHolder.Dock = DockStyle.Fill;
            pnlFormHolder.Location = new Point(0, 0);
            pnlFormHolder.Margin = new Padding(2, 3, 2, 3);
            pnlFormHolder.Name = "pnlFormHolder";
            pnlFormHolder.Size = new Size(800, 600);
            pnlFormHolder.TabIndex = 0;
            // 
            // formMaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(pnlFormHolder);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(814, 639);
            Name = "formMaster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChemQuiz";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFormHolder;
    }
}