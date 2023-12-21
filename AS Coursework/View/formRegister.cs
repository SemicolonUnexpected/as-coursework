using AS_Coursework._Helpers;
using AS_Coursework.Model.Data;
using AS_Coursework.Model.Users;

namespace AS_Coursework.View {
    public partial class RegisterView : Form {

        private Form? _childForm;

        List<Form> _registrationForms = new();

        public RegisterView() {
            InitializeComponent();

            DoubleBuffered = true;

            // Setup the quene with the registration subv views
            DisplayForm(new formRegisterMisc());
            _registrationForms.Add(new RegisterCredentialsView());
            _registrationForms.Add(new formRegisterCreateAccount());

            // Call the OnResize event to ensure that the form is formatted correctly
            OnResize(EventArgs.Empty);
        }

        private void DisplayForm(Form form) {
            _childForm = form;

            // Setup form display settings
            _childForm.TopLevel = false;
            _childForm.Dock = DockStyle.Fill;
            _childForm.FormBorderStyle = FormBorderStyle.None;
            _childForm.Enabled = true;
            _childForm.Visible = true;

            // Display in panel 
            pnlRegisterForm.Controls.Clear();
            pnlRegisterForm.Controls.Add(_childForm);
            pnlRegisterForm.Show();
        }

        public void DisplayNextRegisterView() {
            _registrationForms.Add(_childForm);
            DisplayForm(_registrationForms[0]);
            _registrationForms.RemoveAt(0);
        }

        public void DisplayPreviousForm() {
            _registrationForms.Insert(0, _childForm);
            DisplayForm(_registrationForms[^1]);
            _registrationForms.RemoveAt(_registrationForms.Count - 1);
        }

        protected override void OnResize(EventArgs e) {
            // Call the base method to invalidate then redraw the form
            base.OnResize(e);

            // Size the left panel to approximately half the size of the form
            pnlRight.Size = new Size((int)((Width - pnlRightGradOne.Width - pnlRightGradTwo.Width) * 0.4f), Height);

            // Calculate the image portion to preserve the aspect ratio
            float imagePortionWidth = pbBackground.Width / (float)pbBackground.Height * pbBackground.ImageSize.Height;
            // If the image portion width is greater than the picture width, stretch the picture
            imagePortionWidth = imagePortionWidth > pbBackground.ImageSize.Width ? pbBackground.ImageSize.Width : imagePortionWidth;
            pbBackground.ImagePortion = new Rectangle(0, 0, (int)imagePortionWidth, pbBackground.ImageSize.Height);

            // Force labels to take a new line if they are too long
            lblSignIn.MaximumSize = new Size((int)(0.9f * pnlRight.Width), Height);

            // Center elements
            lblRegisterTitle.CenterX();
            lblSignIn.CenterX();
            pnlRegisterForm.Center();
        }

        private void lblSignIn_MouseEnter(object sender, EventArgs e) {
            Font font = new(lblSignIn.Font, FontStyle.Underline);
            lblSignIn.Font = font;
        }

        private void LblSignIn_MouseLeave(object sender, EventArgs e) => lblSignIn.Font = new(lblSignIn.Font, FontStyle.Regular);

        private void lblSignIn_Click(object sender, EventArgs e) => (ActiveForm as formMaster)?.DisplayForm(new formLogin());

        // Create an account for the new user
        internal void CreateAccount() {
            MiscDetails miscDetails = (_registrationForms.Find(x => x is formRegisterMisc) as formRegisterMisc)!.MiscDetails;
            AuthenticationDetails authenticationDetails = (_registrationForms.Find(x => x is RegisterCredentialsView) as RegisterCredentialsView)!.AuthenticationDetails;
            FunctionalDetails functionalDetails = new FunctionalDetails(0, 0, 0, 0);

            User user = new(authenticationDetails, functionalDetails, miscDetails);

            DataManager.AddUser(user);
        }
    }
}
