using System.Text.RegularExpressions;
using AS_Coursework.View.QuizView;

namespace AS_Coursework.Model.Quiz;
public class ImageTypingQuestion : TypingQuestion {
    public Image Image { get; private init; }

    public ImageTypingQuestion(string questionName, string question, string correctAnswer, Regex correctAnswerRegex, Image image) : base(questionName, question, correctAnswer, correctAnswerRegex) {
        Image = image;
    }

    public override Form DisplayQuestion() {
        return new formTypingQuestion(this);
    }
}
