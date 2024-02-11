using System.Collections.ObjectModel;

namespace AS_Coursework.Model.Users {
    public class UserProfileImage {

        public static ReadOnlyCollection<UserProfileImage> Images = new(new List<UserProfileImage> { 
            new UserProfileImage(Resources.Icons.Icons.User),
            new UserProfileImage(Resources.UserProfileImages.UserProfileImages.Scientist_1),
            new UserProfileImage(Resources.UserProfileImages.UserProfileImages.Scientist_2),
            new UserProfileImage(Resources.UserProfileImages.UserProfileImages.Scientist_3),
            new UserProfileImage(Resources.UserProfileImages.UserProfileImages.Scientist_4),
            new UserProfileImage(Resources.UserProfileImages.UserProfileImages.Scientist_5),
            new UserProfileImage(Resources.UserProfileImages.UserProfileImages.Scientist_6),
            new UserProfileImage(Resources.UserProfileImages.UserProfileImages.Scientist_7),
            new UserProfileImage(Resources.UserProfileImages.UserProfileImages.Scientist_8),
            new UserProfileImage(Resources.UserProfileImages.UserProfileImages.Scientist_9),
            new UserProfileImage(Resources.UserProfileImages.UserProfileImages.Atom),
            new UserProfileImage(Resources.UserProfileImages.UserProfileImages.Molecule),
        });

        public Image Image { get; set; }

        public UserProfileImage(Image image) {
            Image = image;
        }
    }
}
