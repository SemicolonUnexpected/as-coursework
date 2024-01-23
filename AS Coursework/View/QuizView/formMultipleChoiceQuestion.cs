using AS_Coursework._Helpers;
using AS_Coursework.Custom_Controls;
using AS_Coursework.Model.Quiz;
using System.Security.AccessControl;

namespace AS_Coursework.View.QuizView;
public partial class formMultipleChoiceQuestion : Form, IQuestionForm<MultipleChoiceQuestion> {
    public MultipleChoiceQuestion Question { get; init; }
    private readonly Random _random = new();

    private CustomButton? _correctButton;
    public formMultipleChoiceQuestion(MultipleChoiceQuestion multipleChoiceQuestion) {
        InitializeComponent();

        btnNext.Visible = false;
        Question = multipleChoiceQuestion;

        SetupQuestionsAnswers();
    }

    public event EventHandler? NextQuestion;
    public event EventHandler<QuestionAnsweredEventArgs>? QuestionAnswered;

    private void SetupQuestionsAnswers() {
        _correctButton = _random.Next(0, 4) switch {
            0 => btnOptionOne,
            1 => btnOptionTwo,
            2 => btnOptionThree,
            _ => btnOptionFour,
        };

        List<CustomButton> buttons = new() { btnOptionOne, btnOptionTwo, btnOptionThree, btnOptionFour };
        Question.IncorrectAnswers.Shuffle();
        Queue<string> incorrectAnswers = new Queue<string>(Question.IncorrectAnswers.Take(3).ToList());

        foreach (CustomButton button in buttons) {
            if (!button.Equals(_correctButton)) {
                button.Text = incorrectAnswers.Dequeue();
            }
        }
    }

    private void btnClick(object? sender, EventArgs e) {
        CustomButton btn = (CustomButton)sender!;
        if (sender!.Equals(_correctButton)) {
            btn.BackColor = Color.Green;
            QuestionAnswered?.Invoke(this, new QuestionAnsweredEventArgs(true, 1));
        }
        else {
            btn.BackColor = Color.Red;
            _correctButton.BackColor = Color.Green;
            QuestionAnswered?.Invoke(this, new QuestionAnsweredEventArgs(false, 0));
        }

        btnNext.Visible = true;
    }

    private void btnNext_Click(object? sender, EventArgs e) {
        NextQuestion?.Invoke(this, EventArgs.Empty);
    }
}
