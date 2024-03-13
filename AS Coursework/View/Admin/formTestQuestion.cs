using AS_Coursework.Model.Quiz;

namespace AS_Coursework.View.Admin; 
public partial class formTestQuestion : Form {
    private IQuestionForm _questionForm;

    public formTestQuestion(Question question) {
        InitializeComponent();

        DisplayQuestion(question.DisplayQuestion());
    }

    public void DisplayQuestion(Form questionForm) {
        // Form display settings
        questionForm.TopLevel = false;
        questionForm.Visible = true;

        // Display the form in the panel
        pnlQuestionDisplay.Controls.Clear();
        pnlQuestionDisplay.Controls.Add(questionForm);
        questionForm.Dock = DockStyle.Fill;

        _questionForm = (IQuestionForm)questionForm;

        // Subscribe to the next form event
        _questionForm.NextQuestion += Exit;
    }

    private void Exit(object? sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }
}
