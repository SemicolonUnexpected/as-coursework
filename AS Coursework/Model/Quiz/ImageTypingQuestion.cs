using System.Text.RegularExpressions;
using AS_Coursework.View.QuizView;

namespace AS_Coursework.Model.Quiz;
public class ImageTypingQuestion : TypingQuestion {
    private string _imagePath;

    public Image Image {
        get {
            try {
                return new Bitmap(_imagePath);
            }
            catch (System.Exception) {
                return new Bitmap();
            }
        }
    }

    public ImageTypingQuestion(string questionName, string question, string correctAnswer, Regex correctAnswerRegex, string imagePath) : base(questionName, question, correctAnswer, correctAnswerRegex) {
        _imagePath = imagePath;
    }

    public override Form DisplayQuestion() {
        return new formTypingQuestion(this);
    }
}
