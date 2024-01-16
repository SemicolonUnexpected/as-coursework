namespace AS_Coursework.Model.Quiz; 
internal abstract class Question {

    public string QuestionName { get; set; }

    public Question(string questionName) {
        QuestionName = questionName;
    }

    public abstract IQuestionForm DisplayQuestion();
}
