using AS_Coursework.Custom_Controls;
using AS_Coursework.Model.Users;
using AS_Coursework.View;
using System.Diagnostics;

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
        Application.Run(new formMaster());
    }
}