using AS_Coursework.Model.Quiz;

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

    private string QUIZ_PAGE_HELP => $"""
        The quiz page allows you to start a quiz. Each quiz has 10 questions and the type of quiz can be selected from the buttons on this page.

        For each type of question, experience is allocated as follows...
        Multiple choice - {QuestionDataManager.MultipleChoiceExperienceAllocation} xp
        Matching - {QuestionDataManager.MatchingExperienceAllocation} xp
        Typing - {QuestionDataManager.TypingExperienceAllocation} xp
        Equation - {QuestionDataManager.EquationExperienceAllocation} xp
        Flashcard - {QuestionDataManager.FlashcardExperienceAllocation} xp
        """;

    private const string MULTIPLE_CHOICE = """
        Multiple choice questions allow you to select the correct answer from multiple options.

        Click the button with the answer you think is correct to answer.
        """;

    private const string MATCHING = """
        To answer a matching question, match the answers that you think pair best to gain maximum experience points.

        You can match the pairs by selecting them from the dropdown menu.

        To reset the question, click the icon with the arrows.
        """;

    private const string FLASHCARD = """
        This is a simple digital flashcard. You can view the other side of it by clicking the switch sides button, represented by arrows.

        Read the question, and if you know the answer, click the  button that says "I know this". If you do not know the answer click the button that says "I don't know this".
        """;

    private const string TYPING = """
        To answer this question, read the question and then type the answer in the box. Once you are happy click submit.
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
            "Multiple choice question" => MULTIPLE_CHOICE,
            "Matching question" => MATCHING,
            "Flashcard question" => FLASHCARD,
            "Typing question" => TYPING,
            "Equation question" => "",
            _ => ""
        };
    }
}
