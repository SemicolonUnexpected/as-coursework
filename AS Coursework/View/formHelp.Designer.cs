namespace AS_Coursework.View {
    partial class formHelp {
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
            lblHelpInfo = new Label();
            comboBox = new ComboBox();
            pnlBack = new Custom_Controls.CustomRectangle();
            lblInfo = new Label();
            lblSectionTitle = new Label();
            pnlBack.SuspendLayout();
            SuspendLayout();
            // 
            // lblHelpInfo
            // 
            lblHelpInfo.Anchor = AnchorStyles.None;
            lblHelpInfo.AutoEllipsis = true;
            lblHelpInfo.BackColor = Color.FromArgb(30, 30, 70);
            lblHelpInfo.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblHelpInfo.ForeColor = Color.White;
            lblHelpInfo.Location = new Point(12, 12);
            lblHelpInfo.Margin = new Padding(12);
            lblHelpInfo.Name = "lblHelpInfo";
            lblHelpInfo.Size = new Size(684, 411);
            lblHelpInfo.TabIndex = 2;
            // 
            // comboBox
            // 
            comboBox.Anchor = AnchorStyles.None;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(139, 105);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(590, 33);
            comboBox.TabIndex = 3;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // pnlBack
            // 
            pnlBack.Anchor = AnchorStyles.None;
            pnlBack.BackColor = Color.FromArgb(30, 30, 70);
            pnlBack.BorderColor = Color.Empty;
            pnlBack.BorderWidth = 0;
            pnlBack.Controls.Add(lblHelpInfo);
            pnlBack.CornerRadius = 10;
            pnlBack.Location = new Point(21, 147);
            pnlBack.Name = "pnlBack";
            pnlBack.Size = new Size(708, 432);
            pnlBack.TabIndex = 4;
            pnlBack.Text = "customRectangle1";
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.None;
            lblInfo.AutoEllipsis = true;
            lblInfo.BackColor = Color.FromArgb(20, 20, 50);
            lblInfo.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(21, 21);
            lblInfo.Margin = new Padding(12);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(708, 72);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "To use the help menu select a section below";
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSectionTitle
            // 
            lblSectionTitle.Anchor = AnchorStyles.None;
            lblSectionTitle.AutoEllipsis = true;
            lblSectionTitle.BackColor = Color.FromArgb(20, 20, 50);
            lblSectionTitle.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSectionTitle.ForeColor = Color.White;
            lblSectionTitle.Location = new Point(21, 99);
            lblSectionTitle.Margin = new Padding(12);
            lblSectionTitle.Name = "lblSectionTitle";
            lblSectionTitle.Size = new Size(112, 41);
            lblSectionTitle.TabIndex = 6;
            lblSectionTitle.Text = "Section :";
            lblSectionTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // formHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(750, 600);
            Controls.Add(lblSectionTitle);
            Controls.Add(lblInfo);
            Controls.Add(comboBox);
            Controls.Add(pnlBack);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formHelp";
            Text = "formUserHome";
            pnlBack.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblHelpInfo;
        private ComboBox comboBox;
        private Custom_Controls.CustomRectangle pnlBack;
        private Label lblInfo;
        private Label lblSectionTitle;
    }
}
