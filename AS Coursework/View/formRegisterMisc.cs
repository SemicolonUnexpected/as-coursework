using System.Diagnostics.Contracts;
using System.Net.Mail;
using AS_Coursework._Helpers;
using AS_Coursework.Model.Users;

namespace AS_Coursework.View {
    public partial class formRegisterMisc : Form {

        public MiscDetails MiscDetails {
            get => new MiscDetails(tbForename.Text, tbSurname.Text, new MailAddress(tbEmail.Text), dtpDateOfBirth.Value, (Gender)cbGender.SelectedIndex);
        }


        public formRegisterMisc() {
            InitializeComponent();

            // Set the error text to empty
            lblNameError.Text = "";
            lblEmailError.Text = "";
            lblDateOfBirthError.Text = "";
            lblGenderError.Text = "";
            lblDateOfBirthError.Text = "";

            // Set the current date of birth to today
            dtpDateOfBirth.MaxDate = DateTime.Today;

            // Set the minimum date of birth to 100 years ago
            dtpDateOfBirth.MinDate = DateTime.Today.Subtract(new TimeSpan(100 * 365, 0, 0, 0, 0));

            // Setup the gender options which can be found in the StringToGender dictionary
            cbGender.Items.AddRange(new string[] { "Male", "Female", "Other", "Prefer not to say" });

            // Call the OnResize event to ensure that the form is formatted correctly
            OnResize(EventArgs.Empty);
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);

            pnlDateOfBirth.CenterX();
            pnlGender.CenterX();

            tbForename.CenterX();
            tbSurname.CenterX();
            tbEmail.CenterX();

            lblDateOfBirthError.CenterX();
            lblNameError.CenterX();
            lblGenderError.CenterX();

            dtpDateOfBirth.CenterY();
            lblDateOfBirth.CenterY();

            cbGender.CenterY();
            lblGender.CenterY();
        }

        private bool CheckDateOfBirthOk() {
            string dateOfBirthError = "";

            // Set the text to error text if the date of birth would make the _ too young
            if (CalculateAge(dtpDateOfBirth.Value) < 16) dateOfBirthError = "You must be 16 to create an account";

            // Fix formatting
            lblDateOfBirthError.Text = dateOfBirthError;
            lblDateOfBirthError.CenterX();

            return dateOfBirthError == "";
        }

        private bool CheckNamesOk() {
            // Set the text to error text if the forename or surname field is empty
            string personalDetailsError = (string.IsNullOrWhiteSpace(tbForename.Text), string.IsNullOrWhiteSpace(tbSurname.Text)) switch {
                (true, true) => "Fill in your forename and surname",
                (true, false) => "Fill in your forename",
                (false, true) => "Fill in your surname",
                (false, false) => ""
            };

            // Fix formatting
            lblNameError.Text = personalDetailsError;
            lblNameError.CenterX();

            return personalDetailsError == "";
        }

        private bool CheckGenderOk() {
            string genderError = "";

            // Set the text to error text if there has been no selection of gender
            if (cbGender.SelectedIndex == -1) genderError = "Select a gender";

            // Fix formatting
            lblGenderError.Text = genderError;
            lblGenderError.CenterX();

            return genderError == "";
        }

        private bool CheckEmailOk() {
            string emailError = "";

            // Set the text to error text if the email is invalid or empty
            if (string.IsNullOrWhiteSpace(tbEmail.Text)) emailError = "Fill in your email";
            else if (!MailAddress.TryCreate(tbEmail.Text, out _)) emailError = "Please fill in a vaild email";

            // Fix formatting
            lblEmailError.Text = emailError;
            lblEmailError.CenterX();

            return emailError == "";
        }

        // Display the next registration subform if the details are correct
        private void btnNext_Click(object sender, EventArgs e) {
            // Use a single ampersand here to ensure all the checks are evaluated
            // This ensures the error text is displayed for all incorrect fields
            if (CheckDateOfBirthOk() & CheckNamesOk() & CheckGenderOk() & CheckEmailOk()) (((ActiveForm as formMaster)?.ChildView) as RegisterView)?.DisplayNextRegisterView();
        }

        private void dtpDateOfBirth_CloseUp(object sender, EventArgs e) {
            CheckDateOfBirthOk();
        }

        private void dtpDateOfBirth_Leave(object sender, EventArgs e) {
            CheckDateOfBirthOk();
        }

        private void tbSurname_Leave(object sender, EventArgs e) {
            CheckNamesOk();
        }

        private void tbEmail_Leave(object sender, EventArgs e) {
            CheckEmailOk();
        }

        private static int CalculateAge(DateTime dateOfBirth) {
            // Unfortunately we cannot use cannot subtract the two DateTimes an use the resulting TimeSpan.
            // The amount of years that has passed is lost when converting from DateTime -> TimeSpan
            DateTime today = DateTime.Today;
            // Calculate the age as the difference in year from the birth year to this year
            int age = today.Year - dateOfBirth.Year;
            // This calculation of the age can be wrong if the user is born in a month that occurs before the month this year
            // If this is the case, correct is by subtracting one
            if (dateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
