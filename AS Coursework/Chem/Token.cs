namespace Chem;

internal class Token {
    public  TokenType Type { get; init; }
    public object? Literal { get; init; }

    public Token(TokenType type, object? literal) {
        Type = type;
        Literal = literal;
    }

    public override string ToString() => $"Type : {Enum.GetName(Type)}, Literal : {Literal}";
}
