using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Topology;
using UtilidadesDigi;

namespace Buscadores
{
    [Searcher(Title = "Líneas que cruzan con otras líneas")]
    public class BuscarLineasCruzanConLineas : ISearcher
    {
        private FormularioBuscarLíneasQueCruzanConOtrasLíneas formulario = new FormularioBuscarLíneasQueCruzanConOtrasLíneas();

        public System.Windows.Forms.Form Form
        {
            get { return formulario; }
        }

        public IEnumerable<Digi21.DigiNG.Entities.Entity> Search(IEnumerable<Digi21.DigiNG.Entities.Entity> entities)
        {
            IEnumerable<string> códigosPrincipales = formulario.CódigosPrincipales;
            IEnumerable<string> códigosSecundarios = formulario.CódigosSecundarios;
            IEnumerable<string> todosLosCódigos = formulario.TodosLosCódigos;

            var líneasABuscar = entities.QueTenganAlgúnCódigoConComodín(todosLosCódigos).SoloLíneas();

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
