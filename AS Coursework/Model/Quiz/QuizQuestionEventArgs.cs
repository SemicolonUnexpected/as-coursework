namespace AS_Coursework.Model.Quiz; 
public class QuizQuestionEventArgs : EventArgs {
    public bool Correct { init; get; }

    public QuizQuestionEventArgs(bool correct) {
        Correct = correct;
    }
}
