using System.Windows.Forms;

namespace DigiNG.Search
{
    public partial class FormularioBuscarEntidadesAtributoNuloPorCampo : Form
    {
        public FormularioBuscarEntidadesAtributoNuloPorCampo()
        {
            InitializeComponent();
        }


        public string Campo
        {
            get
            {
                return campo.Text;
            }
        }

    }
}
