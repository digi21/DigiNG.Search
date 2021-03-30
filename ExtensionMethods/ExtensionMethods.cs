using System.Linq;
using System.Windows.Forms;
using Digi21.Digi3D;

namespace DigiNG.Search.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static void AdaptTheme(this Form form)
        {
            form.BackColor = Digi3D.BackgroundColor;
            foreach (var control in form.Controls.OfType<Label>())
                control.ForeColor = Digi3D.ForegroundColor;
            foreach (var control in form.Controls.OfType<CheckBox>())
                control.ForeColor = Digi3D.ForegroundColor;
        }
    }
}
