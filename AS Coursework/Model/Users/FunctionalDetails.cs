namespace AS_Coursework.Model.Users;
public class FunctionalDetails {
    public int Experience { get; set; }

    public int Level => Experience / 100;

    public  int LeftOverExperience => Experience % 100;

    public  UserProfileImage ProfileImage { get => UserProfileImage.Images[ProfileImageIndex]; }

    public int ProfileImageIndex { get; set; }

    public int QuestionsAnswered { get; set; }

    public int QuestionsCorrect {  get; set; }

    public double PercentageAccuracy {
        get {
            if (QuestionsAnswered == 0) return 0;
            return Math.Round((double)QuestionsCorrect/ QuestionsAnswered * 100, 1);
        }
    }

    public FunctionalDetails(int experience, int profileImageIndex, int questionsAnswered, int questionsCorrect) {
        Experience = experience;
        ProfileImageIndex = profileImageIndex;
        QuestionsAnswered = questionsAnswered;
        QuestionsCorrect = questionsCorrect;
    }

    public override string ToString() => $"{Experience}, {ProfileImageIndex}, {QuestionsAnswered}, {QuestionsCorrect}";
}
