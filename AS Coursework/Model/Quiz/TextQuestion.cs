using System.Text.RegularExpressions;

namespace AS_Coursework.Model.Quiz; 
internal class TextQuestion : Question<string> {
    public string CorrectAnswer { get; init; }
    public Regex CorrectAnswerRegex { get; init; }

    public TextQuestion(string questionName, string correctAnswer, Regex correctAnswerRegex) : base(questionName) {
        CorrectAnswer = correctAnswer;
        CorrectAnswerRegex = correctAnswerRegex;
    }

    public override IQuestionForm DisplayQuestion() {
        throw new NotImplementedException();
    }

    public override bool AnswerCorrect(string answer) {
        return CorrectAnswerRegex.IsMatch(answer);
    }
}
