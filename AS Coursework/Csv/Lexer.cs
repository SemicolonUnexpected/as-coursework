using System.Text;

namespace Csv;

internal static class Lexer {
    private const string BACKSLASH_NOT_ESCAPED_EXCEPTION = "Backslashes must be escaped";

    public static List<string?> Lex(LineIterator lineIterator) {
        List<string?> fields = new();

        // Use a StringBuilder for storing the field as it is faster than using += syntax
        StringBuilder fieldBuilder = new();

        // Iterate over the line and parse it to a list of fields
        while (true) {
            // Clear the StringBuilder before starting to parse the field
            fieldBuilder.Clear();

            // Iterate over the field until the end is found
            while (true) {
                // The backslash is an escape character
                // Parse escaped characters
                if (lineIterator.Current == '\\') {

                    // Add an escaped comma
                    if (lineIterator.Peek(',')) {
                        fieldBuilder.Append(',');
                        lineIterator.Next(2);
                    }                
                    // Add an escaped new line
                    else if (lineIterator.Peek('n')) {
                        fieldBuilder.Append('\n');
                        lineIterator.Next(2);
                    }
                    // Add an escaped backslash
                    else if (lineIterator.Peek('\\')) {
                        fieldBuilder.Append('\\');
                        lineIterator.Next(2);
                    }
                    // Parse a null value, a backslash then a dash by itself
                    else if (lineIterator.Peek('-') && 
                            (lineIterator.Peek(',', 2) || lineIterator.Peek('\n', 2)) &&
                            (lineIterator.Previous(',') || lineIterator.AtStart) &&
                            fieldBuilder.Length == 0) {
                        fields.Add(null);
                        lineIterator.Next(3);
                        break;
                    }
                    // Throw an exception if there is an unescaped backslash
                    else {
                        throw new CsvSyntaxException(BACKSLASH_NOT_ESCAPED_EXCEPTION, lineIterator.Line, lineIterator.Index);
                    }

                    continue;
                }

                // Break at the end of the line or at a closing comma
                if (lineIterator.Current == '\n' || lineIterator.Current == ',') {
                    lineIterator.Next();
                    fields.Add(fieldBuilder.ToString());
                    break;
                }

                fieldBuilder.Append(lineIterator.Current);
                lineIterator.Next();
            }

            // Exit if at the end of the string but add an empty string is exiting on a comma
            if (lineIterator.Current == '\n') {
                if (lineIterator.Previous(',')) fields.Add("");
                break;
            }
        }

        return fields;
    }
}
