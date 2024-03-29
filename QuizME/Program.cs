using QuizME.Services.FormService;
using QuizME.Services.QuestionService;
using QuizME.Services.QuizService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuizME.Forms.MainForm;
using QuizME.Services.PrintService;

namespace QuizME
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IFormService, FormService>();
                    services.AddScoped<IQuizService, QuizService>();
                    services.AddTransient<IQuestionService, QuestionService>();
                    services.AddSingleton<IPrintService, PrintService>();
                    services.AddTransient<MainForm>();
                });
        }

    }
}