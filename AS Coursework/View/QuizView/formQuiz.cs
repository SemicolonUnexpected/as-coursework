using AS_Coursework.Model.Quiz;
using AS_Coursework.Custom_Controls;

namespace AS_Coursework.View.QuizView;
public partial class formQuiz : Form {
    private readonly Quiz _quiz;
    public formQuiz(Quiz.QuizStyle quizStyle) {
        InitializeComponent();

        _quiz = new Quiz(quizStyle);

        DisplayNextQuestion();
    }

    public void DisplayQuestion(Form questionForm) {
        questionForm.TopLevel = false;
        pnlQuestionDisplay.Controls.Clear();
        pnlQuestionDisplay.Controls.Add(questionForm);
        questionForm.Dock = DockStyle.Fill;
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
        DisplayNextQuestion();
    }

    private void btnExit_Click(object sender, EventArgs e) {
        if (CustomMessageBox.Show("Exit quiz", "Are you sure you want to exit the quiz?") == DialogResult.OK) {
            (ActiveForm as formMaster)?.DisplayForm(new formQuizFinished(_quiz));
        }
    }
}
