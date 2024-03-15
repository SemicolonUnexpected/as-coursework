namespace AS_Coursework.Custom_Controls; 
public partial class ChemistryCharacterKeypad : UserControl {
    public ChemistryCharacterKeypad() {
        InitializeComponent();
    }

    public event EventHandler<string>? CharacterClicked;

    private void btnClick(object sender, EventArgs e) {
        CustomButton button = (CustomButton)sender;

        CharacterClicked?.Invoke(this, button.Text);
    }
}
