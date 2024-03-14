using AS_Coursework.View.QuizView;
using Csv;

namespace AS_Coursework.Model.Quiz;
public class FlashcardQuestion : Question {
    public string FrontSide { get; private init; } 
    public string BackSide { get; private init; } 
    public override string QuestionDescription => base.QuestionDescription + " - " + FrontSide;

    public FlashcardQuestion(string questionName, string frontSide, string backSide) : base(questionName) {
        FrontSide = frontSide;
        BackSide = backSide;
    }

    public void Answered(bool isCorrect) {
        Correct = isCorrect;
        AllocatedExperience = isCorrect ? QuestionDataManager.FlashcardExperienceAllocation : 0;
    }

    public override Form DisplayQuestion() {
        return new formFlashcardQuestion(this);
    }

    public override string ToString() => base.ToString() + "," + Stringer.Stringify(FrontSide) + "," + Stringer.Stringify(BackSide);
}
