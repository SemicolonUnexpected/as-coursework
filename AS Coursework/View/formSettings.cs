﻿using AS_Coursework._Helpers;
using AS_Coursework.Custom_Controls;
using AS_Coursework.Model.Data;
using AS_Coursework.Model.Users;
using System.Net.Mail;
using AS_Coursework.Model.Security;

namespace AS_Coursework.View;
public partial class formSettings : Form {
    User _user;
    public formSettings(User user) {
        InitializeComponent();

        _user = user;

        // Set the minimum date of birth to 100 years ago
        dtpDateOfBirth.MinDate = DateTime.Today.Subtract(new TimeSpan(100 * 365, 0, 0, 0, 0));

        // Setup the gender options which can be found in the StringToGender dictionary
        cbGender.Items.AddRange(new string[] { "Male", "Female", "Other", "Prefer not to say" });

        PopulateDataDisplay();
    }

    // This method is called every time the user changes their data to ensure all displayed data is correct
    private void PopulateDataDisplay() {
        lblUsername.Text = _user.AuthenticationDetails.Username;
        lblUsernameDetail.Text = $"Username : {_user.AuthenticationDetails.Username}";
        lblEmailDetail.Text = $"Email : {_user.MiscDetails.Email}";
        lblForenameDetail.Text = $"Forname : {_user.MiscDetails.Forename}";
        lblSurnameDetail.Text = $"Surname : {_user.MiscDetails.Surname}";

        cbGender.SelectedIndex = (int)_user.MiscDetails.Gender;
        dtpDateOfBirth.Value = _user.MiscDetails.DateOfBirth;
    }

    // Bubble the mouse scrolling up the the formMainMenu to handle scrolling
    protected override void OnMouseWheel(MouseEventArgs e) {
        base.OnMouseWheel(e);

        ((ActiveForm as formMaster)?.ChildView as formMainMenu)?.ScrollUserView(e.Delta);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        // Center every error message horizontally in the pnlAccount
        lblChangeUsernameError.CenterX();
        lblChangeEmailError.CenterX();
        lblChangeForenameError.CenterX();
        lblChangeSurnameError.CenterX();

        // Center every error message horizontally in the pnlDetails
        lblGender.CenterX();
        lblDateOfBirthError.CenterX();
    }

    #region Data validation and user detail updates

    private void btnChangeUsername_Click(object sender, EventArgs e) {
        string newUsername = tbNewUsername.Text;

        if (string.IsNullOrWhiteSpace(newUsername)) {
            lblChangeUsernameError.Text = "Please fill in a username";
            return;
        }
        if (DataManager.UserExists(newUsername)) {
            lblChangeUsernameError.Text = "This username is already taken";
            return;
        }

        _user.AuthenticationDetails.Username = newUsername;
        PopulateDataDisplay();
    }

    private void btnChangeEmail_Click(object sender, EventArgs e) {
        bool emailValid = MailAddress.TryCreate(tbNewEmail.Text, out MailAddress? newEmail);

        if (!emailValid || newEmail is null) {
            lblChangeEmailError.Text = "Email invalid";
            return;
        }

        _user.MiscDetails.Email = newEmail;
        PopulateDataDisplay();
    }

    private void btnChangeForename_Click(object sender, EventArgs e) {
        string newForename = tbNewForename.Text;

        if (string.IsNullOrWhiteSpace(newForename)) {
            lblChangeForenameError.Text = "Please fill in a forename";
            return;
        }

        _user.MiscDetails.Forename = newForename;
        PopulateDataDisplay();
    }

    private void btnChangeSurname_Click(object sender, EventArgs e) {
        string newSurname = tbNewForename.Text;

        if (string.IsNullOrWhiteSpace(newSurname)) {
            lblChangeSurnameError.Text = "Please fill in a forename";
            return;
        }

        _user.MiscDetails.Surname = newSurname;
        PopulateDataDisplay();
    }

    private void cbGender_SelectedIndexChanged(object sender, EventArgs e) {
        _user.MiscDetails.Gender = (Gender)cbGender.SelectedIndex;
    }

    private void dtpDateOfBirth_CloseUp(object sender, EventArgs e) {
        // Set the text to error text if the date of birth would make the user too young
        if (DataValidator.IsUserOldEnough(dtpDateOfBirth.Value)) {
            lblDateOfBirthError.Text = $"You must be {DataValidator.MINIMUM_USER_AGE} to create an account";
            lblDateOfBirthError.CenterX();
            return;
        }

        _user.MiscDetails.DateOfBirth = dtpDateOfBirth.Value;
    }

    private void btnResetExperience_Click(object sender, EventArgs e) {
        if (CustomMessageBox.Show("Reset score", "Are you sure you want to reset your score?") == DialogResult.OK) _user.FunctionalDetails.Experience = 0;
    }

    private void btnDeleteAccount_Click(object sender, EventArgs e) {
        if (CustomMessageBox.Show("Delete account", "Are you sure you want to delete your account. You cannot revert this action and will be instantly logged out") == DialogResult.OK) {
            DataManager.DeleteUser(_user);
        }
    }
    private bool CheckPasswordOk() {
        string passwordError = "";

        // Set the text to error text if the password field is empty or the password requirements are not met
        if (string.IsNullOrWhiteSpace(tbNewPassword.Text)) passwordError = "Please create a password";
        else if (DataValidator.GetPasswordRequirements(tbNewPassword.Text).Count < Enum.GetNames(typeof(DataValidator.PasswordRequirements)).Length) passwordError = "Please pick a stronger password";

        lblPasswordError.Text = passwordError;
        lblPasswordError.CenterX();

        return passwordError == "";
    }

    private bool CheckConfirmPasswordOk() {
        string confirmPasswordError = "";

        // Set the text to error text if the user has not confirmed their password or password field and confirm password field do not match 
        if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text)) confirmPasswordError = "Please confirm your password";
        else if (tbNewPassword.Text != tbConfirmPassword.Text) confirmPasswordError = "Passwords did not match";

        lblConfirmPasswordError.Text = confirmPasswordError;
        lblConfirmPasswordError.CenterX();

        return confirmPasswordError == "";
    }

    private void btnChangePassword_Click(object sender, EventArgs e) {
        if (CheckPasswordOk() & CheckConfirmPasswordOk()) {
            byte[] newHashedPassword = HashManager.GetHash(tbNewPassword.Text, out byte[] newSalt);

            _user.AuthenticationDetails.HashedPassword = newHashedPassword;
            _user.AuthenticationDetails.Salt = newSalt;

            CustomMessageBox.Show("Passord changed", "Your password has been updated. Do not forget it.");
        }
    }

    #endregion
}
