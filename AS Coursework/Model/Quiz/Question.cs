namespace AS_Coursework.Model.Quiz; 
public abstract class Question {
    public string QuestionName { get; protected init; }
    public int AllocatedExperience { get; protected set; }
    public bool? Correct { get; protected set; } = null;

    public Question(string questionName) {
        QuestionName = questionName;
    }

    public abstract Form DisplayQuestion();
}
