namespace AS_Coursework.View.Admin; 
public partial class formAddMatchingQuestion : Form {
    public formAddMatchingQuestion() {
        InitializeComponent();
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }
}
