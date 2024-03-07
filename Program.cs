using CasinoForms.Models;
using CasinoForms.Testing;
using CasinoForms.Views;
using CasinoForms.Controllers;
namespace CasinoForms
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
            //Application.Run(new CasinoForms.Testing.TestView());
            UserModel user = new UserModel("Test", 1000);
            ApplicationManager app = new ApplicationManager(user);
            Application.Run(new TitleScreen(app));
        }
    }
}