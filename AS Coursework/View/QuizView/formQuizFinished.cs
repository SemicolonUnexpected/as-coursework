using AS_Coursework._Helpers;
using AS_Coursework.Model.Quiz;
using AS_Coursework.Model.Users;

namespace AS_Coursework.View.QuizView; 
public partial class formQuizFinished : Form {
    public formQuizFinished(Quiz quiz) {
        InitializeComponent();

        lblUsername.Text = User.ActiveUser!.AuthenticationDetails.Username;
        pbUserProfile.Image = User.ActiveUser!.FunctionalDetails.ProfileImage.Image;

        lblQuizStatistics.Text = $"Quiz complete, well done!\n\n" +
            $"Correct: {quiz.AmountCorrect}/{quiz.Length}\n" +
            $"Experience earned: {quiz.TotalExperienceAllocation} xp";
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        pbUserProfile.CenterX();
        lblUsername.CenterX();
        lblQuizStatistics.CenterX();
        btnExit.CenterX();
    }
}
