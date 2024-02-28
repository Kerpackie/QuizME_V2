using QuizME.Extensions;
using QuizME.Models;
using QuizME.Models.Questions;
using QuizME.Services.QuestionService;
using QuizME.Services.QuizService;

namespace QuizME.Forms.Questions.MultiChoiceForm
{
    public partial class MultiChoiceForm : Form
    {
        private readonly IQuestionService _questionService;
        private readonly IQuizService _quizService;
        private readonly Quiz _quiz;
        public MultiChoiceForm(IQuestionService questionService, IQuizService quizService, Quiz quiz)
        {
            _questionService = questionService;
            _quizService = quizService;
            _quiz = quiz;
            InitializeComponent();
            
            btnCancel.Click += (sender, e) => Close();
            
            btnSave.Click += btnSave_Click;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateMultiChoiceFormInputs(tbMarks, tbText, tbOption1, tbOption2, tbOption3, tbOption4, out var marks))
            {
                var question = CreateQuestion(marks);
                _quizService.AddQuestionToQuiz(_quiz, question);
                Close();
                MessageBox.Show("Question added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid inputs. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private MultipleChoice CreateQuestion(int marks)
        {
            var options = new List<string>
            {
                tbOption1.Text,
                tbOption2.Text,
                tbOption3.Text,
                tbOption4.Text
            };

            return gbMultiChoice.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name switch
            {
                "rbOption1" => _questionService.CreateMultipleChoiceQuestion(marks, tbText.Text, tbOption1.Text,
                    options),
                "rbOption2" => _questionService.CreateMultipleChoiceQuestion(marks, tbText.Text, tbOption2.Text,
                    options),
                "rbOption3" => _questionService.CreateMultipleChoiceQuestion(marks, tbText.Text, tbOption3.Text,
                    options),
                "rbOption4" => _questionService.CreateMultipleChoiceQuestion(marks, tbText.Text, tbOption4.Text,
                    options),
                _ => null
            };
        }
    }
}
