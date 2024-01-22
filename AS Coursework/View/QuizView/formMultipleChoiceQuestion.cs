using AS_Coursework.Custom_Controls;
using AS_Coursework.Model.Quiz;

namespace AS_Coursework.View.QuizView;
public partial class formMultipleChoiceQuestion : Form, IQuestionForm<MultipleChoiceQuestion> {
    public MultipleChoiceQuestion Question { get; init; }
    public formMultipleChoiceQuestion(MultipleChoiceQuestion multipleChoiceQuestion) {
        InitializeComponent();

        btnNext.Visible = false;
        Question = multipleChoiceQuestion;
    }

    public event EventHandler? NextQuestion;
    public event EventHandler<QuestionAnsweredEventArgs>? QuestionAnswered;


    private void SetupQuestionsAnswers() {
        Random random = new();

        int answerPosition = random.Next(0, 4);
        switch (answerPosition) {
            case 0:
                btnOptionOne.Text = Question.CorrectAnswer;
                break;
            case 1:
                btnOptionTwo.Text = Question.CorrectAnswer;
                break;
            case 2:
                btnOptionThree.Text = Question.CorrectAnswer;
                break;
            case 3:
                btnOptionFour.Text = Question.CorrectAnswer;
                break;
        }
    }

    private void btnCorrect(CustomButton sender, EventArgs e) {
        sender.BackColor = Color.Green;
        btnNext.Visible = true;
    }

    private void btnNext_Click(object? sender, EventArgs e) {
        NextQuestion?.Invoke(this, EventArgs.Empty);
    }
}
