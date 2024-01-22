using System.Text.RegularExpressions;
using AS_Coursework.View.QuizView;

namespace AS_Coursework.Model.Quiz;
public class ImageTextQuestion : TextQuestion {
    public Image Image { get; init; }
    public ImageTextQuestion(string questionName, string question, string correctAnswer, Regex correctAnswerRegex, Image image) : base(questionName, question, correctAnswer, correctAnswerRegex) {
        Image = image;
    }

    public override Form DisplayQuestion() {
        return new formTextQuestion(this);
    }
}
