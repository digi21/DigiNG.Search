using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Entities;
using System.Windows.Forms;

namespace Buscadores
{
    [LocalizableSearcher(typeof(MyResource), "BuscarEntidadesConAtributoNuloPorCampoName")]
    public class BuscarEntidadesConAtributoNuloPorCampo : ISearcher
    {
        FormularioBuscarEntidadesAtributoNuloPorCampo formulario = new FormularioBuscarEntidadesAtributoNuloPorCampo();

        public Form Form
        {
            get { return formulario; }
        }

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            List<Entity> localizados = new List<Entity>();
            foreach (var entidad in entities)
            {
                var atributos = Digi21.DigiNG.DigiNG.DrawingFile.get_DatabaseAttributes(entidad);

                foreach(var código in atributos.Keys) {
                    var atributosDelCódigo = atributos[código];
                    if (atributosDelCódigo.Keys.Contains(formulario.Campo))
                    {
                        if (atributosDelCódigo[formulario.Campo] == null)
                        {
                            localizados.Add(entidad);
                            break;
                        }
                    }
                }
                    
            }

            return localizados;
        }
    }
}
