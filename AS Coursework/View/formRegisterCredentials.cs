using AS_Coursework._Helpers;
using AS_Coursework.Model.Data;
using AS_Coursework.Model.Security;
using AS_Coursework.Model.Users;

namespace AS_Coursework.View {
    public partial class RegisterCredentialsView : Form {

        public AuthenticationDetails AuthenticationDetails {
            get => new AuthenticationDetails(tbUsername.Text, HashManager.GetHash(tbPassword.Text, out byte[] salt), salt, false);
        }

        public RegisterCredentialsView() {
            InitializeComponent();

            // Set the error text to empty
            lblUsernameError.Text = "";
            lblPasswordError.Text = "";
            lblConfirmPasswordError.Text = "";

            // Call OnResize to correct formatting
            OnResize(EventArgs.Empty);
        }
        private bool CheckUsernameOk() {
            string usernameError = "";

            // Set the text to error text if the username field is empty or the username is taken
            if (string.IsNullOrWhiteSpace(tbUsername.Text)) usernameError = "Please fill in a username";
            else if (UserDataManager.UserExists(tbUsername.Text)) usernameError = "Username already taken";

            lblUsernameError.Text = usernameError;
            lblUsernameError.CenterX();

            return usernameError == "";
        }

        private bool CheckPasswordOk() {
            string passwordError = "";

            // Set the text to error text if the password field is empty or the password requirements are not met
            if (string.IsNullOrWhiteSpace(tbPassword.Text)) passwordError = "Please create a password";
            else if (DataValidator.GetPasswordRequirements(tbPassword.Text).Count < Enum.GetNames(typeof(DataValidator.PasswordRequirements)).Length) passwordError = "Please pick a stronger password";

            lblPasswordError.Text = passwordError;
            lblPasswordError.CenterX();

            return passwordError == "";
        }

        private bool CheckConfirmPasswordOk() {
            string confirmPasswordError = "";

            // Set the text to error text if the user has not confirmed their password or password field and confirm password field do not match 
            if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text)) confirmPasswordError = "Please confirm your password";
            else if (tbPassword.Text != tbConfirmPassword.Text) confirmPasswordError = "Passwords did not match";

            lblConfirmPasswordError.Text = confirmPasswordError;
            lblConfirmPasswordError.CenterX();

            return confirmPasswordError == "";
        }

        private void tbPassword_TextChanged(object sender, EventArgs e) {
            string text = tbPassword.Text;
            List<DataValidator.PasswordRequirements> requirements = DataValidator.GetPasswordRequirements(text);

            pbPasswordLength.Image = requirements.Contains(DataValidator.PasswordRequirements.Length) ? Resources.Icons.Icons.Green_Tick_Circle : Resources.Icons.Icons.Red_Cross_Circle;
            pbLettersNumbers.Image = requirements.Contains(DataValidator.PasswordRequirements.NumsAndChars) ? Resources.Icons.Icons.Green_Tick_Circle : Resources.Icons.Icons.Red_Cross_Circle;
            pbSpecialCharacters.Image = requirements.Contains(DataValidator.PasswordRequirements.SpecialChars) ? Resources.Icons.Icons.Green_Tick_Circle : Resources.Icons.Icons.Red_Cross_Circle;
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);

            tbUsername.CenterX();
            tbPassword.CenterX();
            tbConfirmPassword.CenterX();

            lblPasswordError.CenterX();
            lblUsernameError.CenterX();
            lblConfirmPasswordError.CenterX();

            pnlPasswordStrength.CenterX();
        }

        // Display the previous registration subform
        private void btnBack_Click(object sender, EventArgs e) {
            (((ActiveForm as formMaster)!.ChildView) as RegisterView)!.DisplayPreviousForm();
        }

        // Display the next reistration subform if the user has filled in all the fields
        private void btnDone_Click(object sender, EventArgs e) {
            if (CheckUsernameOk() & CheckPasswordOk() & CheckConfirmPasswordOk()) {
                ((ActiveForm as formMaster)!.ChildView as RegisterView)!.DisplayNextRegisterView();
                ((ActiveForm as formMaster)!.ChildView as RegisterView)?.CreateAccount();
            }
        }

        // Allow the user to see their password by clicking the eye icon in the picturebox
        private void pbPasswordView_MouseDown(object sender, MouseEventArgs e) {
            pbPasswordView.Image = Resources.Icons.Icons.Eye_crossed;
            tbPassword.UsePasswordChar = false;
        }

        private void pbPasswordView_MouseUp(object sender, MouseEventArgs e) {
            pbPasswordView.Image = Resources.Icons.Icons.Eye;
            tbPassword.UsePasswordChar = true;
        }

        private void tbPassword_Leave(object sender, EventArgs e) => CheckPasswordOk();

        private void tbUsername_Leave(object sender, EventArgs e) => CheckUsernameOk();

        private void tbConfirmPassword_Leave(object sender, EventArgs e) => CheckConfirmPasswordOk();
    }
}
