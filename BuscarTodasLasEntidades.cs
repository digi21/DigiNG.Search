using System;
using System.Collections.Generic;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin.Search;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarTodasLasEntidadesName")]
    public class BuscarTodasLasEntidades : ISearcher
    {
        public System.Windows.Forms.Form Form => null;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities) => entities;
    }
}
