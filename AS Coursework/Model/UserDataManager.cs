using Csv;
using AS_Coursework.Custom_Controls;
using AS_Coursework.Model.Users;
using System.Net.Mail;

namespace AS_Coursework.Model.Data;
internal static class UserDataManager {
    private const string PATH = "UserData.txt";
    private static List<User> _users = new();

    #region User list manipulation

    public static bool UserExists(string username) => _users.Any(user => user.AuthenticationDetails.Username == username);
    public static User? GetUser(string username) => _users.Find(user => user.AuthenticationDetails.Username == username);
    public static bool GetUser(int index, out User? user) {
        try {
            user = _users[index];
            return true;
        }
        catch (ArgumentOutOfRangeException) {
            user = null;
            return false;
        }
    }

    public static int GetUserRank(User user) {
        // Sort the users by rank first
        _users.Sort();

        // Create a hash set of all the experience values
        HashSet<int> rankScores = _users.Select(x => x.FunctionalDetails.Experience).ToHashSet();

        return 1 + rankScores.Count(x => x > user.FunctionalDetails.Experience);
    }

    public static User? GetUser(int index) {
        return _users[index];
    }

    public static void AddUser(User user) {
        _users.Add(user);
    }

    public static void DeleteUser(User user) {
        _users.Remove(user);
    }

    public static List<string> GetUsernames() {
        return _users.Select(x => x.AuthenticationDetails.Username).ToList();
    }

    #endregion

    static UserDataManager() {
        ReadIn();
    }

    private static void ReadIn() {
        // ensure the file exists
        if (!File.Exists(PATH)) File.Create(PATH);

        using StreamReader reader = new(PATH);

        string text = reader.ReadToEnd();

        // Only try to parse the file if there are actually users there
        try {
            string?[][] fieldGroups = Parser.ParseText(text);
            // Parse each field group, excluding the last as it will be an empty line
            foreach (string?[] fields in fieldGroups.SkipLast(1)) {
                // Attempt to parse the data from the file
                AuthenticationDetails authenticationDetails = new(
                    username: fields[0]!,
                    hashedPassword: Convert.FromHexString(fields[1]!),
                    salt: Convert.FromHexString(fields[2]!),
                    isAdmin: Convert.ToBoolean(fields[3]!));

                FunctionalDetails functionalData = new(
                    experience: int.Parse(fields[4]!),
                    profileImageIndex: int.Parse(fields[5]!),
                    questionsAnswered: int.Parse(fields[6]!),
                    questionsCorrect: int.Parse(fields[7]!));

                MiscDetails miscData = new(
                    forename: fields[8]!,
                    surname: fields[9]!,
                    email: new MailAddress(fields[10]!),
                    dateOfBirth: DateTime.Parse(fields[11]!),
                    gender: (Gender)int.Parse(fields[12]!));

                _users.Add(new User(authenticationDetails, functionalData, miscData));
            }
        }
        catch (Exception e) {
            // Log the exception and tell the user
            ExceptionLogger.LogException(e, "There was an error reading user data");
            CustomMessageBox.Show("Error", "There was an error loading user data, please contact an admin");
        }

        // Add the root user if they dont exist
        if (!_users.Any(x => x.AuthenticationDetails.Username == "root")) _users.Add(new User("root",
            Convert.FromHexString("12C493A8FF8694D8C18B03FF3DF3074659F53C4B17A06844FE75C97C7D2FFC7C0EB196ACE4B5632F32CFC7AC41E97A81EB986F956DEC3B9836387789EF5D3F17"),
            Convert.FromHexString("A428A3CDA544043B31391B857E0A9A935151A101C262E1D9EF3C7FB41583F6CEF59F93C3B1625CF46EB80061A73A68140C3455316F18820367A9CBC4CF9B88A0"),
            true,
            555,
            1,
            10,
            9,
            "",
            "",
            new MailAddress("root@gmail"),
            DateTime.Now,
            Gender.PreferNotToSay));

        _users.Sort();
    }

    public static void Write() {
        // Prevent user data being overwritten if there is an error
        if (_users.Count <= 1) return;

        using StreamWriter writer = new(PATH, false);

        string output = string.Empty;
        foreach (User user in _users) {
            output += user.GetCsvSerialisation();
        }

        writer.Write(output);
    }
}
