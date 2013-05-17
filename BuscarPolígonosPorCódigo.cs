using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Entities;
using Digi21.Utilities;

namespace Buscadores
{
    [Searcher(Title = "Polígonos por código")]
    public class BuscarPolígonosPorCódigo : ISearcher
    {
        FormularioPideCódigo form = new FormularioPideCódigo();

        public Form Form
        {
            get { return form; }
        }

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            return entities.SoloPolígonos().QueTenganElCódigoConComodín(form.Código);
        }
    }
}
