using System.Windows.Forms;
using DigiNG.Search.ExtensionMethods;

namespace DigiNG.Search
{
    public partial class FormularioExpresionPython : Form
    {
        public FormularioExpresionPython()
        {
            InitializeComponent();
            Activated += (_, e) => this.AdaptTheme();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ayuda.digi21.net/digi3d-net/referencia/editor-de-tablas-de-codigos/pestanas/selecciones");
        }
    }
}
