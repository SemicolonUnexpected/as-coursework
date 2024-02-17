namespace Chem;

public class EquationSyntaxException : Exception {
    public string Equation { get; init; }
    public int Index { get; init; }

    public EquationSyntaxException(string message, string equation, int index) : base(message) {
        Equation = equation;
        Index = index;
    }
}
