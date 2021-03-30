using System.Windows.Forms;

namespace DigiNG.Search
{
    public partial class FormularioPideCadena : Form
    {
        public FormularioPideCadena()
        {
            InitializeComponent();
        }

        public string CadenaBuscar => cadenaBuscar.Text;

        public bool CoincidirMayúsculasMinúsculas => coincidirMayúsculasMinúsculas.Checked;

        public bool SóloPalabrasCompletas => sóloPalabrasCompletas.Checked;
    }
}
