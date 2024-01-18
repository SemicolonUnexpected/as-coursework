using AS_Coursework._Helpers;
using AS_Coursework.Model.Quiz;
using System.Text.RegularExpressions;

namespace AS_Coursework.View.Quiz;
public partial class TextQuestion : Form, IQuestionForm {
    private Regex _answerRegex;
    private bool _questionAnswered = false;
    private string _correctAnswer;

    public event EventHandler<QuizQuestionEventArgs>? QuestionAnswered;
    public event EventHandler? NextQuestion;

    public TextQuestion(string questionName, string question, string correctAnswer, Regex correctAnswerRegex) {
        InitializeComponent();

        lblQuestionTitle.Text = questionName;
        lblQuestionText.Text = question;
        _answerRegex = correctAnswerRegex;
        _correctAnswer = correctAnswer;

        // Hide the image as it is not required
        pb.Dispose();
        lblQuestionText.Center();
        lblQuestionText.Size = new Size(800, 500);
    }

    public TextQuestion(string questionName, string question, string correctAnswer, Regex correctAnswerRegex, Image image) {
        InitializeComponent();

        lblQuestionTitle.Text = questionName;
        lblQuestionText.Text = question;
        _answerRegex = correctAnswerRegex;
        _correctAnswer = correctAnswer;
    }

    private void btnSubmitNext_Click(object sender, EventArgs e) {
        if (!_questionAnswered) {
            // Check if the answer is correct
            bool isCorrect = _answerRegex.IsMatch(lblQuestionText.Text);

            // Display the corresponding output depending on if the answer is correct or not
            if (isCorrect) {
                pbIsCorrect.Image = Resources.Icons.Green_Tick_Circle;
                lblIsCorrect.Text = "Correct, well done!";
            }
            else {
                pbIsCorrect.Image = Resources.Icons.Red_Cross_Circle;
                lblIsCorrect.Text = $"Incorrect, better luck next time. The correct answer was: {_correctAnswer}";
            }

            // Tell listeners that the question has been answered
            QuestionAnswered?.Invoke(sender, new QuizQuestionEventArgs(isCorrect));
            _questionAnswered = true;
        }
        else {
            // Tell listeners that the next question has been requested
            NextQuestion?.Invoke(sender, EventArgs.Empty);
        }
    }
}
