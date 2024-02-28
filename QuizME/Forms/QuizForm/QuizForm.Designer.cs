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
            gbQuizMain = new GroupBox();
            rtbInstructions = new RichTextBox();
            lblInstructions = new Label();
            tbMarks = new TextBox();
            lblMarks = new Label();
            tbDescription = new TextBox();
            lblDescription = new Label();
            tbTopic = new TextBox();
            lblTopic = new Label();
            tbModule = new TextBox();
            lblModule = new Label();
            btnTrueFalse = new Button();
            lvQuestions = new ListView();
            colHeadQuestion = new ColumnHeader();
            colHeadType = new ColumnHeader();
            btnNumerical = new Button();
            btnOpen = new Button();
            gbAddQuestion = new GroupBox();
            btnMultiChoice = new Button();
            gbAdmin = new GroupBox();
            btnGenerateStudentVersionPDF = new Button();
            btnGenerateTutorVersionPDF = new Button();
            btnSaveQuiz = new Button();
            btnLoadQuiz = new Button();
            gbQuizMain.SuspendLayout();
            gbAddQuestion.SuspendLayout();
            gbAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // gbQuizMain
            // 
            gbQuizMain.Controls.Add(rtbInstructions);
            gbQuizMain.Controls.Add(lblInstructions);
            gbQuizMain.Controls.Add(tbMarks);
            gbQuizMain.Controls.Add(lblMarks);
            gbQuizMain.Controls.Add(tbDescription);
            gbQuizMain.Controls.Add(lblDescription);
            gbQuizMain.Controls.Add(tbTopic);
            gbQuizMain.Controls.Add(lblTopic);
            gbQuizMain.Controls.Add(tbModule);
            gbQuizMain.Controls.Add(lblModule);
            gbQuizMain.Location = new Point(28, 16);
            gbQuizMain.Margin = new Padding(4, 3, 4, 3);
            gbQuizMain.Name = "gbQuizMain";
            gbQuizMain.Padding = new Padding(4, 3, 4, 3);
            gbQuizMain.Size = new Size(872, 204);
            gbQuizMain.TabIndex = 0;
            gbQuizMain.TabStop = false;
            // 
            // rtbInstructions
            // 
            rtbInstructions.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbInstructions.Location = new Point(489, 18);
            rtbInstructions.Margin = new Padding(4, 3, 4, 3);
            rtbInstructions.Name = "rtbInstructions";
            rtbInstructions.Size = new Size(355, 156);
            rtbInstructions.TabIndex = 9;
            rtbInstructions.Text = "";
            // 
            // lblInstructions
            // 
            lblInstructions.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInstructions.Location = new Point(360, 18);
            lblInstructions.Margin = new Padding(4, 0, 4, 0);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(120, 27);
            lblInstructions.TabIndex = 8;
            lblInstructions.Text = "Instructions";
            // 
            // tbMarks
            // 
            tbMarks.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMarks.Location = new Point(144, 144);
            tbMarks.Margin = new Padding(4, 3, 4, 3);
            tbMarks.Name = "tbMarks";
            tbMarks.Size = new Size(188, 26);
            tbMarks.TabIndex = 7;
            // 
            // lblMarks
            // 
            lblMarks.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarks.Location = new Point(21, 148);
            lblMarks.Margin = new Padding(4, 0, 4, 0);
            lblMarks.Name = "lblMarks";
            lblMarks.Size = new Size(115, 27);
            lblMarks.TabIndex = 6;
            lblMarks.Text = "Marks:";
            // 
            // tbDescription
            // 
            tbDescription.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescription.Location = new Point(144, 98);
            tbDescription.Margin = new Padding(4, 3, 4, 3);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(188, 26);
            tbDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(21, 102);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(115, 27);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description:";
            // 
            // tbTopic
            // 
            tbTopic.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbTopic.Location = new Point(142, 58);
            tbTopic.Margin = new Padding(4, 3, 4, 3);
            tbTopic.Name = "tbTopic";
            tbTopic.Size = new Size(188, 26);
            tbTopic.TabIndex = 3;
            // 
            // lblTopic
            // 
            lblTopic.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTopic.Location = new Point(21, 61);
            lblTopic.Margin = new Padding(4, 0, 4, 0);
            lblTopic.Name = "lblTopic";
            lblTopic.Size = new Size(90, 27);
            lblTopic.TabIndex = 2;
            lblTopic.Text = "Topic:";
            // 
            // tbModule
            // 
            tbModule.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbModule.Location = new Point(142, 15);
            tbModule.Margin = new Padding(4, 3, 4, 3);
            tbModule.Name = "tbModule";
            tbModule.Size = new Size(188, 26);
            tbModule.TabIndex = 1;
            // 
            // lblModule
            // 
            lblModule.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblModule.Location = new Point(21, 18);
            lblModule.Margin = new Padding(4, 0, 4, 0);
            lblModule.Name = "lblModule";
            lblModule.Size = new Size(90, 27);
            lblModule.TabIndex = 0;
            lblModule.Text = "Module:";
            // 
            // btnTrueFalse
            // 
            btnTrueFalse.Location = new Point(7, 28);
            btnTrueFalse.Margin = new Padding(4, 3, 4, 3);
            btnTrueFalse.Name = "btnTrueFalse";
            btnTrueFalse.Size = new Size(114, 48);
            btnTrueFalse.TabIndex = 2;
            btnTrueFalse.Text = "True False";
            btnTrueFalse.UseVisualStyleBackColor = true;
            btnTrueFalse.Click += btnTrueFalse_Click;
            // 
            // lvQuestions
            // 
            lvQuestions.Columns.AddRange(new ColumnHeader[] { colHeadQuestion, colHeadType });
            lvQuestions.Location = new Point(28, 226);
            lvQuestions.Margin = new Padding(4, 3, 4, 3);
            lvQuestions.Name = "lvQuestions";
            lvQuestions.Size = new Size(404, 411);
            lvQuestions.TabIndex = 3;
            lvQuestions.UseCompatibleStateImageBehavior = false;
            lvQuestions.View = View.Details;
            // 
            // colHeadQuestion
            // 
            colHeadQuestion.Text = "Question:";
            colHeadQuestion.Width = 243;
            // 
            // colHeadType
            // 
            colHeadType.Text = "Type";
            colHeadType.Width = 100;
            // 
            // btnNumerical
            // 
            btnNumerical.Location = new Point(128, 28);
            btnNumerical.Margin = new Padding(4, 3, 4, 3);
            btnNumerical.Name = "btnNumerical";
            btnNumerical.Size = new Size(114, 48);
            btnNumerical.TabIndex = 4;
            btnNumerical.Text = "Numerical";
            btnNumerical.UseVisualStyleBackColor = true;
            btnNumerical.Click += btnNumerical_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(7, 82);
            btnOpen.Margin = new Padding(4, 3, 4, 3);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(114, 48);
            btnOpen.TabIndex = 5;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // gbAddQuestion
            // 
            gbAddQuestion.Controls.Add(btnMultiChoice);
            gbAddQuestion.Controls.Add(btnTrueFalse);
            gbAddQuestion.Controls.Add(btnOpen);
            gbAddQuestion.Controls.Add(btnNumerical);
            gbAddQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbAddQuestion.Location = new Point(444, 229);
            gbAddQuestion.Name = "gbAddQuestion";
            gbAddQuestion.Size = new Size(249, 250);
            gbAddQuestion.TabIndex = 6;
            gbAddQuestion.TabStop = false;
            gbAddQuestion.Text = "Add Question";
            // 
            // btnMultiChoice
            // 
            btnMultiChoice.Location = new Point(128, 82);
            btnMultiChoice.Margin = new Padding(4, 3, 4, 3);
            btnMultiChoice.Name = "btnMultiChoice";
            btnMultiChoice.Size = new Size(114, 48);
            btnMultiChoice.TabIndex = 6;
            btnMultiChoice.Text = "MultiChoice";
            btnMultiChoice.UseVisualStyleBackColor = true;
            btnMultiChoice.Click += btnMultiChoice_Click;
            // 
            // gbAdmin
            // 
            gbAdmin.Controls.Add(btnGenerateStudentVersionPDF);
            gbAdmin.Controls.Add(btnGenerateTutorVersionPDF);
            gbAdmin.Controls.Add(btnSaveQuiz);
            gbAdmin.Controls.Add(btnLoadQuiz);
            gbAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbAdmin.Location = new Point(709, 229);
            gbAdmin.Name = "gbAdmin";
            gbAdmin.Size = new Size(191, 250);
            gbAdmin.TabIndex = 7;
            gbAdmin.TabStop = false;
            gbAdmin.Text = "Save/Load:";
            // 
            // btnGenerateStudentVersionPDF
            // 
            btnGenerateStudentVersionPDF.Location = new Point(7, 190);
            btnGenerateStudentVersionPDF.Margin = new Padding(4, 3, 4, 3);
            btnGenerateStudentVersionPDF.Name = "btnGenerateStudentVersionPDF";
            btnGenerateStudentVersionPDF.Size = new Size(177, 48);
            btnGenerateStudentVersionPDF.TabIndex = 7;
            btnGenerateStudentVersionPDF.Text = "GenerateStudentPDF";
            btnGenerateStudentVersionPDF.UseVisualStyleBackColor = true;
            btnGenerateStudentVersionPDF.Click += btnGenerateStudentVersionPDF_Click;
            // 
            // btnGenerateTutorVersionPDF
            // 
            btnGenerateTutorVersionPDF.Location = new Point(7, 136);
            btnGenerateTutorVersionPDF.Margin = new Padding(4, 3, 4, 3);
            btnGenerateTutorVersionPDF.Name = "btnGenerateTutorVersionPDF";
            btnGenerateTutorVersionPDF.Size = new Size(177, 48);
            btnGenerateTutorVersionPDF.TabIndex = 6;
            btnGenerateTutorVersionPDF.Text = "Generate Tutor PDF";
            btnGenerateTutorVersionPDF.UseVisualStyleBackColor = true;
            btnGenerateTutorVersionPDF.Click += btnGenerateTutorVersionPDF_Click;
            // 
            // btnSaveQuiz
            // 
            btnSaveQuiz.Location = new Point(7, 28);
            btnSaveQuiz.Margin = new Padding(4, 3, 4, 3);
            btnSaveQuiz.Name = "btnSaveQuiz";
            btnSaveQuiz.Size = new Size(177, 48);
            btnSaveQuiz.TabIndex = 2;
            btnSaveQuiz.Text = "Save";
            btnSaveQuiz.UseVisualStyleBackColor = true;
            btnSaveQuiz.Click += btnSaveQuiz_Click;
            // 
            // btnLoadQuiz
            // 
            btnLoadQuiz.Location = new Point(7, 82);
            btnLoadQuiz.Margin = new Padding(4, 3, 4, 3);
            btnLoadQuiz.Name = "btnLoadQuiz";
            btnLoadQuiz.Size = new Size(177, 48);
            btnLoadQuiz.TabIndex = 5;
            btnLoadQuiz.Text = "Load";
            btnLoadQuiz.UseVisualStyleBackColor = true;
            btnLoadQuiz.Click += btnLoadQuiz_Click;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(926, 651);
            Controls.Add(gbAdmin);
            Controls.Add(gbAddQuestion);
            Controls.Add(lvQuestions);
            Controls.Add(gbQuizMain);
            Location = new Point(15, 15);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "QuizForm";
            gbQuizMain.ResumeLayout(false);
            gbQuizMain.PerformLayout();
            gbAddQuestion.ResumeLayout(false);
            gbAdmin.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tbMarks;

        private System.Windows.Forms.TextBox tbModule;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbDescription;

        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.GroupBox gbQuizMain;


        #endregion

        private GroupBox gbAddQuestion;
        private Button btnMultiChoice;
        private GroupBox gbAdmin;
        private Button btnGenerateStudentVersionPDF;
        private Button btnGenerateTutorVersionPDF;
        private Button btnSaveQuiz;
        private Button btnLoadQuiz;
    }
}