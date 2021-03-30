using System.Windows.Forms;
using DigiNG.Search.ExtensionMethods;

namespace DigiNG.Search
{
    public partial class FormularioBuscarEntidadesAtributoNuloPorCampo : Form
    {
        public FormularioBuscarEntidadesAtributoNuloPorCampo()
        {
            InitializeComponent();
            Activated += (_, e) => this.AdaptTheme();
        }

        public string Campo => campo.Text;
    }
}
