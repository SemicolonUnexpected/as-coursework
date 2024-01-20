namespace AS_Coursework.Model.Quiz; 
internal class QuestionAnsweredCorrectlyEventArgs : EventArgs {
    public bool IsCorrect { get; init; }

    QuestionAnsweredCorrectlyEventArgs(bool isCorrect) {
        IsCorrect = isCorrect;
    }
}
