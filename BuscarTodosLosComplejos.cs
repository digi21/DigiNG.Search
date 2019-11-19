using System;
using System.Collections.Generic;
using System.Linq;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin.Search;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarTodosLosComplejosName")]
    public class BuscarTodosLosComplejos : ISearcher
    {
        public System.Windows.Forms.Form Form => throw new NotImplementedException();

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities) => entities.OfType<ReadOnlyComplex>();
    }
}
