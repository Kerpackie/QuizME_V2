namespace QuizME.Forms.Questions.TrueFalseForm
{
    partial class TrueFalseForm
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
            gbTrueFalse = new GroupBox();
            lblAnswer = new Label();
            rbFalse = new RadioButton();
            rbTrue = new RadioButton();
            gbTrueFalse.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(798, 21);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 31);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(798, 69);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 31);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblText
            // 
            lblText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblText.Location = new Point(36, 24);
            lblText.Margin = new Padding(4, 0, 4, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(89, 27);
            lblText.TabIndex = 2;
            lblText.Text = "Text:";
            // 
            // lblMarks
            // 
            lblMarks.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarks.Location = new Point(565, 73);
            lblMarks.Margin = new Padding(4, 0, 4, 0);
            lblMarks.Name = "lblMarks";
            lblMarks.Size = new Size(71, 27);
            lblMarks.TabIndex = 3;
            lblMarks.Text = "Marks:";
            // 
            // tbText
            // 
            tbText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbText.Location = new Point(132, 21);
            tbText.Margin = new Padding(4, 3, 4, 3);
            tbText.Name = "tbText";
            tbText.Size = new Size(643, 26);
            tbText.TabIndex = 4;
            // 
            // tbMarks
            // 
            tbMarks.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMarks.Location = new Point(643, 69);
            tbMarks.Margin = new Padding(4, 3, 4, 3);
            tbMarks.Name = "tbMarks";
            tbMarks.Size = new Size(132, 26);
            tbMarks.TabIndex = 5;
            // 
            // gbTrueFalse
            // 
            gbTrueFalse.Controls.Add(lblAnswer);
            gbTrueFalse.Controls.Add(rbFalse);
            gbTrueFalse.Controls.Add(rbTrue);
            gbTrueFalse.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbTrueFalse.Location = new Point(36, 128);
            gbTrueFalse.Margin = new Padding(4, 3, 4, 3);
            gbTrueFalse.Name = "gbTrueFalse";
            gbTrueFalse.Padding = new Padding(4, 3, 4, 3);
            gbTrueFalse.Size = new Size(875, 118);
            gbTrueFalse.TabIndex = 8;
            gbTrueFalse.TabStop = false;
            gbTrueFalse.Text = "True False";
            // 
            // lblAnswer
            // 
            lblAnswer.Location = new Point(96, 53);
            lblAnswer.Margin = new Padding(4, 0, 4, 0);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(88, 27);
            lblAnswer.TabIndex = 2;
            lblAnswer.Text = "Answer:";
            // 
            // rbFalse
            // 
            rbFalse.Location = new Point(528, 51);
            rbFalse.Margin = new Padding(4, 3, 4, 3);
            rbFalse.Name = "rbFalse";
            rbFalse.Size = new Size(121, 28);
            rbFalse.TabIndex = 1;
            rbFalse.TabStop = true;
            rbFalse.Text = "False";
            rbFalse.UseVisualStyleBackColor = true;
            // 
            // rbTrue
            // 
            rbTrue.Location = new Point(267, 51);
            rbTrue.Margin = new Padding(4, 3, 4, 3);
            rbTrue.Name = "rbTrue";
            rbTrue.Size = new Size(121, 28);
            rbTrue.TabIndex = 0;
            rbTrue.TabStop = true;
            rbTrue.Text = "True";
            rbTrue.UseVisualStyleBackColor = true;
            // 
            // TrueFalseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 268);
            Controls.Add(gbTrueFalse);
            Controls.Add(tbMarks);
            Controls.Add(tbText);
            Controls.Add(lblMarks);
            Controls.Add(lblText);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TrueFalseForm";
            Text = "TrueFalseForm";
            gbTrueFalse.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.RadioButton rbTrue;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.Label lblAnswer;

        private System.Windows.Forms.GroupBox gbTrueFalse;

        private System.Windows.Forms.GroupBox gbPreview;

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblMarks;
        public System.Windows.Forms.TextBox tbText;
        public System.Windows.Forms.TextBox tbMarks;


        #endregion
    }
}