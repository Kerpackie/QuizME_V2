using System.Windows.Forms;
using QuizME.Services.FormService;

public interface IFormService
{
	event FormOpenedHandler FormOpened;
	event FormClosedHandler FormClosed;

	void OpenForm<T>() where T : Form;
	void OpenFormWithArgument<T, TArg>(TArg arg) where T : Form;
	string OpenFile();
}