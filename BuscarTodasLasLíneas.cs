using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin.Search;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarTodasLasLíneasName")]
    public class BuscarTodasLasLíneas : ISearcher
    {
        public Form Form => throw new NotImplementedException();

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            return from entidad in entities
                   where entidad is ReadOnlyLine
                   select entidad;
        }
    }
}
