namespace AS_Coursework.Model; 
internal static class ExceptionLogger {
    private const string LOG_FILE_PATH = "Log.txt";

    public static void Log(string message) {
        using StreamWriter streamWriter = new(LOG_FILE_PATH, true);
        streamWriter.WriteLine(CurrentTimeLog() + message);
    }

    public static void LogException(Exception exception) {
        Log(exception.ToString());
    }

    public static void LogException(Exception exception, params string[] messages) {
        Log(string.Join(", ", messages) + " : " + exception.ToString());
    }

    private static string CurrentTimeLog() {
        return $"\n ===================== {DateTime.Now} =====================\n";
    }
}
