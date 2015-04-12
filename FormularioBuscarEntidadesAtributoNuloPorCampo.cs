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
    public partial class FormularioBuscarEntidadesAtributoNuloPorCampo : Form
    {
        public FormularioBuscarEntidadesAtributoNuloPorCampo()
        {
            InitializeComponent();
        }


        public string Campo
        {
            get
            {
                return campo.Text;
            }
        }

    }
}
