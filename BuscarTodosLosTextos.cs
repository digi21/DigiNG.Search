using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Entities;

namespace Buscadores
{
    [Searcher(Title="Todos los textos")]
    public class BuscarTodosLosTextos : ISearcher
    {
        public Form Form
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            return from entidad in entities
                   where entidad is ReadOnlyText
                   select entidad;
        }
    }
}
