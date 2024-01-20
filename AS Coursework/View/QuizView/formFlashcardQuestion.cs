using AS_Coursework.Model.Quiz;

namespace AS_Coursework.View.QuizView;
public partial class formFlashcardQuestion : Form, IQuestionForm {
    private bool _isFrontSide = true;
    private string _frontSide;
    private string _backSide;
    public formFlashcardQuestion(string frontSide, string backSide) {
        InitializeComponent();

        _frontSide = frontSide;
        _backSide = backSide;

        // Initialise text
        lblFlashcardText.Text = frontSide;
    }

    public event EventHandler<QuizQuestionEventArgs<bool>>? QuestionAnswered;
    public event EventHandler? NextQuestion;

    public void DisplayAnswerCorrectness(bool isCorrect) {
        throw new NotImplementedException();
    }

    private void btnSwitchSides_Click(object sender, EventArgs e) {
        _isFrontSide = !_isFrontSide;

        if (_isFrontSide) {
            lblFlashcardText.Text = _frontSide;
        }
        else {
            lblFlashcardText.Text = _backSide;
        }
    }

    private void btnNext_Click(object sender, EventArgs e) {
        NextQuestion?.Invoke(this, EventArgs.Empty);
    }
}
