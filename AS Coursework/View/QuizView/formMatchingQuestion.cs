using AS_Coursework.Model.Quiz;
using AS_Coursework._Helpers;
using AS_Coursework.Custom_Controls;

namespace AS_Coursework.View.QuizView;
public partial class formMatchingQuestion : Form, IQuestionForm {
    private bool _questionAnswered;

    // Local variables to make maniplation of the combo boxes easier
    private List<Label> _labels;
    private List<ComboBox> _comboBoxes;
    private List<CustomRectangle> _panels;

    private MatchingQuestion _question;

    public formMatchingQuestion(MatchingQuestion question) {
        InitializeComponent();

        _question = question;

        // Initailise the helper variables
        _comboBoxes = new() { cb1, cb2, cb3, cb4, };
        _labels = new() { lbl1, lbl2, lbl3, lbl4, };
        _panels = new() { pnlDecoration1, pnlDecoration2, pnlDecoration3, pnlDecoration4, };

        // Display the question options
        InitialiseOptions();

        // Make sure nothing is selected at first
        btnReset_Click(null, EventArgs.Empty);
    }

    public event EventHandler? NextQuestion;

    // Setup the options for the combo boxes
    private void InitialiseOptions() {
        (List<string> leftHandSide, List<string> rightHandSide) = _question.GetAnswerPairs();

        // The left hand side and the labels will contain the keys
        // The right hand side and the combo boxes will contian the values
        leftHandSide.Shuffle();
        rightHandSide.Shuffle();

        for (int i = 0; i < 4; i++) {
            _labels[i].Text = leftHandSide[i];
        }

        // Set the data source of each combo box to a clone of the list by converting it to a new array each time
        // This must be done otherwise all combo boxes select the same value
        foreach (ComboBox comboBox in _comboBoxes) {
            comboBox.DataSource = rightHandSide.ToArray();
        }
    }
    
    // Reset all the combo boxes to have no selection
    private void btnReset_Click(object? sender, EventArgs e) {
        foreach (ComboBox cb in _comboBoxes) {
            cb.SelectedIndex = -1;
        }
    }

    // Check and display the answer correctness
    private void btnSubmitNext_Click(object sender, EventArgs e) {
        if (!_questionAnswered) {
            _questionAnswered = true;

            // Disable all the controls after the question is answered
            btnReset.Enabled = false;
            foreach (ComboBox comboBox in _comboBoxes) {
                comboBox.Enabled = false;
            }

            // Check the answers and display it
            DisplayAnswerCorrectness();

            btnSubmitNext.Text = "Next";
        }
        else {
            // Tell listeners that the next question has been requested
            NextQuestion?.Invoke(sender, EventArgs.Empty);
        }
    }

    private void DisplayAnswerCorrectness() {
        for (int i = 0; i < 4; i++) {
            // Change the corresponding panel colour depending on whether the question is correct
            _panels[i].BackColor = _question.CheckAnswerPair(_labels[i].Text, _comboBoxes[i].SelectedValue as string) ? Color.Green : Color.Red;
        }
    }
}
