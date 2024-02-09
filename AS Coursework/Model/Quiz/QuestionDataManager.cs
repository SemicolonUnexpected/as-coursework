using Csv;

namespace AS_Coursework.Model.Quiz;
public static class QuestionDataManager {
    private const string PATH_MULTIPLECHOICE = "Questions/MultipleChoice.txt";
    public static List<Question> MultipleChoice { get; private set; }
    private const string PATH_TEXT = "Questions/Text.txt";
    public static List<Question> Text { get; private set; }
    private const string PATH_FLASHCARD = "Questions/Flashcard.txt";
    public static List<Question> Flashcard { get; private set; } = ReadInFlashcard();
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

    private static void ReadIn() {
        ReadInMultipleChoice();
        ReadInText();
        ReadInFlashcard();
        // ReadInMatching();
        ReadInEquations();
    }

    private static readonly Dictionary<string, Image> nameToImage = new() {
    };

    private static void ReadInMultipleChoice() {
        using StreamReader reader = new(PATH_TEXT);

        string text = reader.ReadToEnd();

        string[][] fieldGroups = (string[][])Parser.ParseText(text)!;

        foreach (string[] fields in fieldGroups) {
            MultipleChoice.Add(new MultipleChoiceQuestion(
                fields[0],
                fields[1],
                fields[2],
                fields.TakeLast(fields.Length - 3).ToArray()));
        }
    }

    private static void ReadInText() {
        using StreamReader reader = new(PATH_TEXT);

        string text = reader.ReadToEnd();

        string[][] fieldGroups = (string[][])Parser.ParseText(text)!;

        foreach (string[] fields in fieldGroups) {
            Text.Add(new TextQuestion(
                fields[0],
                fields[1],
                fields[2],
                new System.Text.RegularExpressions.Regex(fields[3])));
        }
    }

    private static List<Question> ReadInFlashcard() {
        using StreamReader reader = new(PATH_FLASHCARD);

        string text = reader.ReadToEnd();

        string[][] fieldGroups = (string[][]) Parser.ParseText(text)!;

        List<Question> questions = new();
        foreach (string[] fields in fieldGroups) {
            questions.Add(new FlashcardQuestion(
                fields[0],
                fields[1],
                fields[2]));
        }

        return questions;
    }

    private static void ReadInMatching() {
        using StreamReader reader = new(PATH_MATCHING);

        string text = reader.ReadToEnd();

        string[][] fieldGroups = (string[][])Parser.ParseText(text)!;

        foreach (string[] fields in fieldGroups) {
            //Matching.Add(new MatchingQuestion(
            //    fields[0],
            //    fields))
        }
    }

    private static void ReadInEquations() {
        using StreamReader reader = new(PATH_EQUATIONS);

        string text = reader.ReadToEnd();

        string[][] fieldGroups = (string[][])Parser.ParseText(text)!;

        foreach (string[] fields in fieldGroups) {
            Equation.Add(new EquationQuestion(
                fields[0],
                fields[1]));
        }
    }
}
