namespace QuizME.Forms.MainForm
{
    partial class MainForm
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
            this.lblMain = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoadQuiz = new System.Windows.Forms.Button();
            this.btnNewQuiz = new System.Windows.Forms.Button();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(27, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(557, 45);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "QuizME - The Worlds Worst Quiz Generator";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnExit);
            this.gbMain.Controls.Add(this.btnLoadQuiz);
            this.gbMain.Controls.Add(this.btnNewQuiz);
            this.gbMain.Location = new System.Drawing.Point(27, 57);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(557, 158);
            this.gbMain.TabIndex = 1;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Select an Option";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(365, 51);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 63);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoadQuiz
            // 
            this.btnLoadQuiz.Location = new System.Drawing.Point(189, 51);
            this.btnLoadQuiz.Name = "btnLoadQuiz";
            this.btnLoadQuiz.Size = new System.Drawing.Size(150, 63);
            this.btnLoadQuiz.TabIndex = 1;
            this.btnLoadQuiz.Text = "Load Quiz";
            this.btnLoadQuiz.UseVisualStyleBackColor = true;
            this.btnLoadQuiz.Click += new System.EventHandler(this.btnLoadQuiz_Click);
            // 
            // btnNewQuiz
            // 
            this.btnNewQuiz.Location = new System.Drawing.Point(20, 51);
            this.btnNewQuiz.Name = "btnNewQuiz";
            this.btnNewQuiz.Size = new System.Drawing.Size(150, 63);
            this.btnNewQuiz.TabIndex = 0;
            this.btnNewQuiz.Text = "New Quiz";
            this.btnNewQuiz.UseVisualStyleBackColor = true;
            this.btnNewQuiz.Click += new System.EventHandler(this.btnNewQuiz_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 259);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.lblMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.gbMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnNewQuiz;
        private System.Windows.Forms.Button btnLoadQuiz;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Label lblMain;

        #endregion
    }
}