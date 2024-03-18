using AS_Coursework.View;
using AS_Coursework.Model;

namespace AS_Coursework;
internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        try {
            Application.Run(new formMaster());
        }
        catch (Exception e) {
            ExceptionLogger.Log(e);

            CustomMessageBox.Show("Error", "Oops, there was an error");
        }
    }
}
