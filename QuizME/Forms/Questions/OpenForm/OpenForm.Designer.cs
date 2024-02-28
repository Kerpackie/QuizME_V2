namespace QuizME.Forms.Questions.OpenForm
{
    partial class OpenForm
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
            this.gbOpenQuestion = new System.Windows.Forms.GroupBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbMarks = new System.Windows.Forms.TextBox();
            this.gbOpenQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpenQuestion
            // 
            this.gbOpenQuestion.Controls.Add(this.lblNotes);
            this.gbOpenQuestion.Controls.Add(this.rtbNotes);
            this.gbOpenQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpenQuestion.Location = new System.Drawing.Point(36, 108);
            this.gbOpenQuestion.Name = "gbOpenQuestion";
            this.gbOpenQuestion.Size = new System.Drawing.Size(745, 323);
            this.gbOpenQuestion.TabIndex = 6;
            this.gbOpenQuestion.TabStop = false;
            this.gbOpenQuestion.Text = "Open Question";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(22, 60);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(705, 243);
            this.rtbNotes.TabIndex = 0;
            this.rtbNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.Location = new System.Drawing.Point(22, 34);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(100, 23);
            this.lblNotes.TabIndex = 1;
            this.lblNotes.Text = "Notes:";
            // Base form stuff

            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(684, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 27);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(684, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 27);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(31, 21);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(76, 23);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Text:";
            // 
            // lblMarks
            // 
            this.lblMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(484, 63);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(61, 23);
            this.lblMarks.TabIndex = 3;
            this.lblMarks.Text = "Marks:";
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbText.Location = new System.Drawing.Point(113, 18);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(552, 26);
            this.tbText.TabIndex = 4;
            // 
            // tbMarks
            // 
            this.tbMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarks.Location = new System.Drawing.Point(551, 60);
            this.tbMarks.Name = "tbMarks";
            this.tbMarks.Size = new System.Drawing.Size(114, 26);
            this.tbMarks.TabIndex = 5;

            // 
            // OpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbOpenQuestion);
            this.Controls.Add(this.tbMarks);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "OpenForm";
            this.Text = "OpenForm";
            this.Controls.SetChildIndex(this.gbOpenQuestion, 0);
            this.gbOpenQuestion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label lblNotes;

        private System.Windows.Forms.GroupBox gbOpenQuestion;

        // Base Form Components

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblMarks;
        public System.Windows.Forms.TextBox tbText;
        public System.Windows.Forms.TextBox tbMarks;




        #endregion
    }
}