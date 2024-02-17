using AS_Coursework._Helpers;
using AS_Coursework.Custom_Controls;
using AS_Coursework.Model.Quiz;

namespace AS_Coursework.View.QuizView;
public partial class formMultipleChoiceQuestion : Form, IQuestionForm {
    private MultipleChoiceQuestion _question;
    private List<CustomButton> _customButtons;
    private readonly Random _random = new();

    private CustomButton? _correctButton;
    public formMultipleChoiceQuestion(MultipleChoiceQuestion multipleChoiceQuestion) {
        InitializeComponent();

        btnNext.Visible = false;
        _question = multipleChoiceQuestion;

        lblQuestionTitle.Text = _question.QuestionName;

        lblQuestionText.Text = _question.Question;

        _customButtons = new() { btnOptionOne, btnOptionTwo, btnOptionThree, btnOptionFour };

        SetupQuestionsAnswers();
    }

    public event EventHandler? NextQuestion;

    private void SetupQuestionsAnswers() {
        _correctButton = _random.Next(0, 4) switch {
            0 => btnOptionOne,
            1 => btnOptionTwo,
            2 => btnOptionThree,
            _ => btnOptionFour,
        };

        _question.IncorrectAnswers.Shuffle();
        Queue<string> incorrectAnswers = new(_question.IncorrectAnswers.Take(3).ToList());

        foreach (CustomButton button in _customButtons) {
            if (!button.Equals(_correctButton)) {
                button.Text = incorrectAnswers.Dequeue();
            }
            else {
                button.Text = _question.CorrectAnswer;
            }
        }
    }

    private void btnClick(object? sender, EventArgs e) {
        // Disable all the buttons so the user can only answer once
        foreach (CustomButton button in _customButtons) button.Enabled = false;

        CustomButton btn = (CustomButton)sender!;
        if (_question.CheckAnswer(btn.Text)) {
            btn.BackColor = Color.Green;
        }
        else {
            btn.BackColor = Color.Red;
            _correctButton!.BackColor = Color.Green;
        }

        btnNext.Visible = true;
    }

    private void btnNext_Click(object? sender, EventArgs e) {
        NextQuestion?.Invoke(this, EventArgs.Empty);
    }
}
