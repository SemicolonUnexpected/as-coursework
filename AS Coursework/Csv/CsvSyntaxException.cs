namespace Csv;

public class CsvSyntaxException : Exception {
    public string Line { get; private set; }
    public int Index { get; private set; }

    public CsvSyntaxException(string message, string line, int index) : base(message) {
        Line = line;
        Index = index;
    }

    public CsvSyntaxException(string message, ReadOnlySpan<char> line, int index) : base(message) {
        Line = line.ToString();
        Index = index;
    }
}
