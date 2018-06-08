using System;
using System.Collections.Generic;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Entities;
using Digi21Search;

namespace Digi21.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarTodasLasEntidadesName")]
    public class BuscarTodasLasEntidades : ISearcher
    {
        public System.Windows.Forms.Form Form => throw new NotImplementedException();

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities) => entities;
    }
}
