using AS_Coursework.Model.Quiz;
using Chem;
using System.Globalization;

namespace AS_Coursework.View.Admin;
public partial class formAddFlashcard : Form {
    public formAddFlashcard() {
        InitializeComponent();

        lblError.Text = "";
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }

    private void btnAddQuesiton_Click(object sender, EventArgs e) {
        List<string> errors = new();

        if (tbQuestionTitle.Text == "") errors.Add("fill in the question title");
        if (tbFront.Text == "") errors.Add("fill in the question");
        if (tbBack.Text == "") errors.Add("fill in an equation answer");

        if (errors.Count > 0) {
            CultureInfo culture = CultureInfo.InvariantCulture;
            string text = string.Join(", ", errors);
            text = text[..1].ToUpper(culture) + text[1..];
            lblError.Text = text;

            return;
        }
        else {
            QuestionDataManager.Equation.Add(new EquationQuestion(tbQuestionTitle.Text, tbBack.Text, new Equation(tbAnswer.Text)));
        }

        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }
}
