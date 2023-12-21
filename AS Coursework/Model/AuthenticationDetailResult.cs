namespace AS_Coursework.Model.Login;
public enum AuthenticationDetailResult
{
    TooShort,
    ContainsWhitespace,
    MissingNumber,
    MissingSpecialCharacter,
    InUse
}