using Csv;

namespace AS_Coursework.Model.Quiz; 

// The base class from which all the question classes inherit
public abstract class Question {
    public string QuestionName { get; protected init; }
    public virtual string QuestionDescription => QuestionName; 
    public int AllocatedExperience { get; set; }

    // Represents whether the question has been answered correctly
    // If it is "null" the question has not been answered
    public bool? Correct { get; set; } = null;

    public Question(string questionName) {
        QuestionName = questionName;
    }

    // A method required by all question classes
    // All question classes must return a form that can then be displayed
    public abstract Form DisplayQuestion();

    // Converts this question to a string so it can be saved in the corresponding text file
    public override string ToString() => Stringer.Stringify(QuestionName);
}
