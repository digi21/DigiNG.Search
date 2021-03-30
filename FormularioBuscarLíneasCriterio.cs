using System.Windows.Forms;
using DigiNG.Search.ExtensionMethods;

namespace DigiNG.Search
{
    public partial class FormularioBuscarLíneasCriterio : Form
    {
        public FormularioBuscarLíneasCriterio()
        {
            InitializeComponent();
            Activated += (_, e) => this.AdaptTheme();
        }

        public string Código => código.Text;

        public bool QueEsténCerradas => queEsténCerradas.Checked;
    }
}
