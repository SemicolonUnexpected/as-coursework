namespace AS_Coursework.Model.Quiz; 
internal interface IQuestionFormWithValidation<TAnswer> {
    public event EventHandler<QuizQuestionEventArgs<TAnswer>>? QuestionAnswered;
    public void DisplayAnswerCorrectness(bool isCorrect);
}
