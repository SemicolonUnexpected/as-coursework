using AS_Coursework._Helpers;
using AS_Coursework.Custom_Controls;
using AS_Coursework.Model.Data;
using AS_Coursework.Model.Users;

namespace AS_Coursework.View;
public partial class formRanks : Form {
    private List<Ranking> _rankViews;

    public formRanks() {
        // Required by the designer and sets up the form and its controls
        InitializeComponent();

        // Set the style to allow for fast painting to reduce flicker
        SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

        User user = User.ActiveUser!;

        // List of ranking to iterate through later
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

        // Read in the users details for display
        lblUsername.Text = user.AuthenticationDetails.Username;
        pbUserProfile.Image = user.FunctionalDetails.ProfileImage.Image;
        lblExperience.Text = user.FunctionalDetails.Experience.ToString() + " xp";
        lblRank.Text = $"#{UserDataManager.GetUserRank(user)}";

        // Hide some details if the user is an admin
        if (user.AuthenticationDetails.IsAdmin) {
            lblRank.Hide();
            lblRankTitle.Hide();
        }

        DisplayRanks();

        OnResize(EventArgs.Empty);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        // Center components
        lblExperience.CenterX();
        lblRank.CenterX();
        lblExperienceTitle.CenterX();
        lblRankTitle.CenterX();
        lblUsername.CenterX();
        pbUserProfile.CenterX();

        // Resize ranks if they are not null
        if (_rankViews is not null) foreach (Ranking rankView in _rankViews) rankView.Width = pnlScoreboard.Width - rankView.Margin.Horizontal;
    }

    private void DisplayRanks() {
        List<User> topTenPlayers = UserDataManager.GetTopPlayers(10).ToList();

        for (int i = 0; i < topTenPlayers.Count(); i++) {
            Ranking rankView = _rankViews[i];
            User user = topTenPlayers[i];

            rankView.UsernameText = $"#{UserDataManager.GetUserRank(user)} {user.AuthenticationDetails.Username}";
            rankView.ExperienceText = user.FunctionalDetails.Experience.ToString() + " xp";
        }
    }
}