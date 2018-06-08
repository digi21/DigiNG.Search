using System.Windows.Forms;

namespace DigiNG.Search
{
    public partial class FormularioBuscarLíneasCriterio : Form
    {
        public FormularioBuscarLíneasCriterio()
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

        public bool QueEsténCerradas
        {
            get
            {
                return queEsténCerradas.Checked;
            }
        }
    }
}
