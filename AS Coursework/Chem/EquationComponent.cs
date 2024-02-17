using System.Text;

using static Chem.TokenType;

namespace Chem;

internal class EquationComponent {
    private List<Token> _tokens = new();

    public EquationComponent(List<Token> tokens) {
        _tokens = tokens;
    }

    public override string ToString() {
        StringBuilder stringBuilder = new();
        foreach (Token token in _tokens) {
        stringBuilder.Append(token.Type switch {
                    Number => token.Literal!.ToString(),
                    _ => throw new NotImplementedException(),
                    });
        }

        return stringBuilder.ToString();
    }
}
