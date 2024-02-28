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
using Newtonsoft.Json;
using QuizME.Forms.Questions.MultiChoiceForm;

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
                SetupForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form: " + ex.Message);
            }

            tbModule.TextChanged += OnQuizFormTextChanged;
            tbDescription.TextChanged += OnQuizFormTextChanged;
            tbTopic.TextChanged += OnQuizFormTextChanged;
            tbMarks.TextChanged += OnQuizFormTextChanged;
            rtbInstructions.TextChanged += OnQuizFormTextChanged;
            _quiz.QuestionAdded += OnQuestionAdded;

        }

        private void SetupForm()
        {
            tbModule.Text = _quiz.Name;
            tbDescription.Text = _quiz.Description;
            tbTopic.Text = _quiz.Topic;
            tbMarks.Text = _quiz.Marks.ToString();
            rtbInstructions.Text = _quiz.Instructions;

            foreach (var quizQuestion in _quiz.Questions)
            {
                var item = new ListViewItem(quizQuestion.Text);
                item.SubItems.Add(quizQuestion.QuestionType);
                lvQuestions.Items.Add(item);
            }
        }

        private void OnQuizFormTextChanged(object sender, EventArgs e)
        {
            int.TryParse(tbMarks.Text, out var marks);
            _quizService.UpdateQuiz(_quiz, tbModule.Text, tbDescription.Text, tbTopic.Text, marks, rtbInstructions.Text);
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

        private void btnMultiChoice_Click(object sender, EventArgs e)
        {
            _formService.OpenFormWithArgument<MultiChoiceForm, Quiz>(_quiz);
        }

        private void btnSaveQuiz_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Quiz files (*.quiz)|*.quiz|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "quiz";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string saveQuiz = saveFileDialog.FileName;
                try
                {
                    _quizService.SaveQuizToFile(_quiz, saveQuiz);
                    MessageBox.Show("Quiz saved successfully.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error saving quiz. " + exception.Message, "Error saving quiz.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No file selected, Cannot save quiz.");
            }
        }

        private void btnLoadQuiz_Click(object sender, EventArgs e)
        {
            var loadQuiz = _formService.OpenFile();

            if (loadQuiz != null)
            {
                try
                {
                    var quiz = _quizService.LoadQuizFromFile(loadQuiz);

                    tbModule.Text = quiz.Name;
                    tbDescription.Text = quiz.Description;
                    tbTopic.Text = quiz.Topic;
                    tbMarks.Text = quiz.Marks.ToString();
                    rtbInstructions.Text = quiz.Instructions;

                    lvQuestions.Items.Clear();
                    foreach (var question in quiz.Questions)
                    {
                        var item = new ListViewItem(question.Text);
                        item.SubItems.Add(question.QuestionType);
                        lvQuestions.Items.Add(item);
                    }
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

        private void btnGenerateTutorVersionPDF_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.Title = "Save a PDF File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                var path = saveFileDialog.FileName;
                var formattedDate = DateTime.Today.ToString("dd-MM-yyyy"); // Format the date to avoid invalid characters
                _quizService.CreateTeacherPDF(_quiz, path);
                MessageBox.Show("PDF created successfully.");
            }
        }

        private void btnGenerateStudentVersionPDF_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.Title = "Save a PDF File";
            saveFileDialog.ShowDialog();
            
            if (saveFileDialog.FileName != "")
            {
                var path = saveFileDialog.FileName;
                _quizService.CreateStudentPDF(_quiz, path, $"{_quiz.Topic} - {_quiz.Name} - {DateTime.Today.Date} - Student Version");
                MessageBox.Show("PDF created successfully.");
            }
        }
    }
}