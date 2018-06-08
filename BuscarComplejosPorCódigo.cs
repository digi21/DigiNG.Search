using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Entities;
using Digi21.Utilities;
using Digi21Search;

namespace Digi21.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarComplejosPorCódigoName")]
    public class BuscarComplejosPorCódigo : ISearcher
    {
        private readonly FormularioPideCódigo form = new FormularioPideCódigo();
        public Form Form => form;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities) => entities.OfType<ReadOnlyComplex>().QueTenganElCódigoConComodín(form.Código);
    }
}
