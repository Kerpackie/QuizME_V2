using System.Windows.Forms;
using QuizME.Forms.QuizForm;
using QuizME.Forms.Questions.NumericalForm;
using QuizME.Forms.Questions.OpenForm;
using QuizME.Forms.Questions.TrueFalseForm;
using QuizME.Models;

namespace QuizME.Extensions
{
	public static class FormExtensions
	{
		private static bool ValidateInputs(TextBox tbMarks, TextBox tbText, out int marks)
		{
			return int.TryParse(tbMarks.Text, out marks) &&
			       !string.IsNullOrWhiteSpace(tbText.Text);
		}
		
		public static bool ValidateNumericFormInputs(this NumericalForm form, TextBox tbMarks, TextBox tbText, 
			TextBox minX, TextBox maxX, TextBox minY, TextBox maxY, out int marks)
		{
			return ValidateInputs(tbMarks, tbText, out marks) &&
			       int.TryParse(minX.Text, out _) &&
			       int.TryParse(maxX.Text, out _) &&
			       int.TryParse(minY.Text, out _) &&
			       int.TryParse(maxY.Text, out _) &&
			       !string.IsNullOrWhiteSpace(tbText.Text);
		}
		
		public static bool ValidateTrueFalseFormInputs(this TrueFalseForm form, TextBox tbMarks, TextBox tbText, 
			RadioButton rbTrue, RadioButton rbFalse, out int marks)
		{
			return ValidateInputs(tbMarks, tbText, out marks) &&
			       (rbTrue.Checked || rbFalse.Checked);
		}
		
		public static bool ValidateOpenFormInputs(this OpenForm form, TextBox tbMarks, TextBox tbText, RichTextBox notes, 
			out int marks)
		{
			return ValidateInputs(tbMarks, tbText, out marks) &&
			       !string.IsNullOrWhiteSpace(notes.Text);
		}
	}
}