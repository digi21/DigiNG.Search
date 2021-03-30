using System.Windows.Forms;

namespace DigiNG.Search
{
    public partial class FormularioBuscarLíneasCriterio : Form
    {
        public FormularioBuscarLíneasCriterio()
        {
            InitializeComponent();
        }

        public string Código => código.Text;

        public bool QueEsténCerradas => queEsténCerradas.Checked;
    }
}
