using AS_Coursework._Helpers;
using AS_Coursework.Model.Quiz;

namespace AS_Coursework.View.QuizView;
public partial class formFlashcardQuestion : Form, IQuestionForm<FlashcardQuestion> {
    private bool _isFrontSide = true;

    public FlashcardQuestion Question { get; init; }

    public formFlashcardQuestion(FlashcardQuestion flashcardQuestion) {
        InitializeComponent();

        Question = flashcardQuestion;

        // Initialise text
        lblFlashcardText.Text = Question.FrontSide;
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        lblQuestionTitle.CenterX();
        pnlFlashcard.CenterX();
        btnSwitchSides.CenterX();
        pnlButtons.CenterX();
    }

    public event EventHandler? NextQuestion;

    private void btnSwitchSides_Click(object sender, EventArgs e) {
        _isFrontSide = !_isFrontSide;

        if (_isFrontSide) {
            lblFlashcardText.Text = Question.FrontSide;
        }
        else {
            lblFlashcardText.Text = Question.BackSide;
        }
    }

    private void btnKnown_Click(object sender, EventArgs e) {
        Question.Answered(true);
        NextQuestion?.Invoke(null, EventArgs.Empty);
    }
}
