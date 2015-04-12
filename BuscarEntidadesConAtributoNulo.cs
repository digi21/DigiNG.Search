using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Entities;

namespace Buscadores
{
    [LocalizableSearcher(typeof(MyResource), "BuscarEntidadesConAtributoNuloName")]
    public class BuscarEntidadesConAtributoNulo : ISearcher
    {
        FormularioBuscarEntidadesAtributoNulo formulario = new FormularioBuscarEntidadesAtributoNulo();

        public System.Windows.Forms.Form Form
        {
            get { return formulario; }
        }

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            var camposAExcluir = formulario.CamposExcluir;

            List<Entity> localizados = new List<Entity>();
            foreach (var entidad in entities)
            {
                var atributos = Digi21.DigiNG.DigiNG.DrawingFile.get_DatabaseAttributes(entidad);

                bool localizado = false;
                foreach(var código in atributos.Keys) {
                    var atributosDelCódigo = atributos[código];

                    foreach (var atributo in atributosDelCódigo )
                    {
                        if(!camposAExcluir.Contains(atributo.Key) && atributo.Value == null ) {
                            localizados.Add(entidad);
                            break;
                        }
                    }

                    if( localizado)
                        break;
                }
                    
            }

            return localizados;
        }
    }
}
