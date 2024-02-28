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

namespace QuizME.Forms.Questions.NumericalForm
{
    public partial class NumericalForm : Form
    {
        private readonly IQuestionService _questionService;
        private readonly IQuizService _quizService;
        private readonly Quiz _quiz;

        public NumericalForm(IQuestionService questionService, IQuizService quizService, Quiz quiz) 
        {
            _questionService = questionService;
            _quizService = quizService;
            _quiz = quiz;
            InitializeComponent();

            AddOperationToComboBox();
            btnCancel.Click += (sender, e) => Close();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            if (this.ValidateNumericFormInputs(tbMarks, tbText, tbXMin, tbXMax, tbYMin,
                    tbYMax, out var marks))
            {
                var question = CreateQuestion(marks);
                _quizService.AddQuestionToQuiz(_quiz, question);

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

        private Numerical CreateQuestion(int marks)
        {
            return _questionService.CreateNumericalQuestion(marks, ConvertTextBoxToInt(tbXMin),
                ConvertTextBoxToInt(tbXMax), ConvertTextBoxToInt(tbYMin),
                ConvertTextBoxToInt(tbYMax), cbOperator.Text);
        }

        private int ConvertTextBoxToInt(TextBox tb)
        {
            return int.TryParse(tb.Text, out var result) ? result : 0;
        }

        private void AddOperationToComboBox()
        {
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
        }
    }
}
