using System.Collections.Generic;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin;
using Digi21.Utilities;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarTodasLasEntidadesPorCodigoName")]
    public class BuscarTodasLasEntidadesPorCodigo : ISearcher
    {
        private readonly FormularioPideCódigo form = new FormularioPideCódigo();
        public Form Form => form;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities) => entities.QueTenganElCódigoConComodín(form.Código);
    }
}
