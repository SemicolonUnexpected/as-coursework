namespace Csv;

internal ref struct LineIterator {
    private const string NEW_LINE_ERROR = "A line must have the newline character at the end only";

    public int Index { get; private set; }

    // Use a ReadOnlySpan (allocated on the stack) for speed
    // This also means that the LineIterator object must be a ref struct
    public ReadOnlySpan<Char> Line { get; private init; }

    public LineIterator(string line) {
        Line = line.AsSpan();

        // Make sure there are no newlines in the line iterator
        // This method finds the first index of the specified character
        // If it is not at the end, we know that the newline is in the wrong place or not present
        int newlineLocations = Line.IndexOf('\n');
        if (newlineLocations != line.Length - 1) throw new CsvSyntaxException(NEW_LINE_ERROR, Line.ToString(), newlineLocations);
    }

    public readonly int Length => Line.Length;

    public readonly bool AtStart => Index == 0;

    // Increment the index if within the range
    public void Next(int step = 1) {
        Index = Math.Min(Index += step, Length - 1);
    }

    // Get the character at the current index
    public readonly char Current => Line[Index];

    // Look at the character ahead of the index and return whether it matches the test character
    public readonly bool Peek(char testChar, int step = 1) {
        int position = Index + step;
        if (position >= Length) return false;
        else return Line[position] == testChar;
    }

    // Look at the character behind the index and return whether it matches the test character
    public readonly bool Previous(char testChar, int step = 1) {
        int position = Index - step;
        if (position < 0) return false;
        else return Line[position] == testChar;
    }
}
