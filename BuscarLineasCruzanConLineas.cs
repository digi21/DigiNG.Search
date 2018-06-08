using System.Collections.Generic;
using System.Linq;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Topology;
using Digi21.Utilities;
using Digi21.DigiNG.Entities;
using Digi21Search;

namespace Digi21.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarLineasCruzanConLineasName")]
    public class BuscarLineasCruzanConLineas : ISearcher
    {
        private readonly FormularioBuscarLíneasQueCruzanConOtrasLíneas formulario = new FormularioBuscarLíneasQueCruzanConOtrasLíneas();
        public System.Windows.Forms.Form Form => formulario;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            var códigosPrincipales = formulario.CódigosPrincipales.ToList();
            var códigosSecundarios = formulario.CódigosSecundarios.ToList();
            var todosLosCódigos = formulario.TodosLosCódigos;

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
