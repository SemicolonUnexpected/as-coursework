namespace Chem;

internal enum TokenType {
    // Separators 
    ArrowLeftToRight, // '->'
    ArrowRightToLeft, // '<-'
    ArrowReversible, // '<->'
    Plus, // '+'
    LeftParenthesis, // '('
    RightParenthesis, // ')'

    // Chemical equation components
    Text,
    Subscript, // Denoted by an underscore
    Superscript, // Denoted by the caret symbol
    Number
}
