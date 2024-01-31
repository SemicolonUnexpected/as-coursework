using AS_Coursework.View;
using AS_Coursework.Model.Quiz;
using AS_Coursework.View.QuizView;
using AS_Coursework.Model.Users;

namespace AS_Coursework; 
internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        Application.Run(new formMaster());
    }
}