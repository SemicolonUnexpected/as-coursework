using System.Text;

using static Chem.TokenType;

namespace Chem;

public class Equation : IEquatable<Equation> {
    // Under the hood, an equation is just a list of tokens
    private List<Token> _tokens = new();

    public bool IsBalanced => throw new NotImplementedException();

    public Equation(string equation) {
        EquationLexer lexer = new(equation);
        _tokens = lexer.Lex();

        foreach(Token token in _tokens) Console.WriteLine($"Type : {token.Type}, Literal : {token.Literal}");
    }

    // Pretty print the equation
    public override string ToString() {
        StringBuilder stringBuilder = new();

        foreach(Token token in _tokens) {
            switch(token.Type) {
                case ArrowLeftToRight : stringBuilder.Append(" → "); break;
                case ArrowRightToLeft : stringBuilder.Append(" ← "); break;
                case ArrowReversible : stringBuilder.Append(" ⇌ "); break;
                case Plus : stringBuilder.Append(" + "); break;
                case LeftParenthesis : stringBuilder.Append('('); break;
                case RightParenthesis : stringBuilder.Append(')'); break;
                case Text : stringBuilder.Append(token.Literal?.ToString()); break;
                case Superscript : stringBuilder.Append(CharacterSets.ToSuperscript(token.Literal!.ToString()!)); break;
                case Subscript : stringBuilder.Append(CharacterSets.ToSubscript(token.Literal!.ToString()!)); break;
                case Number : stringBuilder.Append(token.Literal?.ToString()); break;
            }
        }

        return stringBuilder.ToString().Trim();
    }

    public bool Equals(Equation? other) {
        if (other is null) return false;
        return _tokens.SequenceEqual(other._tokens);
    }
}
