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

    public static int LevensteinDistanceRecursive(string a, string b) {
        if (b.Length == 0) return a.Length;
        if (a.Length == 0) return b.Length;
        if (a[0] == b[0]) return LevensteinDistanceRecursive(a[1..], b[1..]);
        else {
            int deletionDistance = LevensteinDistanceRecursive(a[1..], b);
            int insertationDistance = LevensteinDistanceRecursive(a, b[1..]);
            int substitutionDistance = LevensteinDistanceRecursive(a[1..], b[1..]);

            return 1 + Math.Min(deletionDistance, Math.Min(insertationDistance, substitutionDistance));
        }
    }

}
