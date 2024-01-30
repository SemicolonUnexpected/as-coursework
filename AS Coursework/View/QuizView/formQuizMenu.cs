using AS_Coursework.Model.Users;
using AS_Coursework.Model.Quiz;

namespace AS_Coursework.View.QuizView;
public partial class formQuizMenu : Form {
    public formQuizMenu() {
        InitializeComponent();

        lblUsername.Text = User.ActiveUser!.AuthenticationDetails.Username;
        pbUserProfile.Image = User.ActiveUser!.FunctionalDetails.ProfileImage.Image;
    }

    private void btnAllQuestions_Click(object sender, EventArgs e) {
        Quiz.QuizStyle quizStyle = nameof(sender) switch {
            nameof(btnAll) => Quiz.QuizStyle.All,
            nameof(btnText) => Quiz.QuizStyle.Text,
            nameof(btnMultipleChoice) => Quiz.QuizStyle.MultipleChoice,
            nameof(btnFillTheBlanks) => Quiz.QuizStyle.Matching,
            nameof(btnFlashcards) => Quiz.QuizStyle.FlashCard,
            nameof(btnEquations) => Quiz.QuizStyle.Equation,
            _ => throw new NotImplementedException()
        };
    }

    private void StartQuiz(Quiz.QuizStyle quizStyle) {
        (ActiveForm as formMaster)?.DisplayForm(new formQuiz(quizStyle));
    }
}
