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

}
