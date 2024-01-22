namespace AS_Coursework.View.QuizView;
public partial class formMultipleChoiceQuestion : Form {
    public formMultipleChoiceQuestion(string optionOne, string optionTwo, string optionThree, string optionFour) {
        InitializeComponent();

        btnNext.Visible = false;
    }

    public event EventHandler? NextQuestion;

    private void btnNext_Click(object sender, EventArgs e) {
        NextQuestion?.Invoke(this, EventArgs.Empty);
    }
}
