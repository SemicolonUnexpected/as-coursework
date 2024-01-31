﻿using AS_Coursework.Custom_Controls;
using AS_Coursework.Model.Users;
using AS_Coursework.View.QuizView;

namespace AS_Coursework.View;
public partial class formMainMenu : Form {

    private const int MENU_WIDTH = 140;
    private const int MINIMISED_MENU_WIDTH = 50;

    private bool _menuMinimised = true;
    private Form? _userForm;
    private int? _userFormBaseHeight;

    private Form? UserForm {
        get => _userForm;
        set {
            _userForm = value;
            _userFormBaseHeight = value?.Height;
            OnResize(EventArgs.Empty);
        }
    }

    private int? UserFormBaseHeight {
        get => _userFormBaseHeight;
    }

    public formMainMenu(bool openAdmin = false) {
        InitializeComponent();

        SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

        // Only show the admin page if the current user is an admin
        if (!User.ActiveUser!.AuthenticationDetails.IsAdmin) miAdmin.Hide();

        // Display the initial use form
        DisplayUserForm(openAdmin ? new formHome() : new formAdminMenu());

        // Call the OnResize event to ensure that the form is formatted correctly
        OnResize(EventArgs.Empty);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        // Avoid null references to the userform before it has been initialised
        if (UserForm is null) return;

        if (UserFormBaseHeight <= Height) {
            // Hide the scroll bar if the form is big enough and scale the form appropriately
            sb.Hide();
            UserForm.Height = pnlUserViewHolder.Height;
        }
        else {
            // Show the scroll bar when the form is too small to see the whole user view and scale the form appropriately
            sb.Show();

            // Scale the thumb of the scroll bar
            sb.Maximum = UserForm.Height - Height;
            int sbRange = sb.Maximum - sb.Minimum;
            int thumbHeight = Height - sbRange;

            // Ensure the form is not minimised before making this check to avoid an exception
            if ((ActiveForm as formMaster)?.WindowState != FormWindowState.Minimized) sb.ThumbSize = new Size(sb.ThumbSize.Width, Math.Clamp(thumbHeight, 30, Height - sb.ChannelPadding.Vertical));

            // Set the scroll bar value to the correct position
            sb.Value = 0;

            // Scale the UserForm
            UserForm.Height = (int)UserFormBaseHeight!;
        }

        UserForm.Width = Width - MINIMISED_MENU_WIDTH;

        if (_menuMinimised) MinimiseMenu();
        else MaximiseMenu();
    }

    protected override void OnResizeEnd(EventArgs e) {
        base.OnResizeEnd(e);

        MessageBox.Show("Test");
    }

    #region Menu formatting

    private void Menu_Click(object sender, EventArgs e) {
        _menuMinimised = !_menuMinimised;
        if (_menuMinimised) MinimiseMenu();
        else MaximiseMenu();
    }

    private void MinimiseMenu() {
        pnlMenuStrip.Width = MINIMISED_MENU_WIDTH;

        if (UserForm is null) return;
        UserForm.Location = new Point(0, 0);
    }

    private void MaximiseMenu() {
        pnlMenuStrip.Width = MENU_WIDTH;

        if (UserForm is null) return;
        UserForm.Location = new Point(MINIMISED_MENU_WIDTH - MENU_WIDTH, 0);
    }

    #endregion

    #region Menu navigation

    // Display the user sub form in the holder panel
    private void DisplayUserForm(Form form) {
        UserForm = form;

        // Setup form display settings
        UserForm.TopLevel = false;
        UserForm.FormBorderStyle = FormBorderStyle.None;
        UserForm.Enabled = true;
        UserForm.Visible = true;
        UserForm.Width = Width - 75;
        UserForm.Location = _menuMinimised ? new Point(0, 0) : new Point(-125, 0);

        // Display in panel
        pnlUserViewHolder.Controls.Clear();
        pnlUserViewHolder.Controls.Add(UserForm);
        pnlUserViewHolder.Show();

        // Redraw form
        Refresh();
    }

    // Menu navigation 
    private void miHome_MenuClick(object sender, EventArgs e) {
        MinimiseMenu();
        if (UserForm is not formHome) DisplayUserForm(new formHome());
    }

    private void miQuiz_MenuClick(object sender, EventArgs e) {
        MinimiseMenu();
        if (UserForm is not formQuizMenu) DisplayUserForm(new formQuizMenu());
    }

    private void miRanks_Click(object sender, EventArgs e) {
        MinimiseMenu();
        if (UserForm is not formRanks) DisplayUserForm(new formRanks());
    }

    private void miSettings_MenuClick(object sender, EventArgs e) {
        MinimiseMenu();
        if (UserForm is not formSettings) DisplayUserForm(new formSettings());
    }

    private void miSignOut_MenuClick(object sender, EventArgs e) {
        MinimiseMenu();
        DialogResult result = CustomMessageBox.Show("Sign out", "Are you sure you want to sign out?", MessageBoxButtons.OKCancel);
        if (result == DialogResult.OK) {
            (ActiveForm as formMaster)?.DisplayForm(new formLogin());
        }
    }

    private void miAdmin_MenuClick(object sender, EventArgs e) {
        MinimiseMenu();
        if (UserForm is not formAdminMenu) DisplayUserForm(new formAdminMenu());
    }

    #endregion

    public void ScrollUserView(int value) {
        sb.Value -= value;
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        if (UserForm is null) return;
        UserForm.Location = new Point(_menuMinimised ? 0 : -125, -sb.Value);
        Refresh();
    }

    private void formMainMenu_ResizeEnd(object sender, EventArgs e) {
        MessageBox.Show("Test");
    }
}
