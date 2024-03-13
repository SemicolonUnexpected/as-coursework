namespace AS_Coursework.View {
    partial class formAddQuestions {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddQuestions));
            lblAdminInfo = new Label();
            btnTestQuestion = new Custom_Controls.CustomButton();
            tbSearch = new Custom_Controls.CustomTextbox();
            btnSearch = new Custom_Controls.CustomButton();
            btnDeleteQuesiton = new Custom_Controls.CustomButton();
            lbQuestionSelector = new ListBox();
            btnAddQuesiton = new Custom_Controls.CustomButton();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblAdminInfo
            // 
            lblAdminInfo.Anchor = AnchorStyles.None;
            lblAdminInfo.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdminInfo.ForeColor = Color.White;
            lblAdminInfo.Location = new Point(11, 9);
            lblAdminInfo.Margin = new Padding(2, 0, 2, 0);
            lblAdminInfo.Name = "lblAdminInfo";
            lblAdminInfo.Size = new Size(628, 126);
            lblAdminInfo.TabIndex = 0;
            lblAdminInfo.Text = resources.GetString("lblAdminInfo.Text");
            lblAdminInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTestQuestion
            // 
            btnTestQuestion.Anchor = AnchorStyles.None;
            btnTestQuestion.BackColor = Color.FromArgb(0, 150, 255);
            btnTestQuestion.BorderColor = Color.White;
            btnTestQuestion.BorderWidth = 2;
            btnTestQuestion.CornerRadius = 15;
            btnTestQuestion.FlatAppearance.BorderSize = 0;
            btnTestQuestion.FlatStyle = FlatStyle.Flat;
            btnTestQuestion.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnTestQuestion.ForeColor = Color.White;
            btnTestQuestion.Image = null;
            btnTestQuestion.ImageSize = new Size(150, 40);
            btnTestQuestion.Location = new Point(364, 487);
            btnTestQuestion.Margin = new Padding(5);
            btnTestQuestion.Name = "btnTestQuestion";
            btnTestQuestion.Size = new Size(144, 40);
            btnTestQuestion.TabIndex = 4;
            btnTestQuestion.Text = "Test question";
            btnTestQuestion.UseVisualStyleBackColor = false;
            btnTestQuestion.Click += btnTestQuestion_Click;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.None;
            tbSearch.BackColor = Color.FromArgb(20, 20, 50);
            tbSearch.BorderColor = Color.White;
            tbSearch.BorderFocusColor = Color.White;
            tbSearch.BorderSize = 4;
            tbSearch.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearch.ForeColor = Color.White;
            tbSearch.IsMultiline = false;
            tbSearch.Location = new Point(80, 136);
            tbSearch.Margin = new Padding(18, 0, 18, 0);
            tbSearch.Name = "tbSearch";
            tbSearch.Padding = new Padding(6, 5, 6, 5);
            tbSearch.PlaceholderText = "Question name";
            tbSearch.PlaceholderTextColor = Color.White;
            tbSearch.ShortcutEnabled = true;
            tbSearch.Size = new Size(367, 31);
            tbSearch.TabIndex = 1;
            tbSearch.UsePasswordChar = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.BackColor = Color.FromArgb(0, 150, 255);
            btnSearch.BorderColor = Color.White;
            btnSearch.BorderWidth = 2;
            btnSearch.CornerRadius = 15;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = null;
            btnSearch.ImageSize = new Size(150, 40);
            btnSearch.Location = new Point(455, 131);
            btnSearch.Margin = new Padding(5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 40);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDeleteQuesiton
            // 
            btnDeleteQuesiton.Anchor = AnchorStyles.None;
            btnDeleteQuesiton.BackColor = Color.FromArgb(0, 150, 255);
            btnDeleteQuesiton.BorderColor = Color.White;
            btnDeleteQuesiton.BorderWidth = 2;
            btnDeleteQuesiton.CornerRadius = 15;
            btnDeleteQuesiton.FlatAppearance.BorderSize = 0;
            btnDeleteQuesiton.FlatStyle = FlatStyle.Flat;
            btnDeleteQuesiton.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteQuesiton.ForeColor = Color.White;
            btnDeleteQuesiton.Image = null;
            btnDeleteQuesiton.ImageSize = new Size(150, 40);
            btnDeleteQuesiton.Location = new Point(168, 487);
            btnDeleteQuesiton.Margin = new Padding(5);
            btnDeleteQuesiton.Name = "btnDeleteQuesiton";
            btnDeleteQuesiton.Size = new Size(186, 40);
            btnDeleteQuesiton.TabIndex = 5;
            btnDeleteQuesiton.Text = "Delete Question";
            btnDeleteQuesiton.UseVisualStyleBackColor = false;
            btnDeleteQuesiton.Click += btnDeleteQuestion_Click;
            // 
            // lbQuestionSelector
            // 
            lbQuestionSelector.Anchor = AnchorStyles.None;
            lbQuestionSelector.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuestionSelector.FormattingEnabled = true;
            lbQuestionSelector.ItemHeight = 23;
            lbQuestionSelector.Location = new Point(80, 216);
            lbQuestionSelector.Name = "lbQuestionSelector";
            lbQuestionSelector.Size = new Size(493, 257);
            lbQuestionSelector.TabIndex = 7;
            lbQuestionSelector.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnAddQuesiton
            // 
            btnAddQuesiton.Anchor = AnchorStyles.None;
            btnAddQuesiton.BackColor = Color.FromArgb(0, 150, 255);
            btnAddQuesiton.BorderColor = Color.White;
            btnAddQuesiton.BorderWidth = 2;
            btnAddQuesiton.CornerRadius = 15;
            btnAddQuesiton.FlatAppearance.BorderSize = 0;
            btnAddQuesiton.FlatStyle = FlatStyle.Flat;
            btnAddQuesiton.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddQuesiton.ForeColor = Color.White;
            btnAddQuesiton.Image = null;
            btnAddQuesiton.ImageSize = new Size(150, 40);
            btnAddQuesiton.Location = new Point(455, 540);
            btnAddQuesiton.Margin = new Padding(5);
            btnAddQuesiton.Name = "btnAddQuesiton";
            btnAddQuesiton.Size = new Size(144, 40);
            btnAddQuesiton.TabIndex = 5;
            btnAddQuesiton.Text = "Add question";
            btnAddQuesiton.UseVisualStyleBackColor = false;
            btnAddQuesiton.Click += btnDeleteQuestion_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(80, 545);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(367, 33);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.BackColor = Color.White;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(213, 177);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(360, 33);
            comboBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 180);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 26);
            label1.TabIndex = 9;
            label1.Text = "Question type:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formAddQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(650, 600);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(lbQuestionSelector);
            Controls.Add(comboBox1);
            Controls.Add(btnAddQuesiton);
            Controls.Add(btnDeleteQuesiton);
            Controls.Add(tbSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnTestQuestion);
            Controls.Add(lblAdminInfo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formAddQuestions";
            Text = "formUserHome";
            Load += formAddQuestions_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblAdminInfo;
        private Custom_Controls.CustomButton btnTestQuestion;
        private Custom_Controls.CustomTextbox tbSearch;
        private Custom_Controls.CustomButton btnSearch;
        private Custom_Controls.CustomButton btnDeleteQuesiton;
        private ListBox lbQuestionSelector;
        private Custom_Controls.CustomButton btnAddQuesiton;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
    }
}
