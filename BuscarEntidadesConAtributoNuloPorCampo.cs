using System.Collections.Generic;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin.Search;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarEntidadesConAtributoNuloPorCampoName")]
    public class BuscarEntidadesConAtributoNuloPorCampo : ISearcher
    {
        private readonly FormularioBuscarEntidadesAtributoNuloPorCampo formulario = new FormularioBuscarEntidadesAtributoNuloPorCampo();
        public Form Form => formulario;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            var localizados = new List<Entity>();
            foreach (var entidad in entities)
            {
                foreach(var código in entidad.Codes) {
                    var atributosDelCódigo = código.Attributes;
                    if (!atributosDelCódigo.Keys.Contains(formulario.Campo)) continue;
                    if (atributosDelCódigo[formulario.Campo] != null) continue;
                    localizados.Add(entidad);
                    break;
                }
                    
            }

            return localizados;
        }
    }
}
