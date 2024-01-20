namespace AS_Coursework.Model.Quiz; 
public class QuizQuestionEventArgs<TAnswer> : EventArgs {
    public TAnswer Answer { init; get; }

    public QuizQuestionEventArgs(TAnswer answer) {
        Answer = answer;
    }
}
