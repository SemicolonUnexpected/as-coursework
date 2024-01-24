using AS_Coursework.View.QuizView;

namespace AS_Coursework.Model.Quiz;
public class FlashcardQuestion : Question {
    public string FrontSide { get; private init; } 
    public string BackSide { get; private init; } 

    public FlashcardQuestion(string questionName, string frontSide, string backSide) : base(questionName) {
        FrontSide = frontSide;
        BackSide = backSide;
    }

    public void Answered(bool isCorrect) {
        Correct = isCorrect;
        AllocatedExperience = isCorrect ? 1 : 0;
    }

    public override Form DisplayQuestion() {
        return new formFlashcardQuestion(this);
    }
}
