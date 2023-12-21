using AS_Coursework.Custom_Controls;
using AS_Coursework.Model.Data;
using AS_Coursework.Model.Users;

namespace AS_Coursework.View;
public partial class formRanks : Form {
    private User _user;
    private List<Ranking> _rankViews;

    public formRanks(User user) {
        // Required by the designer and sets up the form and its controls
        InitializeComponent();

        SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

        _user = user;

        _rankViews = new List<Ranking>() {
            ranking1,
            ranking2,
            ranking3,
            ranking4,
            ranking5,
            ranking6,
            ranking7,
            ranking8,
            ranking9,
            ranking10,
        };

        lblUsername.Text = _user.AuthenticationDetails.Username;
        customPictureFrame1.Image = _user.FunctionalDetails.ProfileImage.Image;
        customPictureFrame1.ImagePortion = _user.FunctionalDetails.ProfileImage.ImagePortion;

        DisplayRanks();

        OnResize(EventArgs.Empty);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        

        if (_rankViews is not null) foreach (Ranking rankView in _rankViews) rankView.Width = pnlScoreboard.Width - rankView.Margin.Horizontal;
    }

    private void DisplayRanks() {
        for (int i = 0; i < _rankViews.Count; i++) {
            Ranking rankView = _rankViews[i];
            (string username, string experience) = TryGetRank(i);

            rankView.Name = username;
            rankView.ExperienceText = experience;
        }
    }

    private (string username, string experience) TryGetRank(int index) {
        throw new NotImplementedException();
    }
}
