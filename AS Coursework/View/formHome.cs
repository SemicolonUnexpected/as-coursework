using AS_Coursework._Helpers;
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

        lblAnswers.Text = $"Questions answered - {user.FunctionalDetails.QuestionsAnswered}";
        lblCorrect.Text = $"Questions correct - {user.FunctionalDetails.QuestionsCorrect}";
        lblPercentageAccuracy.Text = $"Percentage accuracy - {user.FunctionalDetails.PercentageAccuracy} %";

        lblRank.Text = $"#{1}";
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        lblRank.Center();
        lblUsername.CenterX();
    }

    protected override void OnMouseWheel(MouseEventArgs e) {
        base.OnMouseWheel(e);

        ((ActiveForm as formMaster)?.ChildView as formMainMenu)?.ScrollUserView(e.Delta);
    }
}
