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
        lblText.Text = _question.FrontSide;
        lblQuestionTitle.Text = _question.QuestionName;

        // Ensure the form is correctly formatted
        OnResize(EventArgs.Empty);

        pnl.HorizontalScroll.Maximum = 0;
        pnl.AutoScroll = true;
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        lblQuestionTitle.CenterX();
        pnlFlashcard.CenterX();
        btnSwitchSides.CenterX();
        pnlButtons.CenterX();

        lblText.CenterX();
    }

    public event EventHandler? NextQuestion;

    private void btnSwitchSides_Click(object sender, EventArgs e) {
        _isFrontSide = !_isFrontSide;

        if (_isFrontSide) {
            lblText.Text = _question.FrontSide;
        }
        else {
            lblText.Text = _question.BackSide;
        }

        // Ensure the form is correctly formatted
        OnResize(EventArgs.Empty);
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
