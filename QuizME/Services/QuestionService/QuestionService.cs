using System;
using System.Collections.Generic;
using QuizME.Models;
using QuizME.Models.Questions;

namespace QuizME.Services.QuestionService
{
	public class QuestionService : IQuestionService
	{
		private readonly Random _random = new Random();
		
		public void AddQuestion(Quiz quiz, Question question)
		{
			throw new System.NotImplementedException();
		}

		public Question CreateQuestion(string text, string answer)
		{
			throw new System.NotImplementedException();
		}

		public MultipleChoice CreateMultipleChoiceQuestion(int mark, string text, string answer, List<string> options)
		{
			var questionText = $"Select the correct answer: {text}";
			return new MultipleChoice
			{
				Mark = mark,
				Text = questionText,
				Answer = answer,
				Options = options
			};
		}

		public Numerical CreateNumericalQuestion(int mark, int minX, int maxX, int minY, int maxY, string operation)
		{
			
			var x = _random.Next(minX, maxX + 1);
			var y = _random.Next(minY, maxY + 1);
			
			var questionText = $"Solve the following: {x} {operation} {y} = ?";
			
			return new Numerical(mark, x, y, operation, questionText);
		}

		public Open CreateOpenQuestion(int mark, string text, string notes)
		{
			return new Open
			{
				Mark = mark,
				Notes = notes,
				Text = text
			};
		}

		public TrueFalse CreateTrueFalseQuestion(int mark, string text, string answer)
		{
			var questionText = $"True or False: {text}";
			
			return new TrueFalse
			{
				Mark = mark,
				Text = questionText,
				Answer = answer
			};
		}

		public void UpdateQuestion(Question question, string newText, string newAnswer)
		{
			throw new System.NotImplementedException();
		}

		public void DeleteQuestion(Quiz quiz, Question question)
		{
			throw new System.NotImplementedException();
		}

		public Question GetQuestion(Quiz quiz, int questionIndex)
		{
			throw new System.NotImplementedException();
		}
	}
}