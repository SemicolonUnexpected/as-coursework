namespace AS_Coursework.Model.Quiz; 
public interface IQuestionForm<TQuestion> where TQuestion : Question {
    public event EventHandler<QuestionAnsweredEventArgs>? QuestionAnswered;
    public event EventHandler? NextQuestion;
    public TQuestion Question { get; init; }
}
