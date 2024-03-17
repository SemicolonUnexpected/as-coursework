using AS_Coursework.View.QuizView;

namespace AS_Coursework.Model.Quiz;
// A class that can display an image with a text question
public class ImageTypingQuestion : TypingQuestion {
    private string _imagePath;

    public Image Image {
        get {
            try {
                return new Bitmap(_imagePath);
            }
            catch (Exception) {
                return Resources.Icons.Icons.Red_Cross_Circle;
            }
        }
    }

    public ImageTypingQuestion(string questionName, string question, string correctAnswer, string correctAnswerRegex, string imagePath) : base(questionName, question, correctAnswer, correctAnswerRegex) {
        _imagePath = imagePath;
    }

    public override Form DisplayQuestion() {
        return new formTypingQuestion(this);
    }

    public override string ToString() => base.ToString() + "," + _imagePath; 
}
