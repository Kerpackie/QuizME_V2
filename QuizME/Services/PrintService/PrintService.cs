using System.Text;
using Microsoft.Extensions.Primitives;
using PdfSharp.Drawing;
using QuizME.Models;
using QuizME.Models.Questions;
using SelectPdf;

namespace QuizME.Services.PrintService;

public class PrintService : IPrintService
{

	public void CreateTeacherPDF(Quiz quiz, string path)
	{
		var converter = new HtmlToPdf();

		var htmlString = new StringBuilder();
		htmlString.Append("<html><head>");
		htmlString.Append("<style>");
		htmlString.Append("body { font-family: Arial, sans-serif; }");
		htmlString.Append("h1 { color: #333; }");
		htmlString.Append("p { color: #666; }");
		htmlString.Append("</style>");
		htmlString.Append("</head><body>");
		htmlString.Append($"<h1>{quiz.Name}</h1>");
		htmlString.Append($"<p>{quiz.Description}</p>");
		htmlString.Append($"<p>{quiz.Topic}</p>");
		htmlString.Append($"<p>{quiz.Marks}</p>");
		htmlString.Append($"<p>{quiz.Instructions}</p>");

		foreach (var question in quiz.Questions)
		{
			htmlString.Append($"<h2>{question.Text}</h2>");
			htmlString.Append($"<p>{question.Mark} Marks</p>");
			htmlString.Append($"<p>{question.Answer}</p>");

			switch (question.QuestionType)
			{
				case "MultipleChoice":
					var multiChoice = (MultipleChoice) question;
					var val = 0;
					foreach (var option in multiChoice.Options)
					{
						htmlString.Append($"<p>Option {val}:{option}</p>");
						val++;
					}
					break;
				case "Open":
					var open = (Open) question;
					htmlString.Append($"<p>{open.Notes}</p>");
					break;
				default:
					break;
			}
		}

		htmlString.Append("</body></html>");

		var doc = converter.ConvertHtmlString(htmlString.ToString());
		doc.Save(path);
		doc.Close();
	}

	public void CreateStudentPDF(Quiz quiz, string path)
	{
		var converter = new HtmlToPdf();

		var htmlString = new StringBuilder();
		htmlString.Append("<html><head>");
		htmlString.Append("<style>");
		htmlString.Append("body { font-family: Arial, sans-serif; }");
		htmlString.Append("h1 { color: #333; }");
		htmlString.Append("p { color: #666; }");
		htmlString.Append("</style>");
		htmlString.Append("</head><body>");
		htmlString.Append($"<h1>{quiz.Name}</h1>");
		htmlString.Append($"<p>{quiz.Description}</p>");
		htmlString.Append($"<p>{quiz.Topic}</p>");
		htmlString.Append($"<p>{quiz.Marks}</p>");
		htmlString.Append($"<p>{quiz.Instructions}</p>");

		foreach (var question in quiz.Questions)
		{
			htmlString.Append("<hr>");
			htmlString.Append($"<h2>{question.Text}</h2>");
			htmlString.Append($"<p>{question.Mark} Marks</p>");

			if (question.QuestionType == "MultipleChoice")
			{
				var multiChoice = (MultipleChoice) question;
				var val = 0;
				foreach (var option in multiChoice.Options)
				{
					htmlString.Append($"<p>Option {val}:{option}</p>");
					val++;
				}
			}
			
			htmlString.Append($"<p>Answer: <br><br><br><br><br><br></p>");
			
		}

		htmlString.Append("</body></html>");

		var doc = converter.ConvertHtmlString(htmlString.ToString());
		doc.Save(path);
		doc.Close();
	}

	public void GeneratePDF(string path, string html, string title)
	{
		var converter = new HtmlToPdf();
		var doc = converter.ConvertHtmlString(html);
		doc.Save($"{title}.pdf");
		doc.Close();
	}

	public string GenerateStudentHTML(Quiz quiz)
	{
		var html = GenerateQuizHead(quiz);

		foreach (var quizQuestion in quiz.Questions)
		{
			switch (quizQuestion)
			{
				case TrueFalse trueFalse:
					html += GenerateTrueFalseQuestionStudent(trueFalse);
					break;
				case MultipleChoice multiChoice:
					html += GenerateMultiChoiceQuestionStudent(multiChoice);
					break;
				case Numerical numerical:
					html += GenerateNumericalQuestionStudent(numerical);
					break;
				case Open open:
					html += GenerateOpenQuestionStudent(open);
					break;
			}
		}
		
		html += @"</div>
			</div>
			</div>
			<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
			</body>
			</html>";

		return html;
	}

	public string GenerateTeacherHTML(Quiz quiz)
	{
		var html = GenerateQuizHead(quiz);

		foreach (var quizQuestion in quiz.Questions)
		{
			switch (quizQuestion)
			{
				case TrueFalse trueFalse:
					html += GenerateTrueFalseQuestionTeacher(trueFalse);
					break;
				case MultipleChoice multiChoice:
					html += GenerateMultiChoiceQuestionTeacher(multiChoice);
					break;
				case Numerical numerical:
					html += GenerateNumericalQuestionTeacher(numerical);
					break;
				case Open open:
					html += GenerateOpenQuestionTeacher(open);
					break;
			}
		}
		
		html += @"</div>
			</div>
			</div>
			<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
			</body>
			</html>";

		return html;
	}

	public string GenerateQuizHead(Quiz quiz)
	{
		var htmlStart = @"<!DOCTYPE html>
						<html lang=""en"">
						<head>
						    <meta charset=""UTF-8"">
						    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
						    <title>Quiz Information</title>
						    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" rel=""stylesheet"">
						</head>
						<body>
						    <div class=""container"">
						        <div class=""row"">
						            <div class=""col-lg-12"">";

		var htmlTitle = $"<h1 class=\"\"mt-5\"\">{quiz.Topic}</h1>";
		var quizDescription = $"<p class=\"\"lead\"\">{quiz.Description}</p>";
		var tableStart = @"<table class=""""table table-striped"""">
			                    <thead>
			                        <tr>
			                            <th scope=""""col"""">Information</th>
			                            <th scope=""""col"""">Details</th>
			                        </tr>
			                    </thead>
			                    <tbody>
			                        <tr>
			                            <td>Total Marks</td>";
		var totalMarks = $"<td>{quiz.Marks}</td>";
		var endTable = @"</tr>
	                        <tr>
	                            <td>Duration</td>
	                            <td>60 minutes</td>
	                        </tr>
	                    </tbody>
	                </table>
					<hr>";

		var html = new StringBuilder();
		html.Append(htmlStart);
		html.Append(htmlTitle);
		html.Append(quizDescription);
		html.Append(tableStart);
		html.Append(totalMarks);
		html.Append(endTable);
		
		

		/*</div>
	</div>
</div>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
</body>
</html>";*/
		return html.ToString();
	}
	
	public string GenerateTrueFalseQuestionStudent(TrueFalse question)
	{
		var htmlQuestion = $"<h2>{question.Text}</h2>";
		var htmlOptions = @"<div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""trueFalseOption"" id=""optionTrue"" value=""true"">
                            <label class=""form-check-label"" for=""optionTrue"">
                                True
                            </label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""trueFalseOption"" id=""optionFalse"" value=""false"">
                            <label class=""form-check-label"" for=""optionFalse"">
                                False
                            </label>
                        </div>";

		return htmlQuestion + htmlOptions;
	}

	public string GenerateMultiChoiceQuestionStudent(MultipleChoice question)
	{
		var htmlQuestion = $"<h2>{question.Text}</h2>";
		var htmlOptions = new StringBuilder();

		for (var i = 0; i < question.Options.Count; i++)
		{
			htmlOptions.Append($@"<div class=""form-check"">
                                <input class=""form-check-input"" type=""radio"" name=""multiChoiceOption"" id=""option{i}"" value=""{question.Options[i]}"">
                                <label class=""form-check-label"" for=""option{i}"">
                                    {question.Options[i]}
                                </label>
                            </div>");
		}

		return htmlQuestion + htmlOptions;
	}

	public string GenerateNumericalQuestionStudent(Numerical question)
	{
		var htmlQuestion = $"<h2>{question.Text}</h2>";
		var htmlInput = @"<div class=""form-group"">
                        <label for=""numericalAnswer"">Your Answer:</label>
                        <input type=""number"" class=""form-control"" id=""numericalAnswer"">
                      </div>";

		return htmlQuestion + htmlInput;
	}

	public string GenerateOpenQuestionStudent(Open question)
	{
		var htmlQuestion = $"<h2>{question.Text}</h2>";
		var htmlInput = @"<div class=""form-group"">
                        <label for=""openAnswer"">Your Answer:</label>
                        <textarea class=""form-control"" id=""openAnswer"" rows=""8""></textarea>
                      </div>";

		return htmlQuestion + htmlInput;
	}

	public string GenerateTrueFalseQuestionTeacher(TrueFalse question)
{
    var htmlQuestion = $"<h2>{question.Text}</h2>";
    var htmlOptions = @"<div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""trueFalseOption"" id=""optionTrue"" value=""true"">
                            <label class=""form-check-label"" for=""optionTrue"">
                                True
                            </label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""trueFalseOption"" id=""optionFalse"" value=""false"">
                            <label class=""form-check-label"" for=""optionFalse"">
                                False
                            </label>
                        </div>";
    var htmlAnswer = $"<p>Answer: {question.Answer}</p>";

    return htmlQuestion + htmlOptions + htmlAnswer;
}

public string GenerateMultiChoiceQuestionTeacher(MultipleChoice question)
{
    var htmlQuestion = $"<h2>{question.Text}</h2>";
    var htmlOptions = new StringBuilder();

    for (var i = 0; i < question.Options.Count; i++)
    {
        htmlOptions.Append($@"<div class=""form-check"">
                                <input class=""form-check-input"" type=""radio"" name=""multiChoiceOption"" id=""option{i}"" value=""{question.Options[i]}"">
                                <label class=""form-check-label"" for=""option{i}"">
                                    {question.Options[i]}
                                </label>
                            </div>");
    }
    var htmlAnswer = $"<p>Answer: {question.Answer}</p>";

    return htmlQuestion + htmlOptions + htmlAnswer;
}

public string GenerateNumericalQuestionTeacher(Numerical question)
{
    var htmlQuestion = $"<h2>{question.Text}</h2>";
    var htmlInput = @"<div class=""form-group"">
                        <label for=""numericalAnswer"">Your Answer:</label>
                        <input type=""number"" class=""form-control"" id=""numericalAnswer"">
                      </div>";
    var htmlAnswer = $"<p>Answer: {question.Answer}</p>";

    return htmlQuestion + htmlInput + htmlAnswer;
}

public string GenerateOpenQuestionTeacher(Open question)
{
    var htmlQuestion = $"<h2>{question.Text}</h2>";
    var htmlInput = @"<div class=""form-group"">
                        <label for=""openAnswer"">Your Answer:</label>
                        <textarea class=""form-control"" id=""openAnswer"" rows=""8""></textarea>
                      </div>";
    var htmlAnswer = $"<p>Answer: {question.Notes}</p>";

    return htmlQuestion + htmlInput + htmlAnswer;
}
}