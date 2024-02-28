using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace QuizME.Services.FormService
{
	public class FormService : IFormService
	{
		
		private readonly IServiceProvider _serviceProvider;

		public FormService(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}
		public event FormOpenedHandler FormOpened;
		public event FormClosedHandler FormClosed;

		public void OpenForm<T>() where T : Form
		{
			var form = _serviceProvider.GetRequiredService<T>();
			form.Show();
		}

		public void OpenFormWithArgument<T, TArg>(TArg arg) where T : Form
		{
			var form = ActivatorUtilities.CreateInstance<T>(_serviceProvider, arg);
			form.Show();
			FormOpened?.Invoke(this, EventArgs.Empty, form);
		}

		public string OpenFile()
		{
			using (var openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Quiz Files (*.quiz)|*.quiz";
				openFileDialog.RestoreDirectory = true;

				var result = openFileDialog.ShowDialog();

				switch (result)
				{
					case DialogResult.OK:
						return openFileDialog.FileName;
					case DialogResult.Cancel:
						return null;
				}
			}

			return null;
		}
	}
}