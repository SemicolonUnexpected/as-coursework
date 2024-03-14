using AS_Coursework.View.QuizView;
using Csv;

namespace AS_Coursework.Model.Quiz;
public class MultipleChoiceQuestion : Question {
    public string Question { get; private init; }
    public string CorrectAnswer { get; private init; }
    public string[] IncorrectAnswers { get; private init; }
    public override string QuestionDescription => base.QuestionDescription + " - " + Question;

    public MultipleChoiceQuestion(string questionName, string question, string correctAnswer, params string[] incorrectAnswers) : base(questionName) {
        Question = question;
        CorrectAnswer = correctAnswer;
        IncorrectAnswers = incorrectAnswers;
    }

    // Compare the strings to check the answer
    public bool CheckAnswer(string answer) {
        bool isCorrect = answer == CorrectAnswer;
        Correct = isCorrect;
        AllocatedExperience = isCorrect ? QuestionDataManager.MultipleChoiceExperienceAllocation : 0;
        return isCorrect;
    }

    public override Form DisplayQuestion() => new formMultipleChoiceQuestion(this);

    public override string ToString() => base.ToString() + "," + Stringer.Stringify(Question) + "," + Stringer.Stringify(CorrectAnswer) + "," + Stringer.Stringify(IncorrectAnswers)[..^1];
}
