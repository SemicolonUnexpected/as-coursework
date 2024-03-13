using AS_Coursework.Model.Quiz;

namespace AS_Coursework.View;
public partial class formQuizSettings : Form {
    public formQuizSettings() {
        InitializeComponent();

        upDownQuestionCount.Value = QuestionDataManager.QuestionCount;
        upDownMultipleChoice.Value = QuestionDataManager.MultipleChoiceExperienceAllocation;
        upDownEquations.Value = QuestionDataManager.EquationExperienceAllocation;
        upDownFlashcards.Value = QuestionDataManager.FlashcardExperienceAllocation;
        upDownMatching.Value = QuestionDataManager.MatchingExperienceAllocation;
        upDownTyping.Value = QuestionDataManager.TypingExperienceAllocation;
    }

    private void upDownQuestionCount_ValueChanged(object sender, EventArgs e) => QuestionDataManager.QuestionCount = (int)upDownQuestionCount.Value;

    private void upDownMultipleChoice_ValueChanged(object sender, EventArgs e) => QuestionDataManager.MultipleChoiceExperienceAllocation = (int)upDownMultipleChoice.Value;

    private void upDownMatching_ValueChanged(object sender, EventArgs e) => QuestionDataManager.MatchingExperienceAllocation = (int)upDownMatching.Value;

    private void upDownTyping_ValueChanged(object sender, EventArgs e) => QuestionDataManager.TypingExperienceAllocation = (int)upDownTyping.Value;

    private void upDownEquations_ValueChanged(object sender, EventArgs e) => QuestionDataManager.EquationExperienceAllocation = (int)upDownEquations.Value;

    private void upDownFlashcards_ValueChanged(object sender, EventArgs e) => QuestionDataManager.FlashcardExperienceAllocation = (int)upDownFlashcards.Value;
}
