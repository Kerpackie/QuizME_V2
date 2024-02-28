using QuizME.Models;
using QuizME.Models.Questions;

namespace QuizME.Services.PrintService;

public interface IPrintService
{
	void CreateTeacherPDF(Quiz quiz, string path);
	void CreateStudentPDF(Quiz quiz, string path);
	void GeneratePDF(string path, string html, string title);
	string GenerateStudentHTML(Quiz quiz);
	string GenerateTeacherHTML(Quiz quiz);
	string GenerateQuizHead(Quiz quiz);
	string GenerateTrueFalseQuestionStudent(TrueFalse question);
	string GenerateMultiChoiceQuestionStudent(MultipleChoice question);
	string GenerateNumericalQuestionStudent(Numerical question);
	string GenerateOpenQuestionStudent(Open question);
	string GenerateTrueFalseQuestionTeacher(TrueFalse question);
	string GenerateMultiChoiceQuestionTeacher(MultipleChoice question);
	string GenerateNumericalQuestionTeacher(Numerical question);
	string GenerateOpenQuestionTeacher(Open question);
	
}