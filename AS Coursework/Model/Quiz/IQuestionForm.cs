namespace AS_Coursework.Model.Quiz; 
internal interface IQuestionForm {
    public event EventHandler<QuizQuestionEventArgs>? QuestionAnswered;
    public event EventHandler? NextQuestion;
}
