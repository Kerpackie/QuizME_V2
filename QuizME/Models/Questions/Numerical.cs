using System;

namespace QuizME.Models.Questions
{
	public class Numerical : Question
	{
		public int MinX { get; set; } = 0;
		public int MaxX { get; set; } = 11;
		public int MinY { get; set; } = 0;
		public int MaxY { get; set; } = 11;
		public int XVal { get; private set; }
		public int YVal { get; private set; }
		public string Operator { get; set; }


		public Numerical(int mark, int x, int y, string operation, string text)
		{
			Mark = mark;
			XVal = x;
			YVal = y;
			Operator = operation;
			Text = text;
			GenerateAnswer();
		}

		private void GenerateAnswer()
		{
			switch (Operator)
			{
				case "+":
					Answer = (XVal + YVal).ToString();
					break;
				case "-":
					Answer = (XVal - YVal).ToString();
					break;
				case "*":
					Answer = (XVal * YVal).ToString();
					break;
				case "/":
					Answer = (XVal / YVal).ToString();
					break;
				default:
					break;
			}
		}
	}
}