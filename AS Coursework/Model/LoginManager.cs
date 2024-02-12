using AS_Coursework.Model.Data;
using AS_Coursework.Model.Security;
using AS_Coursework.Model.Users;
using static AS_Coursework.Model.LoginResult;

namespace AS_Coursework.Model.Login;
internal static class LoginManager {
    public static LoginResult Login(string username, string password) {
        if (password == string.Empty || username == string.Empty) return FieldsEmpty;
        if (!UserDataManager.UserExists(username)) return UsernameNotFound;

        User? selectedUser = UserDataManager.GetUser(username);

        if (selectedUser is null) throw new NullReferenceException(nameof(selectedUser));

        if (HashManager.VerifyHashEquality(password, selectedUser.AuthenticationDetails.HashedPassword, selectedUser.AuthenticationDetails.Salt)) {
            User.ActiveUser = selectedUser;
            return SuccessfulLogin;
        }

        return PasswordIncorrect;
    }
}
