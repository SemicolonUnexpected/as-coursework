using System.Text.RegularExpressions;
using AS_Coursework.View.QuizView;

namespace AS_Coursework.Model.Quiz;
public class TypingQuestion : Question {
    private readonly Regex _correctAnswerRegex;
    public string Question { get; init; }
    public string CorrectAnswer { get; init; }

    public TypingQuestion(string questionName, string question, string correctAnswer, Regex correctAnswerRegex) : base(questionName) {
        Question = question;
        CorrectAnswer = correctAnswer;
        _correctAnswerRegex = correctAnswerRegex;
    }

    public override Form DisplayQuestion() {
        return new formTypingQuestion(this);
    }

    public bool CheckAnswer(string answer) {
        answer = answer.ToLower();
        answer.Trim();
        Correct =  _correctAnswerRegex.IsMatch(answer);
        AllocatedExperience = (bool)Correct ? 10 : 0;
        return (bool)Correct;
    }
}
