using AS_Coursework.Model.Quiz;
using System.Globalization;

namespace AS_Coursework.View.Admin;
public partial class formAddMatchingQuestion : Form {
    public formAddMatchingQuestion() {
        InitializeComponent();

        dataGridView.Columns.Add("LeftHandSide", "Left  hand side");
        dataGridView.Columns.Add("RightHandSide", "Right  hand side");

        lblError.Text = "";
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }

    private void btnAdd_Click(object sender, EventArgs e) {
        dataGridView.Rows.Add();
    }

    private void btnDelete_Click(object sender, EventArgs e) {
        try {
            if (dataGridView.SelectedRows.Count > 0) dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
        }
        catch (InvalidOperationException) { }
    }

    private void btnAddQuestion_Click(object sender, EventArgs e) {
        List<string> errors = new();

        if (tbQuestionTitle.Text == "") errors.Add("fill in a question title");
        if (dataGridView.Rows.Count < 4) errors.Add("add at least four matching parts");

        Dictionary<string, string> answerPairs = new();

        try {
            foreach (DataGridViewRow row in dataGridView.Rows) {
                string key = row.Cells[0].Value is null ? "" : row.Cells[0].Value.ToString() ?? "";
                string value = row.Cells[1].Value is null ? "" : row.Cells[1].Value.ToString() ?? "";

                answerPairs.Add(key, value);
            }
        }
        catch (ArgumentException) {
            errors.Add("ensure all the left had side values are different");
        }

        if (errors.Count > 0) {
            CultureInfo culture = CultureInfo.InvariantCulture;
            string text = string.Join(", ", errors);
            text = text[..1].ToUpper(culture) + text[1..];
            lblError.Text = text;

            return;
        }

        QuestionDataManager.Matching.Add(new MatchingQuestion(tbQuestionTitle.Text, answerPairs));

        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }
}
