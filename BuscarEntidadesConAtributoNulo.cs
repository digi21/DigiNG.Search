using System.Collections.Generic;
using System.Linq;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin.Search;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarEntidadesConAtributoNuloName")]
    public class BuscarEntidadesConAtributoNulo : ISearcher
    {
        private readonly FormularioBuscarEntidadesAtributoNulo formulario = new FormularioBuscarEntidadesAtributoNulo();
        public System.Windows.Forms.Form Form => formulario;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            var camposAExcluir = formulario.CamposExcluir;

            var localizados = new List<Entity>();
            foreach (var entidad in entities)
            {
                var atributos = Digi21.DigiNG.DigiNG.DrawingFile.GetDatabaseAttributes(entidad);

                foreach(var código in atributos.Keys)
                {
                    if (atributos[código].Any(atributo => !camposAExcluir.Contains(atributo.Key) && atributo.Value == null))
                        localizados.Add(entidad);
                }
                    
            }

            return localizados;
        }
    }
}
