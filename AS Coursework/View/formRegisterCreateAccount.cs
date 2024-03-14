using AS_Coursework._Helpers;

namespace AS_Coursework.View; 
public partial class formRegisterCreateAccount : Form {
    public formRegisterCreateAccount() {
        InitializeComponent();
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        lblCreateAccount.MaximumSize = new Size((int)(Width * 0.9f), Height);

        btnReturnToLogin.CenterX();
        lblCreateAccount.CenterX();
    }

    private void btnCreateAccount_Click(object sender, EventArgs e) => (ActiveForm as formMaster)!.DisplayForm(new formLogin());
}
