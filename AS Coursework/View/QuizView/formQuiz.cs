using AS_Coursework.Model.Quiz;
using AS_Coursework.Custom_Controls;

namespace AS_Coursework.View.QuizView;
public partial class formQuiz : Form {
    private readonly Quiz _quiz;
    private IQuestionForm _questionForm;
    public formQuiz(Quiz.QuizStyle quizStyle) {
        InitializeComponent();

        _quiz = new Quiz(quizStyle);

        DisplayNextQuestion();
    }

    public void DisplayQuestion(Form questionForm) {
        // Form display settings
        questionForm.TopLevel = false;
        questionForm.Visible = true;

        // Display the form in the panel
        pnlQuestionDisplay.Controls.Clear();
        pnlQuestionDisplay.Controls.Add(questionForm);
        questionForm.Dock = DockStyle.Fill;

        _questionForm = (IQuestionForm)questionForm;

        // Subscribe to the next form event
        _questionForm.NextQuestion += NextQuestion;
    }

    private void DisplayNextQuestion() {
        _quiz.NextQuestion(out Form? questionForm);
        if (questionForm is not null) {
            DisplayQuestion(questionForm);
        }
        else {
            (ActiveForm as formMaster)?.DisplayForm(new formQuizFinished(_quiz));
        }
    }

    private void NextQuestion(object? sender, EventArgs e) {
        // Unsubscribe from the event then display the next question
        _questionForm.NextQuestion -= NextQuestion;
        DisplayNextQuestion();
    }

    private void btnExit_Click(object sender, EventArgs e) {
        if (CustomMessageBox.Show("Exit quiz", "Are you sure you want to exit the quiz?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
            (ActiveForm as formMaster)?.DisplayForm(new formQuizFinished(_quiz));
        }
    }
}
