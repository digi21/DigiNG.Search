using System;
using System.Collections.Generic;
using System.Linq;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin;
using System.Windows.Forms;
using Buscadores;

namespace BuscarAtributos
{
    public static class Jander
    {
        public static IEnumerable<string> CódigosComunes(this Entity entidad, IEnumerable<string> códigos)
        {
            var lista = new List<string>();

            foreach (Code código in entidad.Codes)
                foreach (string cod in códigos)
                    if (Code.Compare(código.Name, cod))
                        if (!lista.Contains(cod))
                            lista.Add(cod);
            return lista;
        }
    }

    [Searcher(Title = "Buscar por atributos de BBDD")]
    public class BuscarPorCampoBBDD : ISearcher
    {
        private FormularioBuscarPorCampoBBDD form = new FormularioBuscarPorCampoBBDD();

        public Form Form
        {
            get { return form; }
        }

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            // Obtenemos los códigos que apuntan a esa tabla
            var códigos = (from código in Digi21.DigiNG.DigiNG.DigiTab.Codes
                          where 0 == string.Compare(form.Tabla, código.Table)
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
                       where 0 == string.Compare(atributo, form.CadenaBuscar)
                       select candidato.Entidad;

            return from candidato in candidatos
                   let atributo = candidato.Atributo as string
                   where atributo.ToUpper().Contains(form.CadenaBuscar.ToUpper())
                   select candidato.Entidad;
        }
    }
}
