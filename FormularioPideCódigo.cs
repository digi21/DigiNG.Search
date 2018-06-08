using System.Windows.Forms;

namespace DigiNG.Search
{
    public partial class FormularioPideCódigo : Form
    {
        public FormularioPideCódigo()
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
    }
}
