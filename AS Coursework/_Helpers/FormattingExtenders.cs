using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework._Helpers; 
internal static class FormattingExtenders {

    public static void CenterX(this Control control, Control parent) {
        control.Location = new Point((parent.Width - control.Width) / 2, control.Location.Y);
    }

    public static void CenterY(this Control control, Control parent) {
        control.Location = new Point(control.Location.X, (parent.Height - control.Height) / 2);
    }

    public static void Center(this Control control, Control parent) {
        CenterX(control, parent);
        CenterY(control, parent);
    }

    public static void CenterX(this Control control) {
        Control parent = control.Parent;
        if (parent != null) {
            control.CenterX(parent);
            return;
        }
        Form parentForm = control.FindForm();
        if (parentForm != null) {
            parentForm.CenterX(parentForm);
        }
    }

    public static void CenterY(this Control control) {
        Control parent = control.Parent;
        if (parent != null) {
            control.CenterY(parent);
            return;
        }
        Form parentForm = control.FindForm();
        if (parentForm != null) {
            parentForm.CenterY(parentForm);
        }
    }

    public static void Center(this Control control) {
        control.CenterX();
        control.CenterY();
    }
}
