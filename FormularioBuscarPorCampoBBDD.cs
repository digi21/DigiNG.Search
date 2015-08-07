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
    public partial class FormularioBuscarPorCampoBBDD : Form
    {
        public FormularioBuscarPorCampoBBDD()
        {
            InitializeComponent();
        }

        public string Tabla
        {
            get
            {
                return comboTablas.Text;
            }
        }

        public string Campo
        {
            get
            {
                return comboCampos.Text;
            }
        }

        public string CadenaBuscar
        {
            get
            {
                return cadenaBuscar.Text;
            }
        }

        public bool CoincidirMayúsculasMinúsculas
        {
            get
            {
                return coincidirMayúsculasMinúsculas.Checked;
            }
        }

        public bool SóloPalabrasCompletas
        {
            get
            {
                return sóloPalabrasCompletas.Checked;
            }
        }

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
