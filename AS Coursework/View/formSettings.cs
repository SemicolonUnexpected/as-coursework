﻿using AS_Coursework._Helpers;
using AS_Coursework.Custom_Controls;
using AS_Coursework.Model.Data;
using AS_Coursework.Model.Users;
using System.Net.Mail;
using AS_Coursework.Model.Security;

namespace AS_Coursework.View;
public partial class formSettings : Form {
    private readonly User _user;
    private readonly bool _openedAsAdmin = false;

    public formSettings() {
        InitializeComponent();

        _user = User.ActiveUser!; // For conciseness

        Initialise();
    }

    // Create the settings page for a specific user
    // This is necessary for the settings page
    public formSettings(User user) {
        InitializeComponent();

        // Tell the form that it has been opened by an admin
        _openedAsAdmin = true;

        _user = user; // For conciseness

        Initialise();
    }

    private void Initialise() {
        // Set the date time picker's value to the current time
        dtpDateOfBirth.Value = DateTime.Now;

        // Setup the gender options which can be found in the StringToGender dictionary
        cbGender.Items.AddRange(new string[] { "Male", "Female", "Other", "Prefer not to say" });

        // Remove all the error placeholder text
        lblChangeUsernameError.Text = "";
        lblChangeEmailError.Text = "";
        lblChangeForenameError.Text = "";
        lblChangeSurnameError.Text = "";
        lblChangeDateOfBirthError.Text = "";
        lblPasswordError.Text = "";
        lblConfirmPasswordError.Text = "";

        PopulateDataDisplay();

        cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;

        pbUserProfile.Image = _user.FunctionalDetails.ProfileImage.Image;
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

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        // Center every error message horizontally in the pnlAccount
        lblChangeUsernameError.CenterX();
        lblChangeEmailError.CenterX();
        lblChangeForenameError.CenterX();
        lblChangeSurnameError.CenterX();

        // Center every error message horizontally in the pnlDetails
        lblGender.CenterX();
        lblChangeDateOfBirthError.CenterX();
    }

    #region Data validation and user detail updates

    private void btnChangeUsername_Click(object? sender, EventArgs e) {
        string newUsername = tbNewUsername.Text;

        if (_user.AuthenticationDetails.Username == "root") {
            CustomMessageBox.Show("", "The root user cannot change their username");
            return;
        }
        if (string.IsNullOrWhiteSpace(newUsername)) {
            lblChangeUsernameError.Text = "Please fill in a username";
            lblChangeUsernameError.CenterX();
            return;
        }
        else if (!DataValidator.UsernamePasswordRegex().Match(tbNewUsername.Text).Success) {
            lblChangeUsernameError.Text = "Invalid username";
            lblChangeUsernameError.CenterX();
            return;
        }
        if (UserDataManager.UserExists(newUsername)) {
            lblChangeUsernameError.Text = "This username is already taken";
            lblChangeUsernameError.CenterX();
            return;
        }

        _user.AuthenticationDetails.Username = newUsername;
        lblChangeUsernameError.Text = "";
        tbNewUsername.Text = "";
        PopulateDataDisplay();
    }

    private void btnChangeEmail_Click(object? sender, EventArgs e) {
        bool emailValid = MailAddress.TryCreate(tbNewEmail.Text, out MailAddress? newEmail);

        if (!emailValid || newEmail is null) {
            lblChangeEmailError.Text = "Email invalid";
            lblChangeEmailError.CenterX();
            return;
        }

        _user.MiscDetails.Email = newEmail;
        tbNewEmail.Text = "";
        lblChangeEmailError.Text = "";
        PopulateDataDisplay();
    }

    private void btnChangeForename_Click(object? sender, EventArgs e) {
        string newForename = tbNewForename.Text;

        if (string.IsNullOrWhiteSpace(newForename)) {
            lblChangeForenameError.Text = "Please fill in a forename";
            lblChangeForenameError.CenterX();
            return;
        }

        _user.MiscDetails.Forename = newForename;
        tbNewForename.Text = "";
        lblChangeForenameError.Text = "";
        PopulateDataDisplay();
    }

    private void btnChangeSurname_Click(object? sender, EventArgs e) {
        string newSurname = tbNewSurname.Text;

        if (string.IsNullOrWhiteSpace(newSurname)) {
            lblChangeSurnameError.Text = "Please fill in a surname";
            lblChangeSurnameError.CenterX();
            return;
        }

        _user.MiscDetails.Surname = newSurname;
        tbNewSurname.Text = "";
        lblChangeSurnameError.Text = "";
        PopulateDataDisplay();
    }

    private void cbGender_SelectedIndexChanged(object? sender, EventArgs e) {
        _user.MiscDetails.Gender = (Gender)cbGender.SelectedIndex;
        CustomMessageBox.Show("Gender", "Gender changed");
    }

    private void dtpDateOfBirth_CloseUp(object? sender, EventArgs e) {
        // Set the text to error text if the date of birth would make the user too young
        if (!DataValidator.IsUserOldEnough(dtpDateOfBirth.Value)) {
            lblChangeDateOfBirthError.Text = $"You must be {DataValidator.MINIMUM_USER_AGE} to have an account";
            lblChangeDateOfBirthError.CenterX();
            dtpDateOfBirth.Value = _user.MiscDetails.DateOfBirth;
            return;
        }

        _user.MiscDetails.DateOfBirth = dtpDateOfBirth.Value;
        lblChangeDateOfBirthError.Text = "";
        CustomMessageBox.Show("Date of birth", "Date of birth changed");
    }

    private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e) {
        // Set the text to error text if the date of birth would make the user too young
        if (!DataValidator.IsUserOldEnough(dtpDateOfBirth.Value)) {
            lblChangeDateOfBirthError.Text = $"You must be {DataValidator.MINIMUM_USER_AGE} to have an account";
            lblChangeDateOfBirthError.CenterX();
            return;
        }

        lblChangeDateOfBirthError.Text = "";
        _user.MiscDetails.DateOfBirth = dtpDateOfBirth.Value;
    }

    private void btnReset_Click(object? sender, EventArgs e) {
        if (CustomMessageBox.Show("Reset score", "Are you sure you want to reset your statistics?") == DialogResult.OK) {
            _user.FunctionalDetails.Experience = 0;
            _user.FunctionalDetails.QuestionsAnswered = 0;
            _user.FunctionalDetails.QuestionsCorrect = 0;
        }
    }

    private void btnDeleteAccount_Click(object? sender, EventArgs e) {
        if (CustomMessageBox.Show("Delete account", "Are you sure you want to delete your account. You cannot revert this action and will be instantly logged out") == DialogResult.OK) {
            UserDataManager.DeleteUser(_user);
            (ActiveForm as formMaster)?.DisplayForm(_openedAsAdmin ? new formMainMenu(new formAdminMenu()) : new formLogin());
        }
    }

    private bool CheckPasswordOk() {
        string passwordError = "";

        // Set the text to error text if the password field is empty or the password requirements are not met
        if (string.IsNullOrWhiteSpace(tbNewPassword.Text)) passwordError = "Please create a password";
        else if (!DataValidator.UsernamePasswordRegex().Match(tbNewPassword.Text).Success) passwordError = "Invalid username";
        else if (DataValidator.GetPasswordRequirements(tbNewPassword.Text).Count < Enum.GetNames(typeof(DataValidator.PasswordRequirements)).Length) passwordError = "Please pick a stronger password";

        lblPasswordError.Text = passwordError;

        return passwordError == "";
    }

    private bool CheckConfirmPasswordOk() {
        string confirmPasswordError = "";

        // Set the text to error text if the user has not confirmed their password or password field and confirm password field do not match 
        if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text)) confirmPasswordError = "Please confirm your password";
        else if (tbNewPassword.Text != tbConfirmPassword.Text) confirmPasswordError = "Passwords did not match";

        lblConfirmPasswordError.Text = confirmPasswordError;

        return confirmPasswordError == "";
    }

    private void tbNewPassword_TextChanged(object sender, EventArgs e) {
        string text = tbNewPassword.Text;
        List<DataValidator.PasswordRequirements> requirements = DataValidator.GetPasswordRequirements(text);

        pbPasswordLength.Image = requirements.Contains(DataValidator.PasswordRequirements.Length) ? Resources.Icons.Icons.Green_Tick_Circle : Resources.Icons.Icons.Red_Cross_Circle;
        pbLettersNumbers.Image = requirements.Contains(DataValidator.PasswordRequirements.NumsAndChars) ? Resources.Icons.Icons.Green_Tick_Circle : Resources.Icons.Icons.Red_Cross_Circle;
        pbSpecialCharacters.Image = requirements.Contains(DataValidator.PasswordRequirements.SpecialChars) ? Resources.Icons.Icons.Green_Tick_Circle : Resources.Icons.Icons.Red_Cross_Circle;
    }

    private void btnChangePassword_Click(object? sender, EventArgs e) {
        if (CheckPasswordOk() & CheckConfirmPasswordOk()) {
            byte[] newHashedPassword = HashManager.GetHash(tbNewPassword.Text, out byte[] newSalt);

            _user.AuthenticationDetails.HashedPassword = newHashedPassword;
            _user.AuthenticationDetails.Salt = newSalt;

            CustomMessageBox.Show("Password changed", "Your password has been updated. Do not forget it.");
        }

        tbNewPassword.Text = "";
        tbConfirmPassword.Text = "";
    }

    #endregion

    private void btnProfilePicturePrevious_Click(object sender, EventArgs e) {
        _user.FunctionalDetails.ProfileImageIndex = _user.FunctionalDetails.ProfileImageIndex == 0 ? UserProfileImage.Images.Count - 1 : _user.FunctionalDetails.ProfileImageIndex - 1;
        pbUserProfile.Image = _user.FunctionalDetails.ProfileImage.Image;
    }

    private void btnProfilePictureNext_Click(object sender, EventArgs e) {
        _user.FunctionalDetails.ProfileImageIndex = _user.FunctionalDetails.ProfileImageIndex == UserProfileImage.Images.Count - 1 ? 0 : _user.FunctionalDetails.ProfileImageIndex + 1;
        pbUserProfile.Image = _user.FunctionalDetails.ProfileImage.Image;
    }


    // Allow the user to see their password by clicking the eye icon in the picturebox
    private void pbPasswordView_Click(object sender, EventArgs e) {
        tbNewPassword.UsePasswordChar = !tbNewPassword.UsePasswordChar;
        pbPasswordView.Image = tbNewPassword.UsePasswordChar ? Resources.Icons.Icons.Eye : Resources.Icons.Icons.Eye_crossed;
    }
}
