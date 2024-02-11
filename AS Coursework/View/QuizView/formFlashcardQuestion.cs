using AS_Coursework._Helpers;
using AS_Coursework.Model.Quiz;

namespace AS_Coursework.View.QuizView;
public partial class formFlashcardQuestion : Form, IQuestionForm {
    private bool _isFrontSide = true;

    private FlashcardQuestion _question;

    public formFlashcardQuestion(FlashcardQuestion flashcardQuestion) {
        InitializeComponent();

        _question = flashcardQuestion;

        // Initialise text
        lblFlashcardText.Text = _question.FrontSide;
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
            lblFlashcardText.Text = _question.FrontSide;
        }
        else {
            lblFlashcardText.Text = _question.BackSide;
        }
    }

    private void btnKnown_Click(object sender, EventArgs e) {
        _question.Answered(true);
        NextQuestion?.Invoke(null, EventArgs.Empty);
    }

    private void btnNext_Click(object sender, EventArgs e) {
        _question.Answered(false);
        NextQuestion?.Invoke(null, EventArgs.Empty);
    }
}
