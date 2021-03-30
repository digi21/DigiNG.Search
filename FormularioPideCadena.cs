using System.Windows.Forms;
using DigiNG.Search.ExtensionMethods;

namespace DigiNG.Search
{
    public partial class FormularioPideCadena : Form
    {
        public FormularioPideCadena()
        {
            InitializeComponent();
            Activated += (_, e) => this.AdaptTheme();
        }

        public string CadenaBuscar => cadenaBuscar.Text;

        public bool CoincidirMayúsculasMinúsculas => coincidirMayúsculasMinúsculas.Checked;

        public bool SóloPalabrasCompletas => sóloPalabrasCompletas.Checked;
    }
}
