using System.Windows.Forms;
using QuizME.Forms.Questions.MultiChoiceForm;
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
		
		public static bool ValidateMultiChoiceFormInputs(this MultiChoiceForm form, TextBox tbMarks, TextBox tbText, 
			TextBox tbOption1, TextBox tbOption2, TextBox tbOption3, TextBox tbOption4, out int marks)
		{
			return ValidateInputs(tbMarks, tbText, out marks) &&
			       !string.IsNullOrWhiteSpace(tbOption1.Text) &&
			       !string.IsNullOrWhiteSpace(tbOption2.Text) &&
			       !string.IsNullOrWhiteSpace(tbOption3.Text) &&
			       !string.IsNullOrWhiteSpace(tbOption4.Text);
		}
	}
}