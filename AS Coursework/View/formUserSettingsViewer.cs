using AS_Coursework.Model.Users;
using System.Drawing.Text;

namespace AS_Coursework.View; 
public partial class formUserSettingsViewer : Form {
    private Form? _userSettingsForm;
    private int? _userSettingsFormBaseHeight;

    private Form? UserSettingsForm {
        get => _userSettingsForm;
        set {
            _userSettingsForm = value;
            

            if (_userSettingsForm is null) return;

            // Set the base height to allow scrolling
            _userSettingsFormBaseHeight = value?.Height;

            // Subscribe to the form's mouse wheel event
            _userSettingsForm.MouseWheel += ScrollUserView;
        }
    }

    private int? UserSettingsFormBaseHeight => _userSettingsFormBaseHeight;

    public formUserSettingsViewer(User user) {
        InitializeComponent();

        DisplayUserForm(new formSettings(user));
    }

    // Display the user sub form in the holder panel
    private void DisplayUserForm(Form form) {
        UserSettingsForm = form;

        // Setup form display settings
        UserSettingsForm.TopLevel = false;
        UserSettingsForm.FormBorderStyle = FormBorderStyle.None;
        UserSettingsForm.Enabled = true;
        UserSettingsForm.Visible = true;
        UserSettingsForm.Width = pnlSettingsDisplay.Width;
        UserSettingsForm.Location = new Point(0, 0);

        // Display in panel
        pnlSettingsDisplay.Controls.Clear();
        pnlSettingsDisplay.Controls.Add(UserSettingsForm);
        pnlSettingsDisplay.Show();

        // Redraw form
        Refresh();
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        // Avoid null references to the userform before it has been initialised
        if (UserSettingsForm is null) return;

        if (UserSettingsFormBaseHeight <= pnlSettingsDisplay.Height) {
            // Hide the scroll bar if the form is big enough and scale the form appropriately
            sb.Hide();
            UserSettingsForm.Height = pnlSettingsDisplay.Height;
        }
        else {
            // Show the scroll bar when the form is too small to see the whole user view and scale the form appropriately
            sb.Show();

            // Scale the thumb of the scroll bar
            sb.Maximum = UserSettingsForm.Height - Height;
            int sbRange = sb.Maximum - sb.Minimum;
            int thumbHeight = Height - sbRange;

            // Ensure the form is not minimised before making this check to avoid an exception
            if ((ActiveForm as formMaster)?.WindowState != FormWindowState.Minimized) sb.ThumbSize = new Size(sb.ThumbSize.Width, Math.Clamp(thumbHeight, 30, Height - sb.ChannelPadding.Vertical));

            // Set the scroll bar value to the correct position
            sb.Value = 0;

            // Scale the UserForm
            UserSettingsForm.Height = (int)UserSettingsFormBaseHeight!;
        }
    }

    private void btnExit_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAdminMenu()));
    }

    public void ScrollUserView(object? sender, MouseEventArgs e) {
        // Only scroll when the scroll bar is active
        if (sb.Visible) sb.Value -= e.Delta * sb.MouseWheelSensitivity;
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        if (UserSettingsForm is null) return;
        UserSettingsForm.Location = new Point(0, -sb.Value);
        Refresh();
    }
}
