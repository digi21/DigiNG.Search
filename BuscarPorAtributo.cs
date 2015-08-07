using System;
using System.Collections.Generic;
using System.Linq;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin;
using System.Windows.Forms;

namespace BuscarAtributos
{
    [Searcher(Title = "Buscar por atributos")]
    public class BuscarPorAtributos : ISearcher
    {
        public Form Form
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            return from entidad in entities
                   let atributos = Digi21.DigiNG.DigiNG.DrawingFile.get_DatabaseAttributes(entidad)
                   where atributos != null
                   where atributos.ContainsKey(entidad.Codes[0].Name)
                   let atributosCódigo = atributos[entidad.Codes[0].Name]
                   where atributosCódigo.ContainsKey("TMT_PROPIE")
                   where atributosCódigo.ContainsKey("TMT_TIPO_U")
                   where !(atributosCódigo["TMT_PROPIE"] as string == "E" && atributosCódigo["TMT_TIPO_U"] as string == "AER")
                   select entidad;
        }
    }
}
