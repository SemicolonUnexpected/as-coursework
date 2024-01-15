using System.Text.RegularExpressions;
using AS_Coursework._Helpers;
using AS_Coursework.Model.Data;
using AS_Coursework.Model.Security;
using AS_Coursework.Model.Users;

namespace AS_Coursework.View {
    public partial class RegisterCredentialsView : Form {

        [GeneratedRegex(@"[A-Za-z]")]
        private static partial Regex LetterCharacter();
        [GeneratedRegex(@"[^\w\s]")]
        private static partial Regex SpecialCharacter();
        [GeneratedRegex(@"\d")]
        private static partial Regex NumberCharacter();

        public AuthenticationDetails AuthenticationDetails {
            get => new AuthenticationDetails(tbUsername.Text, HashManager.GetHash(tbPassword.Text, out byte[] salt), salt, false);
        }

        public RegisterCredentialsView() {
            InitializeComponent();

            // Set the unacceptable keys in the textboxes
            tbUsername.NotAcceptedKeys = new Keys[] {
               Keys.Space,
               Keys.Tab,
            };

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
            else if (DataManager.UserExists(tbUsername.Text)) usernameError = "Username already taken";

            lblUsernameError.Text = usernameError;
            lblUsernameError.CenterX();

            return usernameError == "";
        }

        private bool CheckPasswordOk() {
            string passwordError = "";

            // Set the text to error text if the password field is empty or the password requirements are not met
            if (string.IsNullOrWhiteSpace(tbPassword.Text)) passwordError = "Please create a password";
            else if (GetRequirements(tbPassword.Text).Count < Enum.GetNames(typeof(PasswordRequirements)).Length) passwordError = "Please pick a stronger password";

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

        private void tbPassword_TextChanged(object sender, EventArgs e) {
            string text = tbPassword.Text;
            List<PasswordRequirements> requirements = GetRequirements(text);

            pbPasswordLength.Image = requirements.Contains(PasswordRequirements.Length) ? Resources.Icons.Green_Tick_Circle : Resources.Icons.Red_Cross_Circle;
            pbLettersNumbers.Image = requirements.Contains(PasswordRequirements.NumsAndChars) ? Resources.Icons.Green_Tick_Circle : Resources.Icons.Red_Cross_Circle;
            pbSpecialCharacters.Image = requirements.Contains(PasswordRequirements.SpecialChars) ? Resources.Icons.Green_Tick_Circle : Resources.Icons.Red_Cross_Circle;
        }

        // Allow the user to see their password by clicking the eye icon in the picturebox
        private void pbPasswordView_MouseDown(object sender, MouseEventArgs e) {
            pbPasswordView.Image = Resources.Icons.Eye_crossed;
            tbPassword.UsePasswordChar = false;
        }

        private void pbPasswordView_MouseUp(object sender, MouseEventArgs e) {
            pbPasswordView.Image = Resources.Icons.Eye;
            tbPassword.UsePasswordChar = true;
        }

        private void tbPassword_Leave(object sender, EventArgs e) => CheckPasswordOk();

        private void tbUsername_Leave(object sender, EventArgs e) => CheckUsernameOk();

        private void tbConfirmPassword_Leave(object sender, EventArgs e) => CheckConfirmPasswordOk();

        /// <summary>
        /// Returns the PasswordRequirements which the password meets
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private List<PasswordRequirements> GetRequirements(string password) {
            List<PasswordRequirements> requirements = new List<PasswordRequirements>();

            if (password.Length > 7) requirements.Add(PasswordRequirements.Length);
            if (LetterCharacter().Matches(password).Count > 0 && NumberCharacter().Matches(password).Count > 0) requirements.Add(PasswordRequirements.NumsAndChars);
            if (SpecialCharacter().Matches(password).Count > 0) requirements.Add(PasswordRequirements.SpecialChars);

            return requirements;
        }

        private enum PasswordRequirements {
            Length,
            NumsAndChars,
            SpecialChars
        }
    }
}
