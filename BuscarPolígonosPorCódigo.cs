using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin.Search;
using Digi21.Utilities;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarPolígonosPorCódigoName")]
    public class BuscarPolígonosPorCódigo : ISearcher, IDisposable
    {
        private readonly FormularioPideCódigo _form = new();
        public Form Form => _form;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities) => entities.OfType<ReadOnlyPolygon>().QueTenganElCódigoConComodín(_form.Código);

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _form?.Dispose();
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
