using System.Windows.Forms;
using DigiNG.Search.ExtensionMethods;

namespace DigiNG.Search
{
    public partial class FormularioPideCódigoYCadena : Form
    {
        public FormularioPideCódigoYCadena()
        {
            InitializeComponent();
            Activated += (_, e) => this.AdaptTheme();
        }

        public string Código => código.Text;

        public string CadenaBuscar => cadenaBuscar.Text;

        public bool CoincidirMayúsculasMinúsculas => coincidirMayúsculasMinúsculas.Checked;

        public bool SóloPalabrasCompletas => sóloPalabrasCompletas.Checked;
    }
}
