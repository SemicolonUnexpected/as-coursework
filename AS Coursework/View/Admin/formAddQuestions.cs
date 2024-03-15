using AS_Coursework._Helpers;
using AS_Coursework.Custom_Controls;
using AS_Coursework.Model.Quiz;
using System.ComponentModel;

namespace AS_Coursework.View.Admin;
public partial class formAddQuestions : Form {
    private List<Question> _questions = QuestionDataManager.All;

    public formAddQuestions() {
        InitializeComponent();

        _questions.Sort((x, y) => string.Compare(x.QuestionName, y.QuestionName));

        lbQuestionSelector.DisplayMember = "QuestionDescription";
        lbQuestionSelector.DataSource = new BindingList<Question>(_questions);

        cbQuestionType.DataSource = new BindingList<string>() { "Multiple choice", "Matching", "Typing", "Equation", "Flashcard" };
    }

    private void btnSearch_Click(object sender, EventArgs e) {
        if (tbSearch.Text == "") _questions.Sort();
        else _questions = _questions.OrderBy(x => Helpers.LevensteinDistanceRecursive(tbSearch.Text, x.QuestionName)).ToList();

        lbQuestionSelector.DataSource = new BindingList<Question>(_questions);
    }

    private void btnDeleteQuestion_Click(object sender, EventArgs e) {
        if (lbQuestionSelector.SelectedItem is null) {
            CustomMessageBox.Show("", "Please select a quesiton");
            return;
        }

        if (CustomMessageBox.Show("", "Are you sure you want to delete this question?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
            QuestionDataManager.RemoveQuestion((Question)lbQuestionSelector.SelectedItem);

            _questions.Remove((Question)lbQuestionSelector.SelectedItem);

            lbQuestionSelector.DataSource = new BindingList<Question>(_questions);
        }
    }

    private void btnTestQuestion_Click(object sender, EventArgs e) {
        if (lbQuestionSelector.SelectedItem is null) {
            CustomMessageBox.Show("", "Please select a quesiton");
            return;
        }

        (ActiveForm as formMaster)?.DisplayForm(new formTestQuestion((Question)lbQuestionSelector.SelectedItem));
    }

    private void btnAddQuesiton_Click(object sender, EventArgs e) {
        switch (cbQuestionType.Text) {
            case "Multiple choice":
                (ActiveForm as formMaster)?.DisplayForm(new formAddMultipleChoiceQuestion());
                break;
            case "Matching":
                (ActiveForm as formMaster)?.DisplayForm(new formAddMatchingQuestion());
                break;
            case "Typing":
                (ActiveForm as formMaster)?.DisplayForm(new formAddTypingQuestion());
                break;
            case "Equation":
                (ActiveForm as formMaster)?.DisplayForm(new formAddEquationQuestion());
                break;
            case "Flashcard":
                (ActiveForm as formMaster)?.DisplayForm(new formAddFlashcardQuestion());
                break;
            default:
                throw new NotImplementedException("This is not a question type");
        }
    }

    private void tbSearch_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, e);
    }
}
