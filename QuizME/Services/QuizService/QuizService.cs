using System.IO;
using System.Net;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using QuizME.Models;
using QuizME.Services.PrintService;
using QuizME.Services.QuestionService;

namespace QuizME.Services.QuizService
{
	public class QuizService : IQuizService
	{
		private readonly IQuestionService _questionService;
		private readonly IPrintService _printService;

		public QuizService(IQuestionService questionService, IPrintService printService)
		{
			_questionService = questionService;
			_printService = printService;
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
			// Read the JSON string from the file
			var json = File.ReadAllText(path);

			// Setup the JsonSerializerSettings
			var settings = new JsonSerializerSettings();
			settings.TypeNameHandling = TypeNameHandling.Auto;

			// Deserialize the JSON string into a Quiz object
			var quiz = JsonConvert.DeserializeObject<Quiz>(json, settings);
			
			return quiz;

		}
		
		public void SaveQuizToFile(Quiz quiz, string filePath)
		{
			// Setup the JsonSerializerSettings
			var settings = new JsonSerializerSettings();
			settings.TypeNameHandling = TypeNameHandling.Auto;

			// Serialize the Quiz object into a JSON string
			var json = JsonConvert.SerializeObject(quiz, settings);

			// Write the JSON string to the file
			File.WriteAllText(filePath, json);
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

		public void CreateStudentPDF(Quiz quiz, string path, string title)
		{
			_printService.CreateStudentPDF(quiz, path);
		}

		public void CreateTeacherPDF(Quiz quiz, string path)
		{
			/*var html = _printService.GenerateTeacherHTML(quiz);
			_printService.GeneratePDF(path, html, title);*/
			_printService.CreateTeacherPDF(quiz, path);
		}
	}
}