using AS_Coursework.Model.Users;
using AS_Coursework.Model.Quiz;
using AS_Coursework.Custom_Controls;

namespace AS_Coursework.View.QuizView;
public partial class formQuizMenu : Form {
    public formQuizMenu() {
        InitializeComponent();

        lblUsername.Text = User.ActiveUser!.AuthenticationDetails.Username;
        pbUserProfile.Image = User.ActiveUser!.FunctionalDetails.ProfileImage.Image;
    }

    private void btnAllQuestions_Click(object sender, EventArgs e) {
        CustomButton btn = (sender as CustomButton)!;

        // Start a quiz based on which button was clicked
        Quiz.QuizStyle style;

        if (btn.Name == btnAll.Name) style = Quiz.QuizStyle.All;
        else if (btn.Name == btnText.Name) style = Quiz.QuizStyle.Text;
        else if (btn.Name == btnMultipleChoice.Name) style = Quiz.QuizStyle.MultipleChoice;
        else if (btn.Name == btnFillTheBlanks.Name) style = Quiz.QuizStyle.Matching;
        else if (btn.Name == btnFlashcards.Name) style = Quiz.QuizStyle.FlashCard;
        else if (btn.Name == btnEquations.Name) style = Quiz.QuizStyle.Equation;
        else throw new NotImplementedException();

        (ActiveForm as formMaster)?.DisplayForm(new formQuiz(style));        
    }

    private void StartQuiz(Quiz.QuizStyle quizStyle) {
        (ActiveForm as formMaster)?.DisplayForm(new formQuiz(quizStyle));
    }
}
