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
            List<Entity> localizados = new List<Entity>();
            foreach (var entidad in entities)
            {
                var atributos = Digi21.DigiNG.DigiNG.DrawingFile.GetDatabaseAttributes(entidad);

                foreach(var código in atributos.Keys) {
                    var atributosDelCódigo = atributos[código];
                    if (!atributos[código].Keys.Contains(formulario.Campo)) continue;
                    if (atributosDelCódigo[formulario.Campo] != null) continue;
                    localizados.Add(entidad);
                    break;
                }
                    
            }

            return localizados;
        }
    }
}
