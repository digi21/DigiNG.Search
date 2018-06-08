using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarTodosLosTextosName")]
    public class BuscarTodosLosTextos : ISearcher
    {
        public Form Form => throw new NotImplementedException();

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            return from entidad in entities
                   where entidad is ReadOnlyText
                   select entidad;
        }
    }
}
