using System;
using System.Linq;
using System.Windows.Forms;
using DigiNG.Search.ExtensionMethods;

namespace DigiNG.Search
{
    public partial class FormularioBuscarPorCampoBBDD : Form
    {
        public FormularioBuscarPorCampoBBDD()
        {
            InitializeComponent();
            Activated += (_, e) => this.AdaptTheme();
        }

        public string Tabla => comboTablas.Text;

        public string Campo => comboCampos.Text;

        public string CadenaBuscar => cadenaBuscar.Text;

        public bool CoincidirMayúsculasMinúsculas => coincidirMayúsculasMinúsculas.Checked;

        public bool SóloPalabrasCompletas => sóloPalabrasCompletas.Checked;

        private void botónRefrescar_Click(object sender, EventArgs e)
        {
            comboTablas.DataSource = Digi21.DigiNG.DigiNG.DigiTab.Tables.Keys.ToList();
        }

        private void comboTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var campos = from campo in Digi21.DigiNG.DigiNG.DigiTab.Tables[comboTablas.Text]
                         select campo.Item1;
            comboCampos.DataSource = campos.ToList();
        }

    }
}
