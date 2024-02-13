using AS_Coursework.Model.Data;
using AS_Coursework.Model.Users;
using System.ComponentModel;

namespace AS_Coursework.View;
public partial class formAdminMenu : Form {
    List<string> _userList = UserDataManager.GetUsernames();

    public formAdminMenu() {
        InitializeComponent();

        clbUserSelector.DataSource =  new BindingList<string>(_userList);
    }

    private void btnViewUser_Click(object sender, EventArgs e) {
        if (clbUserSelector.SelectedValue is null) return;

        (ActiveForm as formMaster)?.DisplayForm(new formUserSettingsViewer(UserDataManager.GetUser((string)clbUserSelector.SelectedValue)!));
    }
}
