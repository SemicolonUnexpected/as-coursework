namespace AS_Coursework.Model.Quiz; 
// This interface allows for a form to be treated as the frontend of the question
// This also makes management of the form easier
// It would be ideal to inherit from the form itself however this can introduce unecessary complexity
// Inherited forms do not have automatic designer support
public interface IQuestionForm {
    public event EventHandler? NextQuestion;
}
