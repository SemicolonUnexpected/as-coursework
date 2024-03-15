using System.Text;

namespace AS_Coursework._Helpers;
public static class Helpers {

    private static Random _random = new Random();

    // Implementation of the modern version Fisher-Yates shuffle for a list
    public static void Shuffle<T>(this List<T> list) {
        for (int i = 0; i < list.Count; i++) {
            int j = _random.Next(i, list.Count);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }

    public static void Shuffle<T>(this T[] list) {
        for (int i = 0; i < list.Length; i++) {
            int j = _random.Next(i, list.Length);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }

    /*
     function LevenshteinDistance(char s[0..m-1], char t[0..n-1]):
    // create two work vectors of integer distances
    declare int v0[n + 1]
    declare int v1[n + 1]

    // initialize v0 (the previous row of distances)
    // this row is A[0][i]: edit distance from an empty s to t;
    // that distance is the number of characters to append to  s to make t.
    for i from 0 to n:
        v0[i] = i

    for i from 0 to m - 1:
        // calculate v1 (current row distances) from the previous row v0

        // first element of v1 is A[i + 1][0]
        //   edit distance is delete (i + 1) chars from s to match empty t
        v1[0] = i + 1

        // use formula to fill in the rest of the row
        for j from 0 to n - 1:
            // calculating costs for A[i + 1][j + 1]
            deletionCost := v0[j + 1] + 1
            insertionCost := v1[j] + 1
            if s[i] = t[j]:
                substitutionCost := v0[j]
            else:
                substitutionCost := v0[j] + 1

            v1[j + 1] := minimum(deletionCost, insertionCost, substitutionCost)

        // copy v1 (current row) to v0 (previous row) for next iteration
        // since data in v1 is always invalidated, a swap without copy could be more efficient
        swap v0 with v1
    // after the last swap, the results of v1 are now in v0
    return v0[n] 
    */

    public static int LevensteinDistance(string a, string b) {
        int[] rowOne = new int[a.Length + 1];
        int[] rowTwo = new int[a.Length + 1];

        for (int i = 0; i < a.Length; i++) rowOne[i] = i;

        for (int i = 0; i < b.Length - 1; i++) {
            rowOne[0] = i + 1;

            for (int j = 0; j < a.Length - 1; j++) {
                int deletionCost = rowOne[j + 1] + 1;
                int insertationCost = rowTwo[j] + 1;
                int substitutionCost;

                if (a[i] == b[j]) {
                    substitutionCost = rowOne[j];
                }
                else {
                    substitutionCost = rowOne[j] + 1;
                }

                rowTwo[j + 1] = Math.Min(deletionCost, Math.Min(insertationCost, substitutionCost));
            }

            (rowOne, rowTwo) = (rowTwo, rowOne);
        }

        return rowOne[a.Length];
    }

}
