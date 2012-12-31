using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Entities;
using UtilidadesDigi;

namespace Buscadores
{
    [Searcher(Title = "Todas las líneas por código")]
    public class BuscarLíneasPorCódigo : ISearcher
    {
        FormularioPideCódigo form = new FormularioPideCódigo();

        public Form Form
        {
            get { return form; }
        }

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            return entities.SoloLíneas().QueTenganElCódigoConComodín(form.Código);
        }
    }
}
