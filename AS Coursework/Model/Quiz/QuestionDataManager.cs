namespace AS_Coursework.Model.Quiz;
public static class QuestionDataManager {
    private const string PATH_MULTIPLECHOICE = "questions/multiplechoice.txt";
    public static List<TextQuestion> MultipleChoice { get; private set; }
    private const string PATH_TEXT = "questions/text.txt";
    public static List<TextQuestion> Text { get; private set; }
    private const string PATH_FLASHCARD = "questions/flashcard.txt";
    public static List<TextQuestion> Flashcard { get; private set; }
    private const string PATH_FILLTHEBLANKS = "questions/filltheblanks.txt";
    public static List<TextQuestion> FillTheBlanks { get; private set; } 
    private const string PATH_EQUATIONS = "questions/equations.txt";
    public static List<TextQuestion> Equations { get; private set; }

    static QuestionDataManager() {

    }

    private static void ReadIn() {

    }

    private static void ReadInTextQuestions() {
        MultipleChoice = new List<TextQuestion>();

        using StreamReader reader = new StreamReader(PATH_TEXT);

        string text = reader.ReadToEnd();
        string[] lines = text.Split("\n");

        foreach (string line in lines) {
            string[] fields = line.Split(", ");

            if (fields.Length == 4) {
                MultipleChoice.Add(new TextQuestion(
                    fields[0],
                    fields[1],
                    fields[2],
                    new System.Text.RegularExpressions.Regex(fields[3])));
            }
            else {

            }
        }
    }
}
