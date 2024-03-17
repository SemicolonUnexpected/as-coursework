using System.Text.RegularExpressions;
using AS_Coursework.View.QuizView;
using Csv;

namespace AS_Coursework.Model.Quiz;
public class TypingQuestion : Question {
    private readonly Regex _correctAnswerRegex;
    public string Question { get; init; }
    public string CorrectAnswer { get; init; }
    public override string QuestionDescription => base.QuestionDescription + " - " + Question;

    public TypingQuestion(string questionName, string question, string correctAnswer, string correctAnswerRegex) : base(questionName) {
        Question = question;
        CorrectAnswer = correctAnswer;
        _correctAnswerRegex = new Regex(correctAnswerRegex, RegexOptions.IgnoreCase);
    }

    public override Form DisplayQuestion() {
        return new formTypingQuestion(this);
    }

    public bool CheckAnswer(string answer) {
        answer = answer.ToLower();
        answer = answer.Trim();
        Correct =  _correctAnswerRegex.IsMatch(answer);
        AllocatedExperience = (bool)Correct ? QuestionDataManager.TypingExperienceAllocation : 0;
        return (bool)Correct;
    }

    public override string ToString() => base.ToString() + "," + Stringer.Stringify(Question) + "," + Stringer.Stringify(CorrectAnswer) + "," + Stringer.Stringify(_correctAnswerRegex.ToString());
}
