namespace QuizME.Forms.Questions.MultiChoiceForm
{
    partial class MultiChoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new Button();
            btnSave = new Button();
            lblText = new Label();
            lblMarks = new Label();
            tbText = new TextBox();
            tbMarks = new TextBox();
            gbMultiChoice = new GroupBox();
            lblOption1 = new Label();
            lblOption2 = new Label();
            lblOption4 = new Label();
            lblOption3 = new Label();
            tbOption1 = new TextBox();
            tbOption2 = new TextBox();
            tbOption3 = new TextBox();
            tbOption4 = new TextBox();
            rbOption1 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption3 = new RadioButton();
            rbOption4 = new RadioButton();
            gbMultiChoice.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(684, 18);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 27);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(684, 60);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 27);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblText
            // 
            lblText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblText.Location = new Point(31, 21);
            lblText.Name = "lblText";
            lblText.Size = new Size(76, 23);
            lblText.TabIndex = 2;
            lblText.Text = "Text:";
            // 
            // lblMarks
            // 
            lblMarks.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarks.Location = new Point(484, 63);
            lblMarks.Name = "lblMarks";
            lblMarks.Size = new Size(61, 23);
            lblMarks.TabIndex = 3;
            lblMarks.Text = "Marks:";
            // 
            // tbText
            // 
            tbText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbText.Location = new Point(113, 18);
            tbText.Name = "tbText";
            tbText.Size = new Size(552, 26);
            tbText.TabIndex = 4;
            // 
            // tbMarks
            // 
            tbMarks.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMarks.Location = new Point(551, 60);
            tbMarks.Name = "tbMarks";
            tbMarks.Size = new Size(114, 26);
            tbMarks.TabIndex = 5;
            // 
            // gbMultiChoice
            // 
            gbMultiChoice.Controls.Add(rbOption4);
            gbMultiChoice.Controls.Add(rbOption3);
            gbMultiChoice.Controls.Add(rbOption2);
            gbMultiChoice.Controls.Add(rbOption1);
            gbMultiChoice.Controls.Add(tbOption4);
            gbMultiChoice.Controls.Add(tbOption3);
            gbMultiChoice.Controls.Add(tbOption2);
            gbMultiChoice.Controls.Add(tbOption1);
            gbMultiChoice.Controls.Add(lblOption3);
            gbMultiChoice.Controls.Add(lblOption4);
            gbMultiChoice.Controls.Add(lblOption2);
            gbMultiChoice.Controls.Add(lblOption1);
            gbMultiChoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbMultiChoice.Location = new Point(31, 106);
            gbMultiChoice.Name = "gbMultiChoice";
            gbMultiChoice.Size = new Size(751, 152);
            gbMultiChoice.TabIndex = 6;
            gbMultiChoice.TabStop = false;
            gbMultiChoice.Text = "Multi Choice";
            // 
            // lblOption1
            // 
            lblOption1.AutoSize = true;
            lblOption1.Location = new Point(21, 37);
            lblOption1.Name = "lblOption1";
            lblOption1.Size = new Size(74, 21);
            lblOption1.TabIndex = 0;
            lblOption1.Text = "Option 1:";
            // 
            // lblOption2
            // 
            lblOption2.AutoSize = true;
            lblOption2.Location = new Point(21, 86);
            lblOption2.Name = "lblOption2";
            lblOption2.Size = new Size(74, 21);
            lblOption2.TabIndex = 1;
            lblOption2.Text = "Option 2:";
            // 
            // lblOption4
            // 
            lblOption4.AutoSize = true;
            lblOption4.Location = new Point(391, 86);
            lblOption4.Name = "lblOption4";
            lblOption4.Size = new Size(74, 21);
            lblOption4.TabIndex = 2;
            lblOption4.Text = "Option 4:";
            // 
            // lblOption3
            // 
            lblOption3.AutoSize = true;
            lblOption3.Location = new Point(391, 37);
            lblOption3.Name = "lblOption3";
            lblOption3.Size = new Size(74, 21);
            lblOption3.TabIndex = 3;
            lblOption3.Text = "Option 3:";
            // 
            // tbOption1
            // 
            tbOption1.Location = new Point(101, 34);
            tbOption1.Name = "tbOption1";
            tbOption1.Size = new Size(163, 29);
            tbOption1.TabIndex = 4;
            // 
            // tbOption2
            // 
            tbOption2.Location = new Point(101, 83);
            tbOption2.Name = "tbOption2";
            tbOption2.Size = new Size(163, 29);
            tbOption2.TabIndex = 5;
            // 
            // tbOption3
            // 
            tbOption3.Location = new Point(471, 34);
            tbOption3.Name = "tbOption3";
            tbOption3.Size = new Size(163, 29);
            tbOption3.TabIndex = 6;
            // 
            // tbOption4
            // 
            tbOption4.Location = new Point(471, 83);
            tbOption4.Name = "tbOption4";
            tbOption4.Size = new Size(163, 29);
            tbOption4.TabIndex = 7;
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.Location = new Point(270, 33);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(79, 25);
            rbOption1.TabIndex = 8;
            rbOption1.TabStop = true;
            rbOption1.Text = "Correct";
            rbOption1.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.Location = new Point(270, 82);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(79, 25);
            rbOption2.TabIndex = 9;
            rbOption2.TabStop = true;
            rbOption2.Text = "Correct";
            rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.Location = new Point(640, 34);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(79, 25);
            rbOption3.TabIndex = 10;
            rbOption3.TabStop = true;
            rbOption3.Text = "Correct";
            rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption4
            // 
            rbOption4.AutoSize = true;
            rbOption4.Location = new Point(640, 82);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(79, 25);
            rbOption4.TabIndex = 11;
            rbOption4.TabStop = true;
            rbOption4.Text = "Correct";
            rbOption4.UseVisualStyleBackColor = true;
            // 
            // MultiChoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 289);
            Controls.Add(gbMultiChoice);
            Controls.Add(tbMarks);
            Controls.Add(tbText);
            Controls.Add(lblMarks);
            Controls.Add(lblText);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "MultiChoiceForm";
            Text = "MultiChoiceForm";
            gbMultiChoice.ResumeLayout(false);
            gbMultiChoice.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblMarks;
        public System.Windows.Forms.TextBox tbText;
        public System.Windows.Forms.TextBox tbMarks;

        #endregion

        private GroupBox gbMultiChoice;
        private TextBox tbOption4;
        private TextBox tbOption3;
        private TextBox tbOption2;
        private TextBox tbOption1;
        private Label lblOption3;
        private Label lblOption4;
        private Label lblOption2;
        private Label lblOption1;
        private RadioButton rbOption4;
        private RadioButton rbOption3;
        private RadioButton rbOption2;
        private RadioButton rbOption1;
    }
}