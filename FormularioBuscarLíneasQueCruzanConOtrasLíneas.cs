using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiNG.Search
{
    public partial class FormularioBuscarLíneasQueCruzanConOtrasLíneas : Form
    {
        public FormularioBuscarLíneasQueCruzanConOtrasLíneas()
        {
            InitializeComponent();
        }

        private void botónBuscarCódigosPrincipales_Click(object sender, EventArgs e)
        {
            var códigos = Digi21.DigiNG.DigiNG.Codes.DlgSelectCodes("Selecciona el código o códigos de las líneas principales", true);

            if (0 == códigos.Length)
                return;

            códigosLíneasPrincipales.Text = "";
            foreach (var código in códigos)
                códigosLíneasPrincipales.Text += código.Name + "\r\n";
        }

        private void botónBuscarCódigosSecundarios_Click(object sender, EventArgs e)
        {
            var códigos = Digi21.DigiNG.DigiNG.Codes.DlgSelectCodes("Selecciona el código o códigos de las líneas secundarias", true);

            if (0 == códigos.Length)
                return;

            códigosLíneasSecundarias.Text = "";
            foreach (var código in códigos)
                códigosLíneasSecundarias.Text += código.Name + "\r\n";
        }

        public IEnumerable<string> CódigosPrincipales
        {
            get
            {
                List<string> códigos = new List<string>();
                códigos.AddRange(códigosLíneasPrincipales.Text.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries).Where(código => código.Length > 0));
                return códigos;
            }
        }

        public IEnumerable<string> CódigosSecundarios
        {
            get {
                List<string> códigos = new List<string>();
                códigos.AddRange(códigosLíneasSecundarias.Text.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries).Where(código => código.Length > 0));
                return códigos;
            }
        }

        public IEnumerable<string> TodosLosCódigos
        {
            get
            {
                List<string> códigosPrincipales = new List<string>(this.CódigosPrincipales);
                List<string> todosLosCódigos = new List<string>();
                todosLosCódigos.AddRange(códigosPrincipales);
                todosLosCódigos.AddRange(this.CódigosSecundarios);

                return todosLosCódigos.Distinct();
            }
        }

    }
}
