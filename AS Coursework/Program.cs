using AS_Coursework.View;
using AS_Coursework.Model.Quiz;

namespace AS_Coursework; 
internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        ApplicationConfiguration.Initialize();

        Question question = new MatchingQuestion("Test question", new Dictionary<string, string> {
            { "1", "One" },
            { "2", "Two" },
            { "3", "Three" },
            { "4", "Four" },
        });


        Application.Run(question.DisplayQuestion());
        // Application.Run(new formMaster());
    }
}