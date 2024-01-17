using System.Text.RegularExpressions;

namespace AS_Coursework.View.Quiz; 
public partial class TextQuestion : Form {
    private Regex _answerRegex;
    public TextQuestion(string title, string question, Regex correctAnswer) {
        InitializeComponent();

        lblQuestionTitle.Text = title;
        lblQuestionText.Text = question;
        _answerRegex = correctAnswer;
    }

    public TextQuestion(string title, string question, Regex correctAnswer, Image image) {
        InitializeComponent();

        lblQuestionTitle.Text = title;
        lblQuestionText.Text = question;
        _answerRegex = correctAnswer;
    }
}
