using System.Windows.Forms;
using DigiNG.Search.ExtensionMethods;

namespace DigiNG.Search
{
    public partial class FormularioPideCódigo : Form
    {
        public FormularioPideCódigo()
        {
            InitializeComponent();

            Activated += (_, e) => this.AdaptTheme();
        }

        public string Código => código.Text;
    }
}
