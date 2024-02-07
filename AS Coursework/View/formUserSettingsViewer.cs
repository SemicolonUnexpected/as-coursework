namespace AS_Coursework.View; 
public partial class formUserSettingsViewer : Form {
    private Form userSettingsForm;
    public formUserSettingsViewer(UserControl user) {
        InitializeComponent();
    }

    // Display the user sub form in the holder panel
    private void DisplayUserForm(Form form) {
        userSettingsForm = form;

        // Setup form display settings
        userSettingsForm.TopLevel = false;
        userSettingsForm.FormBorderStyle = FormBorderStyle.None;
        userSettingsForm.Enabled = true;
        userSettingsForm.Visible = true;
        userSettingsForm.Width = Width - 75;
        userSettingsForm.Location = new Point(0, 0);

        // Display in panel
        pnlSettingsDisplay.Controls.Clear();
        pnlSettingsDisplay.Controls.Add(userSettingsForm);
        pnlSettingsDisplay.Show();

        // Redraw form
        Refresh();
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        //Avoid null references to the userform before it has been initialised
        //if (userSettingsForm is null) return;

        //if (UserFormBaseHeight <= Height) {
        //    Hide the scroll bar if the form is big enough and scale the form appropriately
        //    sb.Hide();
        //    userSettingsForm.Height = pnlUserViewHolder.Height;
        //}
        //else {
        //    Show the scroll bar when the form is too small to see the whole user view and scale the form appropriately
        //    sb.Show();

        //    Scale the thumb of the scroll bar
        //    sb.Maximum = userSettingsForm.Height - Height;
        //    int sbRange = sb.Maximum - sb.Minimum;
        //    int thumbHeight = Height - sbRange;

        //    Ensure the form is not minimised before making this check to avoid an exception
        //    if ((ActiveForm as formMaster)?.WindowState != FormWindowState.Minimized) sb.ThumbSize = new Size(sb.ThumbSize.Width, Math.Clamp(thumbHeight, 30, Height - sb.ChannelPadding.Vertical));

        //    Set the scroll bar value to the correct position
        //    sb.Value = 0;

        //    Scale the UserForm
        //    userSettingsForm.Height = (int)UserFormBaseHeight!;
        //}

        //userSettingsForm.Width = Width - MINIMISED_MENU_WIDTH;

        //if (_menuMinimised) MinimiseMenu();
        //else MaximiseMenu();
    }

    private void btnExit_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(true));
    }

    // Scrolling the settings form
    public void ScrollUserView(int value) {
        sb.Value -= value;
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        if (userSettingsForm is null) return;
        //userSettingsForm.Location = new Point(_menuMinimised ? 0 : -125, -sb.Value);
        Refresh();
    }

    private void formMainMenu_ResizeEnd(object sender, EventArgs e) {
        MessageBox.Show("Test");
    }
}
