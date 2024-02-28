using System;
using System.Windows.Forms;

namespace QuizME.Services.FormService
{
	public delegate void FormOpenedHandler(object sender, EventArgs e, Form openedForm);
	public delegate void FormClosedHandler(object sender, EventArgs e, Form closedFormName);
}