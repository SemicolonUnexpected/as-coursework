using AS_Coursework.Model.Users;
using AS_Coursework.Model.Quiz;
using AS_Coursework.Custom_Controls;

namespace AS_Coursework.View.QuizView;
public partial class formQuiz : Form {
    private readonly User _user;
    private readonly Quiz _quiz;
    public formQuiz(User user, Quiz.QuizStyle quizStyle) {
        InitializeComponent();

        _user = user;
        _quiz = new Quiz(quizStyle);

        DisplayQuestion
    }

    public void DisplayQuestion(Form questionForm) {
        pnlQuestionDisplay.Controls.Clear();
        pnlQuestionDisplay.Controls.Add(questionForm);
        questionForm.Dock = DockStyle.Fill;
    }

    private void NextQuestion(object? sender, EventArgs e) {
        bool gotNextQuestion = _quiz.NextQuestion(out Question? question);
        if (gotNextQuestion) {
            DisplayQuestion(question!.DisplayQuestion());
        }
        else {
            (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(_user));
        }
    }

    private void btnExit_Click(object sender, EventArgs e) {
        if (CustomMessageBox.Show("Exit quiz", "Are you sure you want to exit the quiz?") == DialogResult.OK) {
            (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(_user));
        }
    }
}
