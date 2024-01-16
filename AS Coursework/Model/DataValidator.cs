using System.Text.RegularExpressions;

namespace AS_Coursework.Model.Data; 
public static partial class DataValidator {
    public const int MINIMUM_USER_AGE = 16;

    // Regex patterns for password validation
    [GeneratedRegex(@"[A-Za-z]")]
    private static partial Regex LetterCharacter();
    [GeneratedRegex(@"[^\w\s]")]
    private static partial Regex SpecialCharacter();
    [GeneratedRegex(@"\d")]
    private static partial Regex NumberCharacter();

    public static bool IsUserOldEnough(DateTime dateOfBirth) {
        return CalculateAge(dateOfBirth) >= MINIMUM_USER_AGE;
    }

    // Method to calculate age for user age verification
    private static int CalculateAge(DateTime dateOfBirth) {
        // Unfortunately we cannot use cannot subtract the two DateTimes an use the resulting TimeSpan.
        // The amount of years that has passed is lost when converting from DateTime -> TimeSpan
        DateTime today = DateTime.Today;
        // Calculate the age as the difference in year from the birth year to this year
        int age = today.Year - dateOfBirth.Year;
        // This calculation of the age can be wrong if the user is born in a month that occurs before the month this year
        // If this is the case, correct is by subtracting one
        if (dateOfBirth.Date > today.AddYears(-age)) age--;
        return age;
    }

    // Categories that the password string should have
    public enum PasswordRequirements {
        Length,
        NumsAndChars,
        SpecialChars
    }

    /// <summary>
    /// Return a list of PasswordRequirements that the password string obeys
    /// </summary>
    /// <param name="password"></param>
    /// <returns></returns>
    public static List<PasswordRequirements> GetPasswordRequirements(string password) {
        List<PasswordRequirements> requirements = new();

        if (password.Length > 7) requirements.Add(PasswordRequirements.Length);
        if (LetterCharacter().Matches(password).Count > 0 && NumberCharacter().Matches(password).Count > 0) requirements.Add(PasswordRequirements.NumsAndChars);
        if (SpecialCharacter().Matches(password).Count > 0) requirements.Add(PasswordRequirements.SpecialChars);

        return requirements;
    }
}
