using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Topology;
using Digi21.Utilities;
using Digi21.DigiNG.Entities;

namespace Buscadores
{
    [LocalizableSearcher(typeof(MyResource), "BuscarLineasCruzanConLineasName")]
    public class BuscarLineasCruzanConLineas : ISearcher
    {
        private FormularioBuscarLíneasQueCruzanConOtrasLíneas formulario = new FormularioBuscarLíneasQueCruzanConOtrasLíneas();

        public System.Windows.Forms.Form Form
        {
            get { return formulario; }
        }

        public IEnumerable<Digi21.DigiNG.Entities.Entity> Search(IEnumerable<Entity> entities)
        {
            IEnumerable<string> códigosPrincipales = formulario.CódigosPrincipales;
            IEnumerable<string> códigosSecundarios = formulario.CódigosSecundarios;
            IEnumerable<string> todosLosCódigos = formulario.TodosLosCódigos;

            var líneasABuscar = entities.QueTenganAlgúnCódigoConComodín(todosLosCódigos).OfType<ReadOnlyLine>();

            var intersecciones = líneasABuscar.DetectIntersections(
                (líneaA, líneaB) => 
                    (líneaA.TieneAlgúnCódigoConComodín(códigosPrincipales) && líneaB.TieneAlgúnCódigoConComodín(códigosSecundarios)) ||
                    (líneaA.TieneAlgúnCódigoConComodín(códigosSecundarios) && líneaB.TieneAlgúnCódigoConComodín(códigosPrincipales)));

            var líneasLocalizadas = from intersección in intersecciones
                                    from segmento in intersección
                                    where segmento.Line.TieneAlgúnCódigoConComodín(códigosPrincipales)
                                    select segmento.Line;
            return líneasLocalizadas.Distinct();
        }
    }
}
