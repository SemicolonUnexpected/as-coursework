using System.Text.RegularExpressions;
using AS_Coursework.View.QuizView;

namespace AS_Coursework.Model.Quiz;
public class TextQuestion : Question {
    public string Question { get; init; }
    public string CorrectAnswer { get; init; }
    private readonly Regex _correctAnswerRegex;

    public TextQuestion(string questionName, string question, string correctAnswer, Regex correctAnswerRegex) : base(questionName) {
        Question = question;
        CorrectAnswer = correctAnswer;
        _correctAnswerRegex = correctAnswerRegex;
    }

    public override Form DisplayQuestion() {
        return new formTextQuestion(this);
    }

    public bool CheckAnswer(string answer) {
        return _correctAnswerRegex.IsMatch(answer);
    }
}
