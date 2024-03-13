namespace AS_Coursework.View {
    partial class formQuizSettings {
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
        /// the contents of this m
        /// </summary>
        private void InitializeComponent() {
            lblQuizInfo = new Label();
            upDownMultipleChoice = new NumericUpDown();
            upDownMatching = new NumericUpDown();
            upDownTyping = new NumericUpDown();
            upDownEquations = new NumericUpDown();
            upDownFlashcards = new NumericUpDown();
            label1 = new Label();
            upDownQuestionCount = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)upDownMultipleChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownMatching).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownTyping).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownEquations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownFlashcards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownQuestionCount).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuizInfo
            // 
            lblQuizInfo.Anchor = AnchorStyles.None;
            lblQuizInfo.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuizInfo.ForeColor = Color.White;
            lblQuizInfo.Location = new Point(112, 18);
            lblQuizInfo.Margin = new Padding(18, 0, 18, 0);
            lblQuizInfo.Name = "lblQuizInfo";
            lblQuizInfo.Size = new Size(420, 90);
            lblQuizInfo.TabIndex = 6;
            lblQuizInfo.Text = "Here are the quiz settings. You can adjust these as you see fit. Changes will be applied instantly";
            lblQuizInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // upDownMultipleChoice
            // 
            upDownMultipleChoice.BorderStyle = BorderStyle.None;
            upDownMultipleChoice.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point);
            upDownMultipleChoice.Location = new Point(201, 0);
            upDownMultipleChoice.Margin = new Padding(10);
            upDownMultipleChoice.Name = "upDownMultipleChoice";
            upDownMultipleChoice.Size = new Size(156, 29);
            upDownMultipleChoice.TabIndex = 7;
            upDownMultipleChoice.TextAlign = HorizontalAlignment.Center;
            upDownMultipleChoice.ValueChanged += upDownMultipleChoice_ValueChanged;
            // 
            // upDownMatching
            // 
            upDownMatching.BorderStyle = BorderStyle.None;
            upDownMatching.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point);
            upDownMatching.Location = new Point(201, 49);
            upDownMatching.Margin = new Padding(10);
            upDownMatching.Name = "upDownMatching";
            upDownMatching.Size = new Size(156, 29);
            upDownMatching.TabIndex = 7;
            upDownMatching.TextAlign = HorizontalAlignment.Center;
            upDownMatching.ValueChanged += upDownMatching_ValueChanged;
            // 
            // upDownTyping
            // 
            upDownTyping.BorderStyle = BorderStyle.None;
            upDownTyping.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point);
            upDownTyping.Location = new Point(201, 98);
            upDownTyping.Margin = new Padding(10);
            upDownTyping.Name = "upDownTyping";
            upDownTyping.Size = new Size(156, 29);
            upDownTyping.TabIndex = 7;
            upDownTyping.TextAlign = HorizontalAlignment.Center;
            upDownTyping.ValueChanged += upDownTyping_ValueChanged;
            // 
            // upDownEquations
            // 
            upDownEquations.BorderStyle = BorderStyle.None;
            upDownEquations.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point);
            upDownEquations.Location = new Point(201, 147);
            upDownEquations.Margin = new Padding(10);
            upDownEquations.Name = "upDownEquations";
            upDownEquations.Size = new Size(156, 29);
            upDownEquations.TabIndex = 7;
            upDownEquations.TextAlign = HorizontalAlignment.Center;
            upDownEquations.ValueChanged += upDownEquations_ValueChanged;
            // 
            // upDownFlashcards
            // 
            upDownFlashcards.Anchor = AnchorStyles.None;
            upDownFlashcards.BorderStyle = BorderStyle.None;
            upDownFlashcards.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point);
            upDownFlashcards.Location = new Point(201, 196);
            upDownFlashcards.Margin = new Padding(10);
            upDownFlashcards.Name = "upDownFlashcards";
            upDownFlashcards.Size = new Size(156, 29);
            upDownFlashcards.TabIndex = 7;
            upDownFlashcards.TextAlign = HorizontalAlignment.Center;
            upDownFlashcards.ValueChanged += upDownFlashcards_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(147, 144);
            label1.Margin = new Padding(18, 0, 18, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 29);
            label1.TabIndex = 8;
            label1.Text = "Question count: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // upDownQuestionCount
            // 
            upDownQuestionCount.Anchor = AnchorStyles.None;
            upDownQuestionCount.BorderStyle = BorderStyle.None;
            upDownQuestionCount.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point);
            upDownQuestionCount.Location = new Point(348, 144);
            upDownQuestionCount.Margin = new Padding(10);
            upDownQuestionCount.Name = "upDownQuestionCount";
            upDownQuestionCount.Size = new Size(156, 29);
            upDownQuestionCount.TabIndex = 7;
            upDownQuestionCount.TextAlign = HorizontalAlignment.Center;
            upDownQuestionCount.ValueChanged += upDownQuestionCount_ValueChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(18, 0, 18, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 29);
            label2.TabIndex = 8;
            label2.Text = "Multiple choice:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 49);
            label3.Margin = new Padding(18, 0, 18, 0);
            label3.Name = "label3";
            label3.Size = new Size(170, 29);
            label3.TabIndex = 8;
            label3.Text = "Matching:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 98);
            label4.Margin = new Padding(18, 0, 18, 0);
            label4.Name = "label4";
            label4.Size = new Size(170, 29);
            label4.TabIndex = 8;
            label4.Text = "Typing:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 147);
            label5.Margin = new Padding(18, 0, 18, 0);
            label5.Name = "label5";
            label5.Size = new Size(170, 29);
            label5.TabIndex = 8;
            label5.Text = "Equations:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 196);
            label6.Margin = new Padding(18, 0, 18, 0);
            label6.Name = "label6";
            label6.Size = new Size(170, 29);
            label6.TabIndex = 8;
            label6.Text = "Flashcards:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(upDownMultipleChoice);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(upDownMatching);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(upDownTyping);
            panel1.Controls.Add(upDownEquations);
            panel1.Controls.Add(upDownFlashcards);
            panel1.Location = new Point(147, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 228);
            panel1.TabIndex = 9;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(214, 211);
            label7.Margin = new Padding(18, 0, 18, 0);
            label7.Name = "label7";
            label7.Size = new Size(244, 29);
            label7.TabIndex = 8;
            label7.Text = "Experience Allocation";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formQuizSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(650, 600);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(upDownQuestionCount);
            Controls.Add(lblQuizInfo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formQuizSettings";
            Text = "formUserHome";
            ((System.ComponentModel.ISupportInitialize)upDownMultipleChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownMatching).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownTyping).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownEquations).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownFlashcards).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownQuestionCount).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblQuizInfo;
        private NumericUpDown upDownMultipleChoice;
        private NumericUpDown upDownMatching;
        private NumericUpDown upDownTyping;
        private NumericUpDown upDownEquations;
        private NumericUpDown upDownFlashcards;
        private Label label1;
        private NumericUpDown upDownQuestionCount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label label7;
    }
}
