namespace QuizME.Models
{
	public abstract class Question
	{
		public string Text { get; set; }
		public int Mark { get; set; }
		public string Answer { get; set; }

		public string QuestionType => GetType().Name;
	}
}