using AS_Coursework._Helpers;
using AS_Coursework.Model;
using AS_Coursework.Model.Login;

namespace AS_Coursework.View;
public partial class formLogin : Form {
    public formLogin() {
        InitializeComponent();
        
        DoubleBuffered = true;

        // Set the unacceptable keys in the textboxes
        tbUsername.NotAcceptedKeys = new Keys[] {
            Keys.Space,
            Keys.Tab,
        };

        // Call the OnResize event to ensure that the form is formatted correctly
        OnResize(new EventArgs());
    }

    #region View manipulation
    protected override void OnResize(EventArgs e) {
        // Call the base method to invalidate then redraw the form
        base.OnResize(e);

        // Size the left panel to approximately half the size of the form
        pnlLeft.Size = new Size((int)((Width - pnlLeftGradOne.Width - pnlLeftGradTwo.Width) * 0.4f), Height);

        // Calculate the image portion to preserve the aspect ratio
        float imagePortionWidth = pbBackground.Width / (float)pbBackground.Height * pbBackground.ImageSize.Height;
        // If the image portion width is greater than the picture width, stretch the picture
        imagePortionWidth = imagePortionWidth > pbBackground.ImageSize.Width ? pbBackground.ImageSize.Width : imagePortionWidth;
        pbBackground.ImagePortion = new Rectangle(pbBackground.ImageSize.Width - (int)imagePortionWidth, 0, (int)imagePortionWidth, pbBackground.ImageSize.Height);

        // Force labels to take a new line if they are too long
        lblError.MaximumSize = new Size((int)(0.9f * pnlLeft.Width), Height);
        lblRegister.MaximumSize = new Size((int)(0.9f * pnlLeft.Width), Height);

        // Center elements
        lblLoginTitle.CenterX();
        lblWelcome.CenterX();
        lblRegister.CenterX();
        lblError.CenterX();
        tbPassword.CenterX();
        tbUsername.CenterX();
        pnlWelcomeTitle.CenterX();
        btnLogin.CenterX();
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

    // Underline the font in the register label when the user hovers over it
    private void lblRegister_MouseEnter(object sender, EventArgs e) {
        lblRegister.Font = new Font(lblRegister.Font, FontStyle.Underline);
    }

    private void lblRegister_MouseLeave(object sender, EventArgs e) {
        lblRegister.Font = new Font(lblRegister.Font, FontStyle.Regular);
    }

    #endregion

    // Navigate to a new register view when the register label is clicked
    private void lblRegister_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new RegisterView());
    }

    // Attempt login if enter is pressed or the login button is clicked
    private void btnLogin_Click(object sender, EventArgs e) {
        AttemptLogin();
    }

    private void tbUsername_KeyPress(object sender, KeyPressEventArgs e) {
        if (e.KeyChar != Convert.ToChar(Keys.Return)) return;
        AttemptLogin();
    }

    private void tbPassword_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Return) AttemptLogin();
        else if (e.KeyCode == Keys.Tab) MessageBox.Show("Test");
    }

    private void AttemptLogin() {
        LoginResult result = LoginManager.Login(tbUsername.Text, tbPassword.Text);

        // Display the correct error message or navigate to the user's home
        switch (result) {
            case LoginResult.SuccessfulLogin:
                (ActiveForm as formMaster)?.DisplayForm(new formMainMenu());
                break;
            case LoginResult.UsernameNotFound:
            case LoginResult.PasswordIncorrect:
                lblError.Text = "Your username or password was incorrect";
                break;
            case LoginResult.FieldsEmpty:
                lblError.Text = (string.IsNullOrEmpty(tbUsername.Text), string.IsNullOrEmpty(tbPassword.Text)) switch {
                    (true, true) => "Fill in your username and password",
                    (true, false) => "Fill in your username",
                    (false, true) => "Fill in your password",
                    (false, false) => ""
                };
                break;
        }

        lblError.CenterX();
    }
}
