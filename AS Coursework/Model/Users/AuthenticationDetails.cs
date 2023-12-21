namespace AS_Coursework.Model.Users;
public class AuthenticationDetails
{
    public string Username { get; set; }
    public byte[] HashedPassword { get; set; }
    public byte[] Salt { get; set; }
    public bool IsAdmin {  get; set; }

    public AuthenticationDetails(string username, byte[] hashedPassword, byte[] salt, bool isAdmin)
    {
        Username = username;
        HashedPassword = hashedPassword;
        Salt = salt;
        IsAdmin = isAdmin;
    }

    public override string ToString() {
        return $"{Username}, {Convert.ToHexString(HashedPassword)}, {Convert.ToHexString(Salt)}, {IsAdmin}";
    }
}
