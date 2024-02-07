using Csv;
using System.Web;

namespace AS_Coursework.Model.Quiz;
public static class QuestionDataManager {
    private const string PATH_MULTIPLECHOICE = "Questions/MultipleChoice.txt";
    public static List<Question> MultipleChoice { get; private set; }
    private const string PATH_TEXT = "Questions/Text.txt";
    public static List<Question> Text { get; private set; }
    private const string PATH_FLASHCARD = "Questions/Flashcard.txt";
    public static List<Question> Flashcard { get; private set; }
    private const string PATH_MATCHING = "Questions/Matching.txt";
    public static List<Question> Matching { get; private set; } 
    private const string PATH_EQUATIONS = "Questions/Equations.txt";
    public static List<Question> Equation { get; private set; }

    public static List<Question> All {
        get {
            List<Question> result = new();

            result.AddRange(MultipleChoice);
            result.AddRange(Text);
            result.AddRange(Flashcard);
            result.AddRange(Matching);
            result.AddRange(Equation);

            return result;
        }
    }

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

        string[][] fieldGroups = (string[][])Parser.ParseText(text)!;

        foreach (string question in fields) {
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
                MultipleChoice.Add(new ImageTextQuestion(
                    fields[0],
                    fields[1],
                    fields[2],
                    new System.Text.RegularExpressions.Regex(fields[3]),
                    new Bitmap($"Images{fields[4]}")
                    ));
            }
            else throw new IOException("Could not read the file, the question format was incorrect");
        }
    }
}
