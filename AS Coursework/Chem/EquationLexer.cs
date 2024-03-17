using System.Text;
using static Chem.TokenType;

namespace Chem;

internal class EquationLexer {
    private readonly string _equation;
    private int _index = 0;
    private List<Token> tokens = new();

    public EquationLexer(string equation) {
        _equation = equation;
    }

    public List<Token> Lex() {

        // Iterate over the whole equation string
        while(!AtEnd()) {
            ScanToken();
        }

        return tokens;
    }

    private void ScanToken() {
        char current = Advance();

        switch (current) {
            // Ignore whitespace
            case ' ' :
            case '\r' :
            case '\t' : 
            case '\n' :
                break;

            // Handle parenthesis
            case '(' : AddToken(LeftParenthesis); break;
            case ')' : AddToken(RightParenthesis); break;

            // Handle plus symbol
            case '+' : AddToken(Plus); break;

            // Handle non-unicode arrows
            case '-':
                if (!Match('>')) Error("Missing arrow head");
                AddToken(ArrowLeftToRight);
                break;

            case '<' :
                if (!Match('-')) Error("Missing arrow body");
                if (Match('>')) AddToken(ArrowReversible);
                else AddToken(ArrowRightToLeft);
                break;

            // Handle unicode arrows
            case '→' : AddToken(ArrowLeftToRight); break;
            case '←' : AddToken(ArrowRightToLeft); break;
            case '⇌' : AddToken(ArrowReversible); break;

            // Handle superscript non-unicode
            case '^' :
                if (!Match('{')) Error("Missing brace");
                int superscriptStart = _index;
                while (Peek() != '}' && !AtEnd()) {
                    current = Advance();

                    // Check if character is valid
                    if (!CharacterSets.IsSubSuperscriptable(current)) Error($"The character {current} can not be part of a superscript");
                }

                if (AtEnd()) Error("Superscript brace not closed");

                // Skip over the closing '}'
                Next();

                AddToken(Superscript, _equation.Substring(superscriptStart, _index - superscriptStart - 1));
                break;

            // Handle subscript non-unicode
            case '_' :
                if (!Match('{')) Error("Missing brace");
                int subscriptStart = _index;
                while (Peek() != '}' && !AtEnd()) {
                    current = Advance();

                    // Check if character is valid
                    if (!CharacterSets.IsSubSuperscriptable(current)) Error($"The character {current} can not be part of a subscript");
                }

                if (AtEnd()) Error("Subscript brace not closed");

                // Skip over the closing '}'
                Next();

                AddToken(Subscript, _equation.Substring(subscriptStart, _index - subscriptStart - 1));
                break;

            default :
                // Handle balancing numbers
                if (char.IsAsciiDigit(current)) {
                    int start = _index - 1;
                    while (Peek() is not null && char.IsAsciiDigit((char)Peek()!)) Next();
                    try {
                        AddToken(Number, int.Parse(_equation.Substring(start, _index - start)));
                    }
                    catch {
                        Error("Could not parse the number");
                    }
                    break;
                }

                // Handle text
                if (char.IsAsciiLetter(current)) {
                    int start = _index - 1;
                    while (Peek() is not null && char.IsAsciiLetter((char)Peek()!)) Next();
                    AddToken(Text, _equation.Substring(start, _index - start));
                    break;
                }

                // Handle unicode subscript
                if (CharacterSets.IsSubscript(current)) {
                    int start = _index - 1;
                    while (Peek() is not null && CharacterSets.IsSubscript((char)Peek()!)) Next();

                    string subscript = _equation.Substring(start, _index - start);
                    StringBuilder literal = new();
                    foreach (char part in subscript) literal.Append(CharacterSets.FromSubscript(part));

                    AddToken(Subscript, literal.ToString());
                    break;
                }

                // Handle unicode superscript
                if (CharacterSets.IsSuperscript(current)) {
                    int start = _index - 1;
                    while (Peek() is not null && CharacterSets.IsSuperscript((char)Peek()!)) Next();

                    string superscript = _equation.Substring(start, _index - start);
                    StringBuilder literal = new();
                    foreach (char part in superscript) literal.Append(CharacterSets.FromSuperscript(part));

                    AddToken(Superscript, literal.ToString());
                    break;
                }

                // If we get here that means the string contains
                // a value that the equation lexer cannot handle 
                Error($"Invalid token in equation : {current}");
                break;
        }
    }

    #region Helpers

    // Lexer movements
    private bool AtEnd() => _index >= _equation.Length;

    private char Advance() => _equation[_index++];

    private void Next(int step = 1) => _index += step;

    private char? Peek(int step = 0) {
        if (_index + step >= _equation.Length) return null;
        return _equation[_index + step];
    }

    private bool Match(char expected) {
        if (AtEnd()) return false;
        if (_equation[_index] == expected) {
            Next();
            return true;
        }
        else return false;
    }

    // Helpers to add tokens quickly
    private void AddToken(TokenType type) => tokens.Add(new Token(type, null));

    private void AddToken(TokenType type, object? literal) => tokens.Add(new Token(type, literal));

    // Throw an error with a specified message
    private void Error(string message) => throw new EquationSyntaxException(message, _equation, _index);

    #endregion
}
