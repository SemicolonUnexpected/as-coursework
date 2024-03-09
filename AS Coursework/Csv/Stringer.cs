using System.Text;

namespace Csv;

public static class Stringer {
    public static string Stringify(IEnumerable<string?> values) {
        StringBuilder stringBuilder = new();

        foreach(string? value in values) {
            if (value is null) stringBuilder.Append(@"\-,");
            else {
                // String builder for speed
                StringBuilder fieldBuilder = new(value);

                // Replace all characters that need escaping
                fieldBuilder.Replace(@"\", @"\\");
                fieldBuilder.Replace(@",", @"\,");
                fieldBuilder.Replace("\n", @"\n");

                // Add a comma separator
                fieldBuilder.Append(',');

                stringBuilder.Append(fieldBuilder.ToString());
            }
        }

        // Remove the trailing comma from the string, add a trailing newline and return the final text
        stringBuilder.Remove(stringBuilder.Length - 1, 1);
        stringBuilder.Append('\n');
        return stringBuilder.ToString();
    }

    public static string Stringify(string? value) {
        StringBuilder stringBuilder = new(value);

        // Replace all characters that need escaping
        stringBuilder.Replace(@"\", @"\\");
        stringBuilder.Replace(@",", @"\,");
        stringBuilder.Replace("\n", @"\n");

        return stringBuilder.ToString();
    }

    public static string StringifyForFile(string?[][] fieldGroups) {
        StringBuilder outputFileString = new();

        foreach(string?[] fieldGroup in fieldGroups) {
            outputFileString.Append(Stringify(fieldGroup));
        }

        // Remove the trailing newline
        outputFileString.Remove(outputFileString.Length - 1, 1);
        return outputFileString.ToString();
    }
}
