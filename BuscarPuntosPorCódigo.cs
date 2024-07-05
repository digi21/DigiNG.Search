using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin.Search;
using Digi21.Utilities;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarPuntosPorCódigoName")]
    public class BuscarPuntosPorCódigo : ISearcher, IDisposable
    {
        private readonly FormularioPideCódigo form = new();
        public Form Form => form;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities) => entities.OfType<ReadOnlyPoint>().QueTenganElCódigoConComodín(form.Código);

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                form?.Dispose();
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
