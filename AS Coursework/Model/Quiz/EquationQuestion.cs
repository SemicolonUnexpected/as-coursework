using AS_Coursework.View.QuizView;
using Chem;
using Csv;

namespace AS_Coursework.Model.Quiz;

// A question that is tailored to equations
public class EquationQuestion : Question {
    public Equation Equation { get; private init; }
    public string Question { get; private init; }
    public override string QuestionDescription => base.QuestionDescription + " - " + Question;

    public EquationQuestion(string questionName, string question, Equation equation) : base(questionName) {
        Equation = equation;
        Question = question;
    }

    public void CheckAnswer(string answer) {
        // Attempt to create an equation object
        // If it is not a valid euqtion the answer is incorrect
        try {
            Equation equation = new(answer);

            // Check the equation matches and allocate experience accordingly
            Correct = equation == Equation;
            AllocatedExperience = equation == Equation ? 0 : QuestionDataManager.EquationExperienceAllocation;
        }
        catch(EquationSyntaxException) {
            Correct = false;
            AllocatedExperience = 0;
        }
    }

    public override Form DisplayQuestion() => new formEquationQuestion(this);

    public override string ToString() => base.ToString() + ',' + Stringer.Stringify(Question) + "," + Stringer.Stringify(Equation.ToString());
}
