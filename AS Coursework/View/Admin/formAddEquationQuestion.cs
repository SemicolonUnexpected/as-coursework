using AS_Coursework.Model.Quiz;
using Chem;
using System.Globalization;

namespace AS_Coursework.View.Admin;
public partial class formAddEquationQuestion : Form {
    public formAddEquationQuestion() {
        InitializeComponent();

        lblError.Text = "";
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }

    private void btnAddQuesiton_Click(object sender, EventArgs e) {
        List<string> errors = new();

        if (tbQuestionTitle.Text == "") errors.Add("fill in the question title");
        if (tbQuestion.Text == "") errors.Add("fill in the question");
        if (tbAnswer.Text == "") errors.Add("fill in an equation answer");
        else {
            try {
                Equation equation = new Equation(tbAnswer.Text);
            }
            catch {
                errors.Add("Invalid equation");
            }
        }


        if (errors.Count > 0) {
            CultureInfo culture = CultureInfo.InvariantCulture;
            string text = string.Join(", ", errors);
            text = text[..1].ToUpper(culture) + text[1..];
            lblError.Text = text;

            return;
        }
        else {
            QuestionDataManager.Equation.Add(new EquationQuestion(tbQuestionTitle.Text, tbQuestion.Text, new Equation(tbAnswer.Text)));
        }

        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }

    private void chemistryCharacterKeypad1_CharacterClicked(object sender, string e) => tbAnswer.Text += e;
}
