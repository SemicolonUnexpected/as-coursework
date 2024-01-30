namespace AS_Coursework.Model.Quiz;
public static class QuestionDataManager {
    private const string PATH_MULTIPLECHOICE = "questions/multiplechoice.txt";
    public static List<Question> MultipleChoice { get; private set; }
    private const string PATH_TEXT = "questions/text.txt";
    public static List<Question> Text { get; private set; }
    private const string PATH_FLASHCARD = "questions/flashcard.txt";
    public static List<Question> Flashcard { get; private set; }
    private const string PATH_FILLTHEBLANKS = "questions/filltheblanks.txt";
    public static List<Question> Matching { get; private set; } 
    private const string PATH_EQUATIONS = "questions/equations.txt";
    public static List<Question> Equation { get; private set; }

    static QuestionDataManager() {
        ReadIn();
    }

    private static void ReadIn() {
        ReadInTextQuestions();
    }

    private static readonly Dictionary<string, Image> nameToImage = new() {
    };

    private static void ReadInTextQuestions() {
        MultipleChoice = new List<Question>();

        using StreamReader reader = new StreamReader(PATH_TEXT);

        string text = reader.ReadToEnd();
        string[] lines = text.Split("\n");

        foreach (string line in lines) {
            string[] fields = line.Split(",");

            if (fields.Length == 4) {
                MultipleChoice.Add(new TextQuestion(
                    fields[0],
                    fields[1],
                    fields[2],
                    new System.Text.RegularExpressions.Regex(fields[3])));
            }
            else if (fields.Length == 5) {
                throw new NotImplementedException();
                /*
                MultipleChoice.Add(new ImageTextQuestion(
                    fields[0],
                    fields[1],
                    fields[2],
                    new System.Text.RegularExpressions.Regex(fields[3]),
                    Resources.QuizImages.
                    ));
                */
            }
            else throw new IOException("Could not read the file, the question format was incorrect");
        }
    }
}
