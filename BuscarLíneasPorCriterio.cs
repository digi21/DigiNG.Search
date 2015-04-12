using System.Collections.Generic;
using Digi21.DigiNG.Plugin;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.Utilities;
using System.Linq;

namespace Buscadores
{
    [LocalizableSearcher(typeof(MyResource), "BuscarLíneasPorCriterioName")]
    public class BuscarLíneasPorCriterio : ISearcher
    {
        FormularioBuscarLíneasCriterio form = new FormularioBuscarLíneasCriterio();

        public Form Form
        {
            get { return form; }
        }

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            if (form.QueEsténCerradas)
            {
                var consulta = from entidad in entities
                               where entidad is ReadOnlyLine
                               let línea = entidad as ReadOnlyLine
                               where línea.Closed
                               select entidad;
                return consulta;
            }
            
            return entities.OfType<ReadOnlyLine>().QueTenganElCódigoConComodín(form.Código);
        }
    }
}
