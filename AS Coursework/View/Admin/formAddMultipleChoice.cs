namespace AS_Coursework.View.Admin; 
public partial class formAddMultipleChoiceQuestion : Form {
    public formAddMultipleChoiceQuestion() {
        InitializeComponent();
    }
    private void btnCancel_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }
}
