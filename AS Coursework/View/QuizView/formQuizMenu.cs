using AS_Coursework.Model.Users;
using AS_Coursework.Model.Quiz;

namespace AS_Coursework.View.QuizView;
public partial class formQuizMenu : Form {
    private readonly User _user;
    public formQuizMenu(User user) {
        InitializeComponent();

        _user = user;

        lblUsername.Text = _user.AuthenticationDetails.Username;
        pbUserProfile.Image = _user.FunctionalDetails.ProfileImage.Image;
    }

    private void btnAllQuestions_Click(object sender, EventArgs e) {

    }

    private void StartQuiz(Quiz.QuizStyle quizStyle) {
        (ActiveForm as formMaster)?.DisplayForm(new formQuiz(_user));
    }
}
