using AS_Coursework.Model.Data;

namespace AS_Coursework.View; 
public partial class formAdminMenu : Form {
    public formAdminMenu() {
        InitializeComponent();
    }

    private void InitialiseData() {
        clbUserSelector.DataContext = UserDataManager.GetUserClone();
    }
}
