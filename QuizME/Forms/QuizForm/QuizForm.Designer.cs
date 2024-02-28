namespace QuizME.Forms.QuizForm
{
    partial class QuizForm
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
            this.gbQuizMain = new System.Windows.Forms.GroupBox();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblMarks = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.btnTrueFalse = new System.Windows.Forms.Button();
            this.lvQuestions = new System.Windows.Forms.ListView();
            this.colHeadQuestion = new System.Windows.Forms.ColumnHeader();
            this.colHeadType = new System.Windows.Forms.ColumnHeader();
            this.btnNumerical = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.gbQuizMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbQuizMain
            // 
            this.gbQuizMain.Controls.Add(this.rtbInstructions);
            this.gbQuizMain.Controls.Add(this.lblInstructions);
            this.gbQuizMain.Controls.Add(this.textBox4);
            this.gbQuizMain.Controls.Add(this.lblMarks);
            this.gbQuizMain.Controls.Add(this.textBox3);
            this.gbQuizMain.Controls.Add(this.lblDescription);
            this.gbQuizMain.Controls.Add(this.textBox2);
            this.gbQuizMain.Controls.Add(this.lblTopic);
            this.gbQuizMain.Controls.Add(this.textBox1);
            this.gbQuizMain.Controls.Add(this.lblModule);
            this.gbQuizMain.Location = new System.Drawing.Point(24, 14);
            this.gbQuizMain.Name = "gbQuizMain";
            this.gbQuizMain.Size = new System.Drawing.Size(747, 177);
            this.gbQuizMain.TabIndex = 0;
            this.gbQuizMain.TabStop = false;
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInstructions.Location = new System.Drawing.Point(419, 16);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.Size = new System.Drawing.Size(305, 136);
            this.rtbInstructions.TabIndex = 9;
            this.rtbInstructions.Text = "";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(309, 16);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(103, 23);
            this.lblInstructions.TabIndex = 8;
            this.lblInstructions.Text = "Instructions";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(123, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 26);
            this.textBox4.TabIndex = 7;
            // 
            // lblMarks
            // 
            this.lblMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(18, 128);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(99, 23);
            this.lblMarks.TabIndex = 6;
            this.lblMarks.Text = "Marks:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(123, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 26);
            this.textBox3.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(18, 88);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(99, 23);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(122, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 26);
            this.textBox2.TabIndex = 3;
            // 
            // lblTopic
            // 
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Location = new System.Drawing.Point(18, 53);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(77, 23);
            this.lblTopic.TabIndex = 2;
            this.lblTopic.Text = "Topic:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(122, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 26);
            this.textBox1.TabIndex = 1;
            // 
            // lblModule
            // 
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModule.Location = new System.Drawing.Point(18, 16);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(77, 23);
            this.lblModule.TabIndex = 0;
            this.lblModule.Text = "Module:";
            // 
            // btnTrueFalse
            // 
            this.btnTrueFalse.Location = new System.Drawing.Point(381, 197);
            this.btnTrueFalse.Name = "btnTrueFalse";
            this.btnTrueFalse.Size = new System.Drawing.Size(129, 42);
            this.btnTrueFalse.TabIndex = 2;
            this.btnTrueFalse.Text = "True False";
            this.btnTrueFalse.UseVisualStyleBackColor = true;
            this.btnTrueFalse.Click += new System.EventHandler(this.btnTrueFalse_Click);
            // 
            // lvQuestions
            // 
            this.lvQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.colHeadQuestion, this.colHeadType });
            this.lvQuestions.HideSelection = false;
            this.lvQuestions.Location = new System.Drawing.Point(24, 196);
            this.lvQuestions.Name = "lvQuestions";
            this.lvQuestions.Size = new System.Drawing.Size(347, 357);
            this.lvQuestions.TabIndex = 3;
            this.lvQuestions.UseCompatibleStateImageBehavior = false;
            this.lvQuestions.View = System.Windows.Forms.View.Details;
            // 
            // colHeadQuestion
            // 
            this.colHeadQuestion.Text = "Question:";
            this.colHeadQuestion.Width = 243;
            // 
            // colHeadType
            // 
            this.colHeadType.Text = "Type";
            this.colHeadType.Width = 100;
            // 
            // btnNumerical
            // 
            this.btnNumerical.Location = new System.Drawing.Point(516, 197);
            this.btnNumerical.Name = "btnNumerical";
            this.btnNumerical.Size = new System.Drawing.Size(129, 42);
            this.btnNumerical.TabIndex = 4;
            this.btnNumerical.Text = "Numerical";
            this.btnNumerical.UseVisualStyleBackColor = true;
            this.btnNumerical.Click += new System.EventHandler(this.btnNumerical_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(651, 197);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(129, 42);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 564);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnNumerical);
            this.Controls.Add(this.lvQuestions);
            this.Controls.Add(this.btnTrueFalse);
            this.Controls.Add(this.gbQuizMain);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "QuizForm";
            this.gbQuizMain.ResumeLayout(false);
            this.gbQuizMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnOpen;

        private System.Windows.Forms.Button btnNumerical;

        private System.Windows.Forms.ColumnHeader colHeadType;
        private System.Windows.Forms.ColumnHeader colHeadQuestion;

        private System.Windows.Forms.ListView lvQuestions;

        private System.Windows.Forms.Button btnTrueFalse;

        private System.Windows.Forms.RichTextBox rtbInstructions;

        private System.Windows.Forms.Label lblInstructions;

        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.GroupBox gbQuizMain;


        #endregion
    }
}