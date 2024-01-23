namespace AS_Coursework.Model.Quiz;
public class Quiz {
    private readonly QuizStyle _quizStyle;
    private readonly List<Question> _questions;
    private int _index = -1;

    public Quiz(QuizStyle quizStyle) {
        _quizStyle = quizStyle;

        PopulateQuiz(quizStyle);
    }

    public int Length { get => _questions.Count; }

    public Question NextQuestion() {
        _index += 1;
        return _questions[_index];
    }
/*
    private List<Question> PopulateQuiz(QuizStyle quizStyle, int questionCount) => quizStyle switch {
        QuizStyle.All => PickAll(questionCount),
        QuizStyle.MultipleChoice => PickMultipleChoice(questionCount),
        QuizStyle.Text => PickText(questionCount),
        QuizStyle.FillTheBlanks => PickFillTheBlanks(questionCount),
        QuizStyle.FlashCards => PickFlashcards(questionCount),
        QuizStyle.Equations => PickEquations(questionCount),
    };

    private List<Question> PickAll(int questionCount) { }
    private List<Question> PickMultipleChoice(int questionCount) { }
    private List<Question> PickText(int  questionCount) { }
    private List<Question> PickFillTheBlanks(int questionCount) { }
    private List<Question> PickFlashcards(int questionCount) { }
    private List<Question> PickEquations(int questionCount) { }
*/
    // The modern variation of the Fisher-Yates Shuffle

    public enum QuizStyle {
        All,
        MultipleChoice,
        Text,
        FillTheBlanks,
        FlashCards,
        Equations
    }
}
