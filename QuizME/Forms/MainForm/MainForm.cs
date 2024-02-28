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
using QuizME.Forms.Questions.TrueFalseForm;
using QuizME.Forms.QuizForm;

namespace QuizME.Forms.MainForm
{
    public partial class MainForm : Form
    {
        private readonly IQuizService _quizService;
        private readonly IFormService _formService;

        public MainForm(IQuizService quizService, IFormService formService)
        {
            _quizService = quizService;
            _formService = formService;
            _formService.FormOpened += FormOpened;
            InitializeComponent();
        }

        private void FormOpened(object sender, EventArgs e, Form openedForm)
        {
            if (openedForm is QuizForm.QuizForm)
            {
                Hide();
                openedForm.FormClosed += FormClosed;
            }
        }

        private void FormClosed(object sender, EventArgs e)
        {
            if (sender is QuizForm.QuizForm)
            {
                Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            _formService.OpenForm<TrueFalseForm>();
        }

        private void btnLoadQuiz_Click(object sender, EventArgs e)
        {
            var loadQuiz = _formService.OpenFile();

            if (loadQuiz != null)
            {
                try
                {
                    var quiz = _quizService.LoadQuizFromFile(loadQuiz);
                    _formService.OpenFormWithArgument<QuizForm.QuizForm, Quiz>(quiz);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error loading quiz. " + exception.Message, "Error loading quiz.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No file selected, Cannot load quiz.");
            }
        }

        private void btnNewQuiz_Click(object sender, EventArgs e)
        {
            try
            {
                var quiz = _quizService.CreateQuiz();
                Console.WriteLine("Quiz created: " + quiz);

                _formService.OpenFormWithArgument<QuizForm.QuizForm, Quiz>(quiz);
                Console.WriteLine("QuizForm opened with quiz: " + quiz);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
