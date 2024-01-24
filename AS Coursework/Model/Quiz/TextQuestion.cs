using System.Text.RegularExpressions;
using AS_Coursework.View.QuizView;

namespace AS_Coursework.Model.Quiz;
public class TextQuestion : Question {
    private readonly Regex _correctAnswerRegex;

    public string Question { get; init; }
    public string CorrectAnswer { get; init; }

    public TextQuestion(string questionName, string question, string correctAnswer, Regex correctAnswerRegex) : base(questionName) {
        Question = question;
        CorrectAnswer = correctAnswer;
        _correctAnswerRegex = correctAnswerRegex;
    }

    public override Form DisplayQuestion() {
        return new formTextQuestion(this);
    }

    public bool CheckAnswer(string answer) {
        bool isCorrect =  _correctAnswerRegex.IsMatch(answer);
        AllocatedExperience = isCorrect ? 1 : 0;
        return isCorrect;
    }
}
