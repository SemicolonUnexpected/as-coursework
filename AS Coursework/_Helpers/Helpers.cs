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


    public static int LevensteinDistance(string a, string b) {
        // Two work arrays
        int[] rowOne = new int[b.Length + 1];
        int[] rowTwo = new int[b.Length + 1];

        // If a or b in empty return the length
        if (a == "") return b.Length;
        if (b == "") return a.Length;

        for (int i = 0; i <= b.Length; i++) rowOne[i] = i;

        for (int i = 0; i <= a.Length - 1; i++) {
            rowOne[0] = i + 1;

            for (int j = 0; j <= b.Length - 1; j++) {
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

        return rowOne[b.Length];
    }

}
