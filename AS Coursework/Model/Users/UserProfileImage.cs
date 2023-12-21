using System.Collections.ObjectModel;

namespace AS_Coursework.Model.Users {
    public class UserProfileImage {

        public static ReadOnlyCollection<UserProfileImage> Images = new(new List<UserProfileImage> { 
            new UserProfileImage(Resources.Icons.User, new Rectangle(-256, -256, 1024, 1024)),
            new UserProfileImage(Resources.UserProfileImages.Scientist_1, new Rectangle(-256, -256, 1024, 1024)),
            new UserProfileImage(Resources.UserProfileImages.Scientist_2, new Rectangle(-256, -256, 1024, 1024)),
            new UserProfileImage(Resources.UserProfileImages.Scientist_3, new Rectangle(-256, -256, 1024, 1024)),
            new UserProfileImage(Resources.UserProfileImages.Scientist_4, new Rectangle(-256, -256, 1024, 1024)),
            new UserProfileImage(Resources.UserProfileImages.Scientist_5, new Rectangle(-256, -256, 1024, 1024)),
            new UserProfileImage(Resources.UserProfileImages.Scientist_6, new Rectangle(-256, -256, 1024, 1024)),
            new UserProfileImage(Resources.UserProfileImages.Scientist_7, new Rectangle(-256, -256, 1024, 1024)),
            new UserProfileImage(Resources.UserProfileImages.Scientist_8, new Rectangle(-256, -256, 1024, 1024)),
            new UserProfileImage(Resources.UserProfileImages.Scientist_9, new Rectangle(-256, -256, 1024, 1024)),
            new UserProfileImage(Resources.UserProfileImages.Scientist_10, new Rectangle(-256, -256, 1024, 1024)),
            new UserProfileImage(Resources.UserProfileImages.Scientist_11, new Rectangle(-256, -256, 1024, 1024)),
            new UserProfileImage(Resources.UserProfileImages.Scientist_12, new Rectangle(-256, -256, 1024, 1024)),
        });

        public Image Image { get; set; }
        public Rectangle ImagePortion { get; set; }

        public UserProfileImage(Image image, Rectangle imagePortion) {
            Image = image;
            ImagePortion = imagePortion;
        }
    }
}
