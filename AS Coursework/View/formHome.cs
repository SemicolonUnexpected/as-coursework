using AS_Coursework._Helpers;
using AS_Coursework.Model.Users;

namespace AS_Coursework.View;
public partial class formHome : Form {
    private readonly User _user;
    public formHome(User user) {
        InitializeComponent();
        _user = user;

        SetupDisplayText();

        OnResize(EventArgs.Empty);
    }

    private void SetupDisplayText() {
        pbUserProfile.Image = _user.FunctionalDetails.ProfileImage.Image;
        pbUserProfile.ImagePortion = _user.FunctionalDetails.ProfileImage.ImagePortion;

        lblUsername.Text = _user.AuthenticationDetails.Username;

        lblExperienceRemainder.Text = $"{_user.FunctionalDetails.LeftOverExperience} xp";
        pbLevel.Progress = (float)_user.FunctionalDetails.LeftOverExperience / 100;

        lblAnswers.Text = $"Questions answered - {_user.FunctionalDetails.QuestionsAnswered}";
        lblCorrect.Text = $"Questions correct - {_user.FunctionalDetails.QuestionsCorrect}";
        lblPercentageAccuracy.Text = $"Percentage accuracy - {_user.FunctionalDetails.PercentageAccuracy} %";

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
