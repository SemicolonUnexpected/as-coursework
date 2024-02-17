using System.Text;

namespace Chem;

internal static class CharacterSets {
    private const string _subSuperscriptable = "0123456789+-n";
    private const string _subscript = "₀₁₂₃₄₅₆₇₈₉₊₋ₙ";
    private const string _superscript = "⁰¹²³⁴⁵⁶⁷⁸⁹⁺⁻ⁿ";

    public static bool IsSubSuperscriptable(char test) => _subSuperscriptable.Contains(test.ToString());

    public static bool IsSubscript(char test) => _subscript.Contains(test.ToString());
    public static bool IsSuperscript(char test) => _superscript.Contains(test.ToString());

    public static char ToSuperscript(char character) => _superscript[_subSuperscriptable.IndexOf(character)];
    public static string ToSuperscript(string text) {
        StringBuilder stringBuilder = new();
        foreach(char character in text) stringBuilder.Append(ToSuperscript(character));
        return stringBuilder.ToString();
    }

    public static char ToSubscript(char character) => _subscript[_subSuperscriptable.IndexOf(character)];
    public static string ToSubscript(string text) {
        StringBuilder stringBuilder = new();
        foreach(char character in text) stringBuilder.Append(ToSubscript(character));
        return stringBuilder.ToString();
    }

    public static char FromSuperscript(char character) => _subSuperscriptable[_superscript.IndexOf(character)];
    public static char FromSubscript(char character) =>  _subSuperscriptable[_subscript.IndexOf(character)];
}
