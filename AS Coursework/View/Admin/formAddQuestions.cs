using AS_Coursework._Helpers;
using AS_Coursework.Model.Quiz;
using System.ComponentModel;

namespace AS_Coursework.View;
public partial class formAddQuestions : Form {
    private List<Question> _questions = QuestionDataManager.All;

    public formAddQuestions() {
        InitializeComponent();

        _questions.Sort((x, y) => string.Compare(x.QuestionName, y.QuestionName));

        lbQuestionSelector.DisplayMember = "QuestionDescription";
        lbQuestionSelector.DataSource = new BindingList<Question>(_questions);
    }

    private void btnSearch_Click(object sender, EventArgs e) {
        if (tbSearch.Text == "") _questions.Sort();
        else _questions = _questions.OrderBy(x => Helpers.LevensteinDistanceRecursive(tbSearch.Text, x.QuestionName)).ToList();

        lbQuestionSelector.DataSource = new BindingList<Question>(_questions);
    }

    private void btnDeleteQuestion_Click(object sender, EventArgs e) {
    }

    private void btnTestQuestion_Click(object sender, EventArgs e) {
        if(lbQuestionSelector.SelectedItem is not null) 
    }

    private void ViewQuestion(Question question) {

    }

    private void AddQuestion() {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void formAddQuestions_Load(object sender, EventArgs e) {

    }
}
