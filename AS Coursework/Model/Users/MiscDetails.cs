using System.Net.Mail;

namespace AS_Coursework.Model.Users;

public class MiscDetails {
    public string Forename { get; set; }
    public string Surname { get; set; }
    public MailAddress Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }

    public MiscDetails(string forename, string surname, MailAddress email, DateTime dateOfBirth, Gender gender) {
        Forename = forename;
        Surname = surname;
        Email = email;
        DateOfBirth = dateOfBirth;
        Gender = gender;
    }

    public override string ToString() {
        return $"{Forename}, {Surname}, {Email}, {DateOfBirth.ToShortDateString()}, {(int)Gender}";
    }
}

