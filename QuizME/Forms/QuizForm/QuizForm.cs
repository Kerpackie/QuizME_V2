using QuizME.Forms.Questions.NumericalForm;
using QuizME.Forms.Questions.OpenForm;
using QuizME.Forms.Questions.TrueFalseForm;
using QuizME.Models;
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

namespace QuizME.Forms.QuizForm
{
    public partial class QuizForm : Form
    {
        private readonly IQuizService _quizService;
        private readonly Quiz _quiz;
        private readonly IFormService _formService;
        public QuizForm(Quiz quiz, IQuizService quizService, IFormService formService)
        {
            _quiz = quiz;
            _formService = formService;
            try
            {
                _quizService = quizService;
                InitializeComponent();
                //SetupListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form: " + ex.Message);
            }
            _quiz.QuestionAdded += OnQuestionAdded;

        }

        private void OnQuestionAdded()
        {
            lvQuestions.Items.Clear();
            foreach (var question in _quiz.Questions)
            {
                var item = new ListViewItem(question.Text);
                item.SubItems.Add(question.QuestionType);
                lvQuestions.Items.Add(item);
            }
        }

        private void btnTrueFalse_Click(object sender, EventArgs e)
        {
            _formService.OpenFormWithArgument<TrueFalseForm, Quiz>(_quiz);
        }

        private void btnNumerical_Click(object sender, EventArgs e)
        {
            _formService.OpenFormWithArgument<NumericalForm, Quiz>(_quiz);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            _formService.OpenFormWithArgument<OpenForm, Quiz>(_quiz);
        }
    }
}