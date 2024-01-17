namespace AS_Coursework.Model.Quiz;
public static class QuestionManager {
    private const string PATH = "";

    private static List<Question> _textQuestions { get; set; } = new();
    private static List<Question> _multipleChoiceQuestions { get; set; } = new();
    private static List<Question> _fillTheBlanksQuestions { get; set; } = new();

    static QuestionManager() {
        PopulateQuestions();
    }

    private static void PopulateQuestions() {

    }
}
