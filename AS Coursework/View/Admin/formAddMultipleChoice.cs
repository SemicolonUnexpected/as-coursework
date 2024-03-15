namespace AS_Coursework.View.Admin;
public partial class formAddMultipleChoiceQuestion : Form {
    private List<string> _incorrectOptions = new List<string>() { "" };
    public formAddMultipleChoiceQuestion() {
        InitializeComponent();

        lblError.Text = "";
        dataGridView.Columns.Add("", "");
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }

    private void btnDelete_Click(object sender, EventArgs e) {
        
    }

    private void btnAdd_Click(object sender, EventArgs e) {
        dataGridView.Rows.Add("");
    }
}
