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
    public partial class FormularioBuscarLíneasCriterio : Form
    {
        public FormularioBuscarLíneasCriterio()
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

        public bool QueEsténCerradas
        {
            get
            {
                return queEsténCerradas.Checked;
            }
        }
    }
}
