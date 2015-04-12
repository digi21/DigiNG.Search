using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buscadores
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
