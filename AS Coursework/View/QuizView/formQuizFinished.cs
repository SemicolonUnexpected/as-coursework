using AS_Coursework._Helpers;
using AS_Coursework.Model.Quiz;
using AS_Coursework.Model.Users;

namespace AS_Coursework.View.QuizView;
public partial class formQuizFinished : Form {
    public formQuizFinished(Quiz quiz) {
        InitializeComponent();

        // Show the user details
        lblUsername.Text = User.ActiveUser!.AuthenticationDetails.Username;
        pbUserProfile.Image = User.ActiveUser!.FunctionalDetails.ProfileImage.Image;

        // Display the quiz statistics
        lblQuizStatistics.Text = $"Quiz complete, well done!\n\n" +
            $"Correct: {quiz.AmountCorrect}/{quiz.Length}\n" +
            $"Experience earned: {quiz.TotalExperienceAllocation} xp";

        // Give the user the experience they earned
        User.ActiveUser.FunctionalDetails.Experience += quiz.TotalExperienceAllocation;
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        pbUserProfile.CenterX();
        lblUsername.CenterX();
        lblQuizStatistics.CenterX();
        btnExit.CenterX();
    }

    // Return to the main menu when the exit button is clicked
    private void btnExit_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu());
    }
}
