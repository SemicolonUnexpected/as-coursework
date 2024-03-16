using AS_Coursework.Model.Quiz;
using System.Globalization;
using System.Linq;

namespace AS_Coursework.View.Admin;
public partial class formAddMultipleChoiceQuestion : Form {
    public formAddMultipleChoiceQuestion() {
        InitializeComponent();

        lblError.Text = "";
        dataGridView.Columns.Add("", "");
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }

    private void btnDelete_Click(object sender, EventArgs e) {
        try {
            if (dataGridView.SelectedRows.Count > 0) dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
        }
        catch (InvalidOperationException) { }
    }

    private void btnAdd_Click(object sender, EventArgs e) {
        dataGridView.Rows.Add();
    }

    private void btnAddQuestion_Click(object sender, EventArgs e) {
        List<string> errors = new();

        if (tbQuestionTitle.Text == "") errors.Add("add a question title");
        if (tbCorrectAnswer.Text == "") errors.Add("add a correct answer");
        if (tbQuestion.Text == "") errors.Add("add a question");
        if (dataGridView.Rows.Count < 3) errors.Add("fill in at least 3 incorrect answers");

        if (errors.Count > 0) {
            CultureInfo culture = CultureInfo.InvariantCulture;
            string text = string.Join(", ", errors);
            text = text[..1].ToUpper(culture) + text[1..];
            lblError.Text = text;

            return;
        }

        List<string> incorrectAnswers = new();

        foreach (DataGridViewRow row in dataGridView.Rows) {
            string incorrectAnswer = row.Cells[0].Value is null ? "" : row.Cells[0].Value.ToString() ?? "";
            incorrectAnswers.Add(incorrectAnswer);
        }

        QuestionDataManager.MultipleChoice.Add(new MultipleChoiceQuestion(tbQuestionTitle.Text, tbQuestion.Text, tbCorrectAnswer.Text, incorrectAnswers.ToArray()));

        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }
}
