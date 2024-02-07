using System;
using System.Net.Mail;

namespace AS_Coursework.Model.Users;

public class User : IComparable<User> {

    // For testing purposes
    public static readonly User Empty = new("", Array.Empty<byte>(), Array.Empty<byte>(), false, 0, 0, 0, 0, "", "", new MailAddress("test@test"), DateTime.Now, 0);

    public static User? ActiveUser { get; set; }

    public AuthenticationDetails AuthenticationDetails { get; set; }
    public FunctionalDetails FunctionalDetails { get; set; }
    public MiscDetails MiscDetails { get; set; }

    public User(string username, byte[] hashedPassword, byte[] salt, bool isAdmin, int experience, int profileImageIndex, int questionsAnswered, int questionsCorrect, string forename, string surname, MailAddress email, DateTime dateOfBirth, Gender gender) {
        AuthenticationDetails = new AuthenticationDetails(username, hashedPassword, salt, isAdmin);
        FunctionalDetails = new FunctionalDetails(experience, profileImageIndex, questionsAnswered, questionsCorrect);
        MiscDetails = new MiscDetails(forename, surname, email, dateOfBirth, gender);
    }

    public User(AuthenticationDetails authenticationDetails, FunctionalDetails functionalData, MiscDetails miscData) {
        AuthenticationDetails = authenticationDetails;
        FunctionalDetails = functionalData;
        MiscDetails = miscData;
    }

    // This allows the user to be converted to a csv safe string
    // All commas, backslashes, null values and newlines are escaped properly
    public string GetCsvSerialisation() {
        return Csv.Stringer.Stringify(new string?[] {
            // Stringify all the authentication details
            AuthenticationDetails.Username,
            Convert.ToHexString(AuthenticationDetails.HashedPassword),
            Convert.ToHexString(AuthenticationDetails.Salt),
            AuthenticationDetails.IsAdmin.ToString(),

            // Stringify functional details
            FunctionalDetails.Experience.ToString(),
            FunctionalDetails.ProfileImageIndex.ToString(),
            FunctionalDetails.QuestionsAnswered.ToString(),
            FunctionalDetails.QuestionsCorrect.ToString(),

            // Stringify misc details
            MiscDetails.Forename.ToString(),
            MiscDetails.Surname.ToString(),
            MiscDetails.Email.ToString(),
            MiscDetails.DateOfBirth.ToString(),
            ((int)(MiscDetails.Gender)).ToString(),
        });
    }

    public int CompareTo(User? user) => user is null ? -1 : user.FunctionalDetails.Experience.CompareTo(FunctionalDetails.Experience);
}