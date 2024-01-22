namespace AS_Coursework.Model.Quiz; 
public abstract class Question {

    public string QuestionName { get; init; }

    public Question(string questionName) {
        QuestionName = questionName;
    }

    public abstract Form DisplayQuestion();
}
