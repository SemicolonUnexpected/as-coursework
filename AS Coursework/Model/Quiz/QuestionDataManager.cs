using Chem;
using Csv;
using System.Text.RegularExpressions;

namespace AS_Coursework.Model.Quiz;
public static class QuestionDataManager {
    private const string PATH_SETTNGS = "Questions/QuizSettings.txt";
    public static int QuestionCount { get; set; }

    // Question data fields
    private const string PATH_MULTIPLECHOICE = "Questions/MultipleChoice.txt";
    public static List<Question> MultipleChoice { get; private set; } = new List<Question>();
    public static int MultipleChoiceExperienceAllocation { get; set; }
    private const string PATH_TYPING = "Questions/Typing.txt";
    public static List<Question> Typing { get; private set; } = new List<Question>();
    public static int TypingExperienceAllocation { get; set; }
    private const string PATH_FLASHCARD = "Questions/Flashcard.txt";
    public static List<Question> Flashcard { get; private set; } = new List<Question>();
    public static int FlashcardExperienceAllocation { get; set; }
    private const string PATH_MATCHING = "Questions/Matching.txt";
    public static List<Question> Matching { get; private set; } = new List<Question>();
    public static int MatchingExperienceAllocation { get; set; }
    private const string PATH_EQUATIONS = "Questions/Equation.txt";
    public static List<Question> Equation { get; private set; } = new List<Question>();
    public static int EquationExperienceAllocation { get; set; }

    // The all list is all the question lists combined
    public static List<Question> All {
        get {
            List<Question> result = new();

            result.AddRange(MultipleChoice);
            result.AddRange(Typing);
            result.AddRange(Flashcard);
            result.AddRange(Matching);
            result.AddRange(Equation);

            return result;
        }
    }

    #region Reading

    public static void ReadIn() {
        ReadInSettings();

        // Read in all the questions
        MultipleChoice = ReadInMultipleChoice();
        Matching = ReadInMatching();
        Typing = ReadInTyping();
        Equation = ReadInEquation();
        Flashcard = ReadInFlashcard();
    }

    private static void ReadInSettings() {
        // Read the settings file
        using StreamReader reader = new(PATH_SETTNGS);

        string text = reader.ReadToEnd();

        // Read in the settings based on the regular expressions
        Regex QuestionCounter = new(@"Question count : (\d+)");
        QuestionCount = int.Parse(QuestionCounter.Match(text).Groups[1].Value);

        Regex MultipleChoice = new(@"Multiple choice : (\d+)");
        MultipleChoiceExperienceAllocation = int.Parse(MultipleChoice.Match(text).Groups[1].Value);

        Regex Matching = new(@"Matching : (\d+)");
        MatchingExperienceAllocation = int.Parse(Matching.Match(text).Groups[1].Value);

        Regex Typing = new(@"Typing : (\d+)");
        TypingExperienceAllocation = int.Parse(Typing.Match(text).Groups[1].Value);

        Regex Equation = new(@"Equation : (\d+)");
        EquationExperienceAllocation = int.Parse(Equation.Match(text).Groups[1].Value);

        Regex Flashcard = new(@"Flashcard : (\d+)");
        FlashcardExperienceAllocation = int.Parse(Flashcard.Match(text).Groups[1].Value);
    }

    private static List<Question> ReadInMultipleChoice() {
        using StreamReader reader = new(PATH_MULTIPLECHOICE);

        string text = reader.ReadToEnd();

        string[][] fieldGroups = (string[][])Parser.ParseText(text.TrimEnd())!;

        List<Question> questions = new();

        if (string.IsNullOrEmpty(text)) return questions;

        foreach (string[] fields in fieldGroups) {
            if (fields.Length < 6) throw new QuestionDataException("A multiple choice question needs to have at least six fields");

            questions.Add(new MultipleChoiceQuestion(
                fields[0],
                fields[1],
                fields[2],
                fields.TakeLast(fields.Length - 3).ToArray()));
        }

        return questions;
    }

    private static List<Question> ReadInTyping() {
        using StreamReader reader = new(PATH_TYPING);

        string text = reader.ReadToEnd();

        string[][] fieldGroups = (string[][])Parser.ParseText(text.TrimEnd())!;

        List<Question> questions = new();

        if (string.IsNullOrEmpty(text)) return questions;

        foreach (string[] fields in fieldGroups) {
            if (fields.Length > 5) throw new QuestionDataException("A text question needs four fields or five fields if it is an image text question");

            if (fields.Length == 4) {
                questions.Add(new TypingQuestion(
                    fields[0],
                    fields[1],
                    fields[2],
                    fields[3]));
            }
            else {
                questions.Add(new ImageTypingQuestion(
                    fields[0],
                    fields[1],
                    fields[2],
                    fields[3],
                    fields[4]));
            }
        }

        return questions;
    }

    private static List<Question> ReadInFlashcard() {
        using StreamReader reader = new(PATH_FLASHCARD);

        string text = reader.ReadToEnd();

        string[][] fieldGroups = (string[][]) Parser.ParseText(text.TrimEnd())!;

        List<Question> questions = new();

        if (string.IsNullOrEmpty(text)) return questions;

        foreach (string[] fields in fieldGroups) {
            if (fields.Length != 3) throw new QuestionDataException("A flashcard needs 3 fields");

            questions.Add(new FlashcardQuestion(
                fields[0],
                fields[1],
                fields[2]));
        }

        return questions;
    }

    private static List<Question> ReadInMatching() {
        using StreamReader reader = new(PATH_MATCHING);

        string text = reader.ReadToEnd();

        string[][] fieldGroups = (string[][])Parser.ParseText(text.TrimEnd())!;

        List<Question> questions = new();

        if (string.IsNullOrEmpty(text)) return questions;

        foreach (string[] fields in fieldGroups) {
            if (fields.Length % 2 != 1) throw new QuestionDataException("Ensure all matching question pairs are paired correctly");
            if (fields.Length < 9) throw new QuestionDataException("Ensure there are at least 4 answer pairs");

            Dictionary<string, string> answerPairs = new();

            for (int i = 1; i < fields.Length; i += 2) {
                answerPairs.Add(fields[i], fields[i + 1]);
            }

            questions.Add(new MatchingQuestion(fields[0], answerPairs));
        }

        return questions;
    }

    private static List<Question> ReadInEquation() {
        using StreamReader reader = new(PATH_EQUATIONS);

        string text = reader.ReadToEnd();

        string[][] fieldGroups = (string[][])Parser.ParseText(text.TrimEnd())!;

        List<Question> questions = new();

        if (string.IsNullOrEmpty(text)) return questions;

        foreach (string[] fields in fieldGroups) {
            if (fields.Length != 3) throw new QuestionDataException("An equation question requires three fields");
            questions.Add(new EquationQuestion(
                fields[0],
                fields[1],
                new Equation(fields[2])));
        }

        return questions;
    }

    #endregion

    #region Writing
    
    private static void WriteSettings() {
        using StreamWriter writer = new(PATH_SETTNGS);

        string data = $"""
            Question count : {QuestionCount}
            Multiple choice : {MultipleChoiceExperienceAllocation}
            Matching : {MatchingExperienceAllocation}
            Typing : {TypingExperienceAllocation}
            Equation : {EquationExperienceAllocation}
            Flashcard : {FlashcardExperienceAllocation}
            """;
            
        writer.Write(data);
    }

    private static void WriteQuestions() {
        // Save the questions to the file

        using(StreamWriter writer = new(PATH_EQUATIONS)) {
            foreach(Question question in Equation) {
                writer.Write(question.ToString() + "\n");
            }
        }
        
        using(StreamWriter writer = new(PATH_FLASHCARD)) {
            foreach(Question question in Flashcard) {
                writer.Write(question.ToString() + "\n");
            }
        }

        using(StreamWriter writer = new(PATH_MATCHING)) {
            foreach(Question question in Matching) {
                writer.Write(question.ToString() + "\n");
            }
        }

        using(StreamWriter writer = new(PATH_MULTIPLECHOICE)) {
            foreach(Question question in MultipleChoice) {
                writer.Write(question.ToString() + "\n");
            }
        }

        using(StreamWriter writer = new(PATH_TYPING)) {
            foreach(Question question in Typing) {
                writer.Write(question.ToString() + "\n");
            }
        }
    }

    public static void Write() {
        WriteSettings();
        WriteQuestions();
    }

    public static void RemoveQuestion(Question question) {
        if (question is MultipleChoiceQuestion) MultipleChoice.Remove(question);
        if (question is MatchingQuestion) Matching.Remove(question);
        if (question is TypingQuestion) Typing.Remove(question);
        if (question is EquationQuestion) Equation.Remove(question);
        if (question is FlashcardQuestion) Flashcard.Remove(question);
    }

    #endregion
}
