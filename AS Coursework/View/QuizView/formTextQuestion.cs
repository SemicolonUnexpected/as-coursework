using AS_Coursework._Helpers;
using AS_Coursework.Model.Quiz;

namespace AS_Coursework.View.QuizView;
public partial class formTextQuestion : Form, IQuestionForm<string> {
    private bool _questionAnswered = false;
    private string _correctAnswer;

    public event EventHandler<QuizQuestionEventArgs<string>>? QuestionAnswered;
    public event EventHandler? NextQuestion;

    public formTextQuestion(string questionName, string question, string correctAnswer) {
        InitializeComponent();

        lblQuestionTitle.Text = questionName;
        lblQuestionText.Text = question;
        _correctAnswer = correctAnswer;

        // Hide the image as it is not required
        pb.Dispose();
        lblQuestionText.Center();
        lblQuestionText.Size = new Size(800, 500);

        // Clear placeholder text
        lblIsCorrect.Text = "";
    }

    public formTextQuestion(string questionName, string question, string correctAnswer, Image image) {
        InitializeComponent();

        lblQuestionTitle.Text = questionName;
        lblQuestionText.Text = question;
        _correctAnswer = correctAnswer;

        // Clear placeholder text
        lblIsCorrect.Text = "";
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        lblQuestionTitle.CenterX();
        lblQuestionText.CenterX();
        pnlAnswer.CenterX();
        pb.CenterX();

        lblAnswerTitle.CenterY();
        tbAnswer.CenterY();
        btnSubmitNext.CenterY();
        pbIsCorrect.CenterY();
    }

    public void DisplayAnswerCorrectness(bool isCorrect) {
        // Display the corresponding output depending on if the answer is correct or not
        if (isCorrect) {
            pbIsCorrect.Image = Resources.Icons.Green_Tick_Circle;
            lblIsCorrect.Text = "Correct, well done!";
        }
        else {
            pbIsCorrect.Image = Resources.Icons.Red_Cross_Circle;
            lblIsCorrect.Text = $"Incorrect, better luck next time. The correct answer was: {_correctAnswer}";
        }
    }

    private void btnSubmitNext_Click(object sender, EventArgs e) {
        if (!_questionAnswered) {
            // Submit the answer to the question manager with this event
            QuestionAnswered?.Invoke(sender, new QuizQuestionEventArgs<string>(tbAnswer.Text));
            tbAnswer.Enabled = false;
            _questionAnswered = true;
        }
        else {
            // Tell listeners that the next question has been requested
            NextQuestion?.Invoke(sender, EventArgs.Empty);
        }
    }
}
