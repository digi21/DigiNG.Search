using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Entities;
using Digi21.Utilities;

namespace Buscadores
{
    [Searcher(Title = "Todas las entidades")]
    public class BuscarTodasLasEntidades : ISearcher
    {
        public System.Windows.Forms.Form Form
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            return entities;
        }
    }
}
