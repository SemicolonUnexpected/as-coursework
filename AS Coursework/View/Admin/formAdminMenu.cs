using AS_Coursework.Model.Data;
using AS_Coursework._Helpers;
using System.ComponentModel;
using AS_Coursework.Custom_Controls;
using AS_Coursework.Model.Users;

namespace AS_Coursework.View;
public partial class formAdminMenu : Form {
    List<string> _userList = UserDataManager.GetUsernames();

    public formAdminMenu() {
        InitializeComponent();

        _userList.Sort();

        clbUserSelector.DataSource = new BindingList<string>(_userList);

        ShowAdminChecks();
    }

    private void btnViewUser_Click(object sender, EventArgs e) {
        if (clbUserSelector.SelectedValue is null) {
            CustomMessageBox.Show("", "No user selected");
            return;
        }
        if ((string)clbUserSelector.SelectedValue == User.ActiveUser!.AuthenticationDetails.Username) {
            CustomMessageBox.Show("", "You cannot view yourself here, go to your own settings page to see this");
            return;
        }

        (ActiveForm as formMaster)?.DisplayForm(new formUserSettingsViewer(UserDataManager.GetUser((string)clbUserSelector.SelectedValue)!));
    }

    private void btnSearch_Click(object sender, EventArgs e) {
        if (tbNewUsername.Text == "") _userList.Sort((x, y) => string.Compare(x.ToString(), y.ToString()));

        else _userList = _userList.OrderBy(x => Helpers.LevensteinDistance(tbNewUsername.Text, x)).ToList();

        clbUserSelector.DataSource = new BindingList<string>(_userList);

        ShowAdminChecks();
    }

    private void clbUserSelector_ItemCheck(object? sender, ItemCheckEventArgs e) {
        string checkedUsername = (string)clbUserSelector.SelectedValue!;

        UserDataManager.GetUser(checkedUsername)!.AuthenticationDetails.IsAdmin = e.NewValue == CheckState.Checked;
    }

    private void ShowAdminChecks() {
        clbUserSelector.ItemCheck -= clbUserSelector_ItemCheck;

        CheckedListBox.ObjectCollection collection = clbUserSelector.Items;
        for (int i = 0; i < collection.Count; i++) {
            if (collection[i] is null) continue;

            string username = (string)collection[i];

            if (UserDataManager.GetUser(username)!.AuthenticationDetails.IsAdmin) clbUserSelector.SetItemCheckState(i, CheckState.Checked);
            else clbUserSelector.SetItemCheckState(i, CheckState.Unchecked);
        }

        clbUserSelector.ItemCheck += clbUserSelector_ItemCheck;
    }

    private void tbNewUsername_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, e);
    }
}
