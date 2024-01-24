using AS_Coursework._Helpers;
using AS_Coursework.Model.Quiz;

namespace AS_Coursework.View.QuizView;
public partial class formTextQuestion : Form, IQuestionForm<TextQuestion> {
    private bool _questionAnswered = false;
    public TextQuestion Question { get; init; }

    public event EventHandler? NextQuestion;
    public event EventHandler<QuestionAnsweredEventArgs>? QuestionAnswered;

    // Two constructors to allow use of images
    public formTextQuestion(TextQuestion textQuestion) {
        InitializeComponent();

        lblQuestionTitle.Text = textQuestion.QuestionName;
        lblQuestionText.Text = textQuestion.Question;
        Question = textQuestion;

        // Hide the image as it is not required
        pb.Dispose();
        lblQuestionText.Center();
        lblQuestionText.Size = new Size(800, 500);

        // Clear placeholder text
        lblIsCorrect.Text = "";
    }

    public formTextQuestion(ImageTextQuestion imageTextQuestion) {
        InitializeComponent();

        lblQuestionTitle.Text = imageTextQuestion.QuestionName;
        lblQuestionText.Text = imageTextQuestion.Question;
        Question = imageTextQuestion;

        // Setup the image
        pb.Image = imageTextQuestion.Image;

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
            lblIsCorrect.Text = $"Incorrect, better luck next time. The correct answer was: {Question.CorrectAnswer}";
        }
    }

    // Check and display the answer correctness
    private void btnSubmitNext_Click(object sender, EventArgs e) {
        if (!_questionAnswered) {
            tbAnswer.Enabled = false;
            _questionAnswered = true;

            Question.CheckAnswer(tbAnswer.Text);

            DisplayAnswerCorrectness((bool)Question.Correct!);
            btnSubmitNext.Text = "Next";
        }
        else {
            // Tell listeners that the next question has been requested
            NextQuestion?.Invoke(sender, EventArgs.Empty);
        }
    }
}
