using System.Windows.Forms;

namespace DigiNG.Search
{
    public partial class FormularioPideCódigoYCadena : Form
    {
        public FormularioPideCódigoYCadena()
        {
            InitializeComponent();
        }

        public string Código
        {
            get
            {
                return código.Text;
            }
        }

        public string CadenaBuscar
        {
            get
            {
                return cadenaBuscar.Text;
            }
        }

        public bool CoincidirMayúsculasMinúsculas
        {
            get
            {
                return coincidirMayúsculasMinúsculas.Checked;
            }
        }

        public bool SóloPalabrasCompletas
        {
            get
            {
                return sóloPalabrasCompletas.Checked;
            }
        }
    }
}
