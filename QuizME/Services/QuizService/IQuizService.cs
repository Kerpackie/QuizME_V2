using QuizME.Models;

namespace QuizME.Services.QuizService
{
	public interface IQuizService
	{
		Quiz CreateQuiz();
		Quiz CreateQuiz(string name, string description, string topic, int marks, string instructions);
		Quiz UpdateQuiz(Quiz quiz, string name, string description, string topic, int marks, string instructions);
		void DeleteQuiz(Quiz quiz); // Needed?
		Quiz LoadQuizFromFile(string path);
		void SaveQuizToFile(Quiz quiz, string path);
		void DeleteQuizFromFile(string path);
		void AddQuestionToQuiz(Quiz quiz, Question question);
	}
}