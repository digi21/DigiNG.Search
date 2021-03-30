using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DigiNG.Search.ExtensionMethods;

namespace DigiNG.Search
{
    public partial class FormularioBuscarLíneasQueCruzanConOtrasLíneas : Form
    {
        public FormularioBuscarLíneasQueCruzanConOtrasLíneas()
        {
            InitializeComponent();
            Activated += (_, e) => this.AdaptTheme();
        }

        private void botónBuscarCódigosPrincipales_Click(object sender, EventArgs e)
        {
            var códigos = Digi21.DigiNG.DigiNG.Codes.DlgSelectCodes(MyResource.SeleccionaCodigoLineasPrincipales, true);

            if (0 == códigos.Length)
                return;

            códigosLíneasPrincipales.Text = string.Empty;
            foreach (var código in códigos)
                códigosLíneasPrincipales.Text += código.Name + MyResource.SaltoLinea;
        }

        private void botónBuscarCódigosSecundarios_Click(object sender, EventArgs e)
        {
            var códigos = Digi21.DigiNG.DigiNG.Codes.DlgSelectCodes(MyResource.SeleccionaCodigoLineasSecundarias, true);

            if (0 == códigos.Length)
                return;

            códigosLíneasSecundarias.Text = "";
            foreach (var código in códigos)
                códigosLíneasSecundarias.Text += código.Name + MyResource.SaltoLinea;
        }

        public IEnumerable<string> CódigosPrincipales
        {
            get
            {
                var códigos = new List<string>();
                códigos.AddRange(códigosLíneasPrincipales.Text.Split(new[] { MyResource.SaltoLinea }, StringSplitOptions.RemoveEmptyEntries).Where(código => código.Length > 0));
                return códigos;
            }
        }

        public IEnumerable<string> CódigosSecundarios
        {
            get {
                var códigos = new List<string>();
                códigos.AddRange(códigosLíneasSecundarias.Text.Split(new[] { MyResource.SaltoLinea }, StringSplitOptions.RemoveEmptyEntries).Where(código => código.Length > 0));
                return códigos;
            }
        }

        public IEnumerable<string> TodosLosCódigos
        {
            get
            {
                var códigosPrincipales = new List<string>(this.CódigosPrincipales);
                var todosLosCódigos = new List<string>();
                todosLosCódigos.AddRange(códigosPrincipales);
                todosLosCódigos.AddRange(this.CódigosSecundarios);

                return todosLosCódigos.Distinct();
            }
        }

    }
}
