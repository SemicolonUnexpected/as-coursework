using AS_Coursework.View.QuizView;
using Csv;

namespace AS_Coursework.Model.Quiz;
public class MultipleChoiceQuestion : Question {
    public string Question { get; private init; }
    public string CorrectAnswer { get; private init; }
    public string[] IncorrectAnswers { get; private init; }

    public MultipleChoiceQuestion(string questionName, string question, string correctAnswer, params string[] incorrectAnswers) : base(questionName) {
        Question = question;
        CorrectAnswer = correctAnswer;
        IncorrectAnswers = incorrectAnswers;
    }

    public bool CheckAnswer(string answer) {
        bool isCorrect = answer == CorrectAnswer;
        Correct = isCorrect;
        AllocatedExperience = isCorrect ? 3 : 0;
        return isCorrect;
    }

    public override Form DisplayQuestion() {
        return new formMultipleChoiceQuestion(this);
    }

    public override string ToString() => base.ToString() + "," + Stringer.Stringify();
}
