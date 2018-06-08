using System.Windows.Forms;

namespace DigiNG.Search
{
    public partial class FormularioPideCadena : Form
    {
        public FormularioPideCadena()
        {
            InitializeComponent();
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
