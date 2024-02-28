using System.IO;
using System.Net;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using QuizME.Models;
using QuizME.Services.QuestionService;

namespace QuizME.Services.QuizService
{
	public class QuizService : IQuizService
	{
		private readonly IQuestionService _questionService;

		public QuizService(IQuestionService questionService)
		{
			_questionService = questionService;
		}

		public Quiz CreateQuiz()
		{
			return new Quiz();
		}

		public Quiz CreateQuiz(string name, string description, string topic, int marks, string instructions)
		{
			var quiz = new Quiz
			{
				Name = name,
				Description = description,
				Topic = topic,
				Marks = marks,
				Instructions = instructions
			};
			
			return quiz;
		}

		public Quiz UpdateQuiz(Quiz quiz, string name, string description, string topic, int marks, string instructions)
		{
			quiz.Name = name;
			quiz.Description = description;
			quiz.Topic = topic;
			quiz.Marks = marks;
			quiz.Instructions = instructions;
			
			return quiz;
		}

		public void DeleteQuiz(Quiz quiz)
		{
			throw new System.NotImplementedException();
		}

		public Quiz LoadQuizFromFile(string path)
		{
			if (path == null) return null;
			var json = File.ReadAllText(path);
			var quiz = JsonConvert.DeserializeObject<Quiz>(json);
			
			return quiz;

		}

		public void SaveQuizToFile(Quiz quiz, string path)
		{
			var json = JsonConvert.SerializeObject(quiz);
			File.WriteAllText(path + ".quiz", json);
		}

		public void DeleteQuizFromFile(string path)
		{
			File.Delete(path);
		}

		public void AddQuestionToQuiz(Quiz quiz, Question question)
		{
			quiz.Questions.Add(question);
			quiz.OnQuestionAdded();
		}
	}
}