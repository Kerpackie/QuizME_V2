using QuizME.Extensions;
using QuizME.Models.Questions;
using QuizME.Models;
using QuizME.Services.QuestionService;
using QuizME.Services.QuizService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizME.Forms.Questions.TrueFalseForm
{
    public partial class TrueFalseForm : Form
    {
        private readonly IQuestionService _questionService;
        private readonly IQuizService _quizService;
        private readonly Quiz _quiz;

        public TrueFalseForm(IQuestionService questionService, IQuizService quizService, Quiz quiz)
        {
            _questionService = questionService;
            _quizService = quizService;
            _quiz = quiz;

            InitializeComponent();

            btnCancel.Click += (sender, e) => Close();
        }

        public TrueFalseForm()
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateTrueFalseFormInputs(tbMarks, tbText, rbTrue, rbFalse, out var marks))
            {
                var question = CreateQuestion(marks);
                AddQuestionToQuiz(question);
                Close();
                MessageBox.Show("Question added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid inputs. Please check your inputs and try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private TrueFalse CreateQuestion(int marks)
        {
            var answer = gbTrueFalse.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;
            return _questionService.CreateTrueFalseQuestion(marks, tbText.Text, answer);
        }

        protected void AddQuestionToQuiz(Question question)
        {
            _quizService.AddQuestionToQuiz(_quiz, question);
        }
    }
}
