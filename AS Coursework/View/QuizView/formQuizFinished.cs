using AS_Coursework._Helpers;
using AS_Coursework.Model.Quiz;
using AS_Coursework.Model.Users;

namespace AS_Coursework.View.QuizView;
public partial class formQuizFinished : Form {
    public formQuizFinished(Quiz quiz) {
        InitializeComponent();

        User user = User.ActiveUser!; // For conciseness

        // Show the user details
        lblUsername.Text = user!.AuthenticationDetails.Username;
        pbUserProfile.Image = user!.FunctionalDetails.ProfileImage.Image;

        // Display the quiz statistics
        lblQuizStatistics.Text = $"Quiz complete, well done!\n\n" +
            $"Correct: {quiz.AmountCorrect}/{quiz.AmountAnswered}\n" +
            $"Experience earned: {quiz.TotalExperienceAllocation} xp";

        // Update the user's statistics
        user.FunctionalDetails.Experience += quiz.TotalExperienceAllocation;
        user.FunctionalDetails.QuestionsAnswered += quiz.AmountAnswered;
        user.FunctionalDetails.QuestionsCorrect += quiz.AmountCorrect;

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
        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formQuizMenu()));
    }
}
