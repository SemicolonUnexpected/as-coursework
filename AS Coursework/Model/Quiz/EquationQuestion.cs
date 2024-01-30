using AS_Coursework.View.QuizView;
using System.Text.RegularExpressions;

namespace AS_Coursework.Model.Quiz;
public class EquationQuestion : Question {
    public string Equation { get; private init; }
    public EquationQuestion(string questionName, string equation) : base(questionName) {
        Equation = equation;
    }

    public void CheckAnswer(string answer) {
        // Remove any whitespace then compare the equations
        string trimmedAnswer = Regex.Replace(answer, @"\w", ""); 
        string trimmedEquation = Regex.Replace(answer, @"\w", ""); 

        Correct = trimmedAnswer == trimmedEquation;
        AllocatedExperience = trimmedAnswer == trimmedEquation ? 0 : 1;
    }

    public override Form DisplayQuestion() => new formEquationQuestion(this);
}
