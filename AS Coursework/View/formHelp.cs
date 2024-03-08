namespace AS_Coursework.View; 
public partial class formHelp : Form {
    private const string HOME_HELP = """
        The home page is the main page on which the application opens. To access it from the side menu, click the home icon.

        The home page shows you some overview statistics on how well you are doing in the quiz.
        """;

    private const string RANKS_HELP = """
        The ranks page provides an overview of where you are placed on the leaderboard. To access it from the side menu click the podium icon.

        Users are ranked by their experience points and the top 10 users appear on the podium. You can see your experience level and your own rank in the panel at the side
        """;

    private const string QUIZ_PAGE_HELP = $"""
        The quiz page allows you to start a quiz. Each quiz has 10 questions and the type of quiz can be selected from the buttons on this page.

        For each type of question, experience is allocated as follows...
        Multiple choice - 
        """;

    public formHelp() {
        InitializeComponent();

        comboBox.DataSource = new List<string>() {
            "Home page",
            "Ranks page",
            "Quiz page",
            "Multiple choice question",
            "Matching question",
            "Flashcard question",
            "Typing question",
            "Equation question",
        };

        comboBox.SelectedIndex = -1;
    }

    private void comboBox_SelectedIndexChanged(object sender, EventArgs e) {
        lblHelpInfo.Text = comboBox.SelectedItem switch {
            "Home page" => HOME_HELP,
            "Ranks page" => RANKS_HELP,
            "Quiz page" => QUIZ_PAGE_HELP,
            "Multiple choice question" => "",
            "Matching question" => "",
            "Flashcard question" => "",
            "Typing question" => "",
            "Equation question" => "",
            _ => ""
        };
    }
}
