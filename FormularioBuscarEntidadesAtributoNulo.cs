using System;
using System.Windows.Forms;
using DigiNG.Search.ExtensionMethods;

namespace DigiNG.Search
{
    public partial class FormularioBuscarEntidadesAtributoNulo : Form
    {
        public FormularioBuscarEntidadesAtributoNulo()
        {
            InitializeComponent();
            Activated += (_, e) => this.AdaptTheme();

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
