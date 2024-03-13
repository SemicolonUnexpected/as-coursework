using AS_Coursework._Helpers;
using AS_Coursework.Model.Data;
using AS_Coursework.Model.Users;

namespace AS_Coursework.View;
public partial class formHome : Form {
    public formHome() {
        InitializeComponent();

        SetupDisplayText();

        OnResize(EventArgs.Empty);
    }

    private void SetupDisplayText() {
        User user = User.ActiveUser!; // For conciseness

        pbUserProfile.Image = user.FunctionalDetails.ProfileImage.Image;

        lblUsername.Text = user.AuthenticationDetails.Username;

        lblExperienceRemainder.Text = $"{user.FunctionalDetails.LeftOverExperience} xp";
        pbLevel.Progress = (float)user.FunctionalDetails.LeftOverExperience / 100;
        lblLevel.Text = user.FunctionalDetails.Level.ToString();

        lblAnswers.Text = $"Questions answered\n{user.FunctionalDetails.QuestionsAnswered}\nQuestions correct\n{user.FunctionalDetails.QuestionsCorrect}\nPercentage accuracy\n{user.FunctionalDetails.PercentageAccuracy} %";

        lblRank.Text = $"#{UserDataManager.GetUserRank(user)}";
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        lblRank.Center();
        lblUsername.CenterX();
    }
}
