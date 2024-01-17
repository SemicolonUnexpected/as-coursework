using AS_Coursework.Model.Quiz;
using System.Text.RegularExpressions;

namespace AS_Coursework.View.Quiz;
public partial class TextQuestion : Form, IQuestionForm {
    private Regex _answerRegex;
    private bool _questionAnswered = false;
    private string _correctAnswer;

    public event EventHandler<QuizQuestionEventArgs>? QuestionAnswered;
    public event EventHandler? NextQuestion;

    public TextQuestion(string title, string question, string correctAnswer, Regex correctAnswerRegex) {
        InitializeComponent();

        lblQuestionTitle.Text = title;
        lblQuestionText.Text = question;
        _answerRegex = correctAnswerRegex;
        _correctAnswer = correctAnswer;
    }

    public TextQuestion(string title, string question, string correctAnswer, Regex correctAnswerRegex, Image image) {
        InitializeComponent();

        lblQuestionTitle.Text = title;
        lblQuestionText.Text = question;
        _answerRegex = correctAnswerRegex;
        _correctAnswer = correctAnswer;
    }

    private void btnSubmitNext_Click(object sender, EventArgs e) {
        if (!_questionAnswered) {
            // Check if the answer is correct
            bool isCorrect = _answerRegex.IsMatch(lblQuestionText.Text);

            // Tell listeners that the question has been answered
            QuestionAnswered?.Invoke(sender, new QuizQuestionEventArgs(isCorrect));
        }
        else {
            NextQuestion?.Invoke(sender, EventArgs.Empty);
        }
    }
}
