using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Digi21Search
{
    public partial class FormularioPideCódigoYCadena : Form
    {
        public FormularioPideCódigoYCadena()
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
    }
}
