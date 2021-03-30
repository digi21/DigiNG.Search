using System.Windows.Forms;

namespace DigiNG.Search
{
    public partial class FormularioPideCódigo : Form
    {
        public FormularioPideCódigo()
        {
            InitializeComponent();
        }

        public string Código => código.Text;
    }
}
