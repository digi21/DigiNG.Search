using System;
using System.Windows.Forms;

namespace DigiNG.Search
{
    public partial class FormularioBuscarEntidadesAtributoNulo : Form
    {
        public FormularioBuscarEntidadesAtributoNulo()
        {
            InitializeComponent();
            camposExcluir.Text = "ACC\r\nTXT\r\nUID\r\nSDV\r\nSDP\r\nSRT\r\nCCN\r\nFCODE\r\nId";
        }

        public string[] CamposExcluir
        {
            get
            {
                return camposExcluir.Text.Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
