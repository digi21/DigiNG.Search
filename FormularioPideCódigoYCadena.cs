using System.Windows.Forms;

namespace DigiNG.Search
{
    public partial class FormularioPideCódigoYCadena : Form
    {
        public FormularioPideCódigoYCadena()
        {
            InitializeComponent();
        }

        public string Código => código.Text;

        public string CadenaBuscar => cadenaBuscar.Text;

        public bool CoincidirMayúsculasMinúsculas => coincidirMayúsculasMinúsculas.Checked;

        public bool SóloPalabrasCompletas => sóloPalabrasCompletas.Checked;
    }
}
