using AS_Coursework.Model.Quiz;

namespace AS_Coursework.View.QuizView;
public partial class formEquationQuestion : Form, IQuestionForm {
    private bool _questionAnswered = false;
    private EquationQuestion _question;

    public formEquationQuestion(EquationQuestion question) {
        InitializeComponent();
        _question = question;
    }

    public event EventHandler? NextQuestion;

    public void DisplayAnswerCorrectness(bool isCorrect) {
        // Display the corresponding output depending on if the answer is correct or not
        if (isCorrect) {
            pbIsCorrect.Image = Resources.Icons.Icons.Green_Tick_Circle;
            lblIsCorrect.Text = "Correct, well done!";
        }
        else {
            pbIsCorrect.Image = Resources.Icons.Icons.Red_Cross_Circle;
            lblIsCorrect.Text = $"Incorrect, better luck next time. The correct answer was: {_question.Equation}";
        }
    }

    // Check and display the answer correctness
    private void btnSubmitNext_Click(object sender, EventArgs e) {
        if (!_questionAnswered) {
            tbAnswer.Enabled = false;
            _questionAnswered = true;

            _question.CheckAnswer(tbAnswer.Text);

            DisplayAnswerCorrectness((bool)_question.Correct!);
            btnSubmitNext.Text = "Next";
        }
        else {
            // Tell listeners that the next question has been requested
            NextQuestion?.Invoke(sender, EventArgs.Empty);
        }
    }

    // Add the character passed from the keypad to the answer line
    private void chemistryCharachterKeypad1_CharacterClicked(object sender, string e) {
        tbAnswer.Text += e;
    }
}
