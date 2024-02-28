using System.Collections.Generic;
using QuizME.Models;
using QuizME.Models.Questions;

namespace QuizME.Services.QuestionService
{
	public interface IQuestionService
	{
		void AddQuestion(Quiz quiz, Question question);
		Question CreateQuestion(string text, string answer);
		
		MultipleChoice CreateMultipleChoiceQuestion(int mark, string text, string answer, List<string> options);
		Numerical CreateNumericalQuestion(int mark, int minX, int maxX, int minY, int maxY, string operation);
		Open CreateOpenQuestion(int mark, string text, string notes);
		TrueFalse CreateTrueFalseQuestion(int mark, string text, string answer);
		
		void UpdateQuestion(Question question, string newText, string newAnswer);
		void DeleteQuestion(Quiz quiz, Question question);
		Question GetQuestion(Quiz quiz, int questionIndex);
	}
}