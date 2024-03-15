namespace Chem;

internal class Token : IEquatable<Token> {
    public  TokenType Type { get; init; }
    public object? Literal { get; init; }

    public Token(TokenType type, object? literal) {
        Type = type;
        Literal = literal;
    }

    public override string ToString() => $"Type : {Enum.GetName(Type)}, Literal : {Literal}";

    public static bool operator ==(Token a, Token b) => a.Equals(b);

    public static bool operator !=(Token a, Token b) => !(a == b);

    public bool Equals(Token? other) {
        return Type.Equals(other?.Type) && Literal?.ToString() == other.Literal?.ToString();
    }
}
