using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin.Search;
using Digi21.Utilities;

namespace DigiNG.Search
{
    [Searcher(Title = "Buscar por atributos de BBDD")]
    public class BuscarPorCampoBBDD : ISearcher
    {
        private readonly FormularioBuscarPorCampoBBDD _form = new FormularioBuscarPorCampoBBDD();

        public Form Form => _form;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            // Obtenemos los códigos que apuntan a esa tabla
            var códigos = (from código in Digi21.DigiNG.DigiNG.DigiTab.Codes
                          where 0 == string.CompareOrdinal(_form.Tabla, código.Table)
                          select código.Name).ToList();

            var candidatos = from entidad in entities
                             let códigosComunes = entidad.CódigosComunes(códigos).ToList()
                             where códigosComunes.Count > 0
                             let atributos = Digi21.DigiNG.DigiNG.DrawingFile.GetDatabaseAttributes(entidad)
                             where atributos != null
                             where atributos.ContainsKey(códigosComunes[0])
                             let atributosCódigo = atributos[códigosComunes[0]]
                             where atributosCódigo.ContainsKey(_form.Campo)
                             let atributo = atributosCódigo[_form.Campo]
                             where atributo != null
                             select new { Entidad=entidad, Atributo=atributo };

            if (_form.CoincidirMayúsculasMinúsculas && _form.SóloPalabrasCompletas)
                return from candidato in candidatos
                       let atributo = candidato.Atributo as string
                       where atributo == _form.CadenaBuscar
                       select candidato.Entidad;

            if (_form.CoincidirMayúsculasMinúsculas)
                return from candidato in candidatos
                       let atributo = candidato.Atributo as string
                       where atributo.Contains(_form.CadenaBuscar)
                       select candidato.Entidad;

            if (_form.SóloPalabrasCompletas)
                return from candidato in candidatos
                       let atributo = candidato.Atributo as string
                       where 0 == string.CompareOrdinal(atributo, _form.CadenaBuscar)
                       select candidato.Entidad;

            return from candidato in candidatos
                   let atributo = candidato.Atributo as string
                   where atributo.ToUpper().Contains(_form.CadenaBuscar.ToUpper())
                   select candidato.Entidad;
        }
    }
}
