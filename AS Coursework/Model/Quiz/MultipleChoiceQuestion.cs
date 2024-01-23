using AS_Coursework.View.QuizView;

namespace AS_Coursework.Model.Quiz;
public class MultipleChoiceQuestion : Question {
    public string Question {  get; init; }
    public string CorrectAnswer { get; init; }
    public string[] IncorrectAnswers { get; init; }
    public MultipleChoiceQuestion(string questionName, string question, string correctAnswer, params string[] incorrectAnswers) : base(questionName) {
        Question = question;
        CorrectAnswer = correctAnswer;
        IncorrectAnswers = incorrectAnswers;
    }

    public override Form DisplayQuestion() {
        return new formMultipleChoiceQuestion(this);
    }
}
