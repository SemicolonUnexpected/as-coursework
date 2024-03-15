using AS_Coursework.Model.Quiz;
using System.Globalization;
using System.Text.RegularExpressions;

namespace AS_Coursework.View.Admin;
public partial class formAddTypingQuestion : Form {
    private string _filePath = "";

    public formAddTypingQuestion() {
        InitializeComponent();

        lblError.Text = "";
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }

    private void btnAddQuesiton_Click(object sender, EventArgs e) {
        List<string> errors = new List<string>();

        if (tbQuestionTitle.Text == "") errors.Add("fill in the question title");
        if (tbQuestion.Text == "") errors.Add("fill in the question");
        if (tbAnswer.Text == "") errors.Add("please fill in an answer");

        // Check if a regex has been used
        if (!(tbRegex.Text == "")) {
            try {
                Regex regex = new(tbRegex.Text);
            }
            catch (RegexParseException) {
                errors.Add("invalid regex");
            }
        }

        if (errors.Count > 0) {
            CultureInfo culture = CultureInfo.InvariantCulture;
            string text = string.Join(", ", errors);
            text = text[..1].ToUpper(culture) + text[1..];
            lblError.Text = text;

            return;
        }
        else if (tbRegex.Text == "") {
            if (_filePath != "") QuestionDataManager.Typing.Add(new ImageTypingQuestion(tbQuestionTitle.Text, tbQuestion.Text, tbAnswer.Text, new Regex(tbAnswer.Text), _filePath));
            else QuestionDataManager.Typing.Add(new TypingQuestion(tbQuestionTitle.Text, tbQuestion.Text, tbAnswer.Text, new Regex(tbAnswer.Text)));
        }
        else {
            if (_filePath != "") QuestionDataManager.Typing.Add(new ImageTypingQuestion(tbQuestionTitle.Text, tbQuestion.Text, tbAnswer.Text, new Regex(tbRegex.Text), _filePath));
            else QuestionDataManager.Typing.Add(new TypingQuestion(tbQuestionTitle.Text, tbQuestion.Text, tbAnswer.Text, new Regex(tbRegex.Text)));
        }

        (ActiveForm as formMaster)?.DisplayForm(new formMainMenu(new formAddQuestions()));
    }

    private void btnAddImage_Click(object sender, EventArgs e) {
        // Add an image if there isn't one already
        if (_filePath == "") {
            using OpenFileDialog ofd = new();

            ofd.ShowDialog();
            _filePath = ofd.FileName;
            lblFilePath.Text = $"File path: {_filePath}";
            btnAddImage.Text = "Remove image";
        }
        // Remove an image if there is one
        else {
            _filePath = "";
            lblFilePath.Text = "";
            btnAddImage.Text = "Add image";
        }
    }
}
