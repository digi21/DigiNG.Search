using System.Collections.Generic;
using System.Linq;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin;
using System.Windows.Forms;
using Digi21.Utilities;
using Digi21Search;

namespace Digi21.Search
{
    [Searcher(Title = "Buscar por atributos de BBDD")]
    public class BuscarPorCampoBBDD : ISearcher
    {
        private readonly FormularioBuscarPorCampoBBDD form = new FormularioBuscarPorCampoBBDD();

        public Form Form => form;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            // Obtenemos los códigos que apuntan a esa tabla
            var códigos = (from código in Digi21.DigiNG.DigiNG.DigiTab.Codes
                          where 0 == string.CompareOrdinal(form.Tabla, código.Table)
                          select código.Name).ToList();

            var candidatos = from entidad in entities
                             let códigosComunes = entidad.CódigosComunes(códigos).ToList()
                             where códigosComunes.Count > 0
                             let atributos = Digi21.DigiNG.DigiNG.DrawingFile.get_DatabaseAttributes(entidad)
                             where atributos != null
                             where atributos.ContainsKey(códigosComunes[0])
                             let atributosCódigo = atributos[códigosComunes[0]]
                             where atributosCódigo.ContainsKey(form.Campo)
                             let atributo = atributosCódigo[form.Campo]
                             where atributo != null
                             select new { Entidad=entidad, Atributo=atributo };

            if (form.CoincidirMayúsculasMinúsculas && form.SóloPalabrasCompletas)
                return from candidato in candidatos
                       let atributo = candidato.Atributo as string
                       where atributo == form.CadenaBuscar
                       select candidato.Entidad;

            if (form.CoincidirMayúsculasMinúsculas)
                return from candidato in candidatos
                       let atributo = candidato.Atributo as string
                       where atributo.Contains(form.CadenaBuscar)
                       select candidato.Entidad;

            if (form.SóloPalabrasCompletas)
                return from candidato in candidatos
                       let atributo = candidato.Atributo as string
                       where 0 == string.CompareOrdinal(atributo, form.CadenaBuscar)
                       select candidato.Entidad;

            return from candidato in candidatos
                   let atributo = candidato.Atributo as string
                   where atributo.ToUpper().Contains(form.CadenaBuscar.ToUpper())
                   select candidato.Entidad;
        }
    }
}
