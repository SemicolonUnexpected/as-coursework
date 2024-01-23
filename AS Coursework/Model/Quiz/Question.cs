namespace AS_Coursework.Model.Quiz; 
public abstract class Question {

    public string QuestionName { get; init; }
    public int ExperienceAllocation { get; private set; }

    public Question(string questionName) {
        QuestionName = questionName;
    }

    public abstract Form DisplayQuestion();
}
