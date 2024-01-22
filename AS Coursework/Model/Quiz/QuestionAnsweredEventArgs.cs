namespace AS_Coursework.Model.Quiz; 
public class QuestionAnsweredEventArgs : EventArgs {
    public bool IsCorrect { get; init; }
    public int ExperienceAllocation { get; init; }

    public QuestionAnsweredEventArgs(bool isCorrect, int experienceAllocation) {
        IsCorrect = isCorrect;
        ExperienceAllocation = experienceAllocation;
    }
}
