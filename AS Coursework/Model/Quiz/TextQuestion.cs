using System.Text.RegularExpressions;

namespace AS_Coursework.Model.Quiz; 
public class TextQuestion : Question {
    public string CorrectAnswer { get; init; }
    public Regex CorrectAnswerRegex { get; init; }

    public TextQuestion(string questionName, string correctAnswer, Regex correctAnswerRegex) : base(questionName) {
        CorrectAnswer = correctAnswer;
        CorrectAnswerRegex = correctAnswerRegex;
    }

    public override Form DisplayQuestion() {
        throw new NotImplementedException();
    }

    public override bool AnswerCorrect<string>(string answer) {
        return CorrectAnswerRegex.IsMatch(answer);
    }

    public override bool AnswerCorrect<TAnswer>(TAnswer answer) {
        throw new NotImplementedException();
    }
}
