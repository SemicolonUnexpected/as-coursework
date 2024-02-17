using AS_Coursework.View.QuizView;
using Chem;

namespace AS_Coursework.Model.Quiz;
public class EquationQuestion : Question {
    public Equation Equation { get; private init; }
    public string Question { get; private init; }
    public EquationQuestion(string questionName, string question, Equation equation) : base(questionName) {
        Equation = equation;
        Question = question;
    }

    public void CheckAnswer(string answer) {
        try {
            Equation equation = new(answer);

            Correct = equation == Equation;
            AllocatedExperience = equation == Equation ? 0 : 1;
        }
        catch(EquationSyntaxException e) {
            Correct = false;
            AllocatedExperience = 0;
        }
    }

    public override Form DisplayQuestion() => new formEquationQuestion(this);
}
