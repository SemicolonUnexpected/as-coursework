namespace AS_Coursework.Model.Quiz; 
internal abstract class Question<TAnswer> {

    public string QuestionName { get; init; }

    public Question(string questionName) {
        QuestionName = questionName;
    }

    public abstract IQuestionForm DisplayQuestion();
    public abstract bool AnswerCorrect(TAnswer answer);
}
