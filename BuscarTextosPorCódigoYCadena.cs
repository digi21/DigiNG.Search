using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin;
using Digi21.Utilities;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarTextosPorCódigoYCadenaName")]
    public class BuscarTextosPorCódigoYCadena : ISearcher
    {
        private readonly FormularioPideCódigoYCadena form = new FormularioPideCódigoYCadena();
        public Form Form => form;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            if (form.CoincidirMayúsculasMinúsculas && form.SóloPalabrasCompletas)
                return from texto in entities.QueTenganElCódigoConComodín(form.Código).OfType<ReadOnlyText>()
                       where texto.Txt == form.CadenaBuscar
                       select texto;

            if (form.CoincidirMayúsculasMinúsculas)
                return from texto in entities.QueTenganElCódigoConComodín(form.Código).OfType<ReadOnlyText>()
                       where texto.Txt.Contains(form.CadenaBuscar)
                       select texto;

            if (form.SóloPalabrasCompletas)
                return from texto in entities.QueTenganElCódigoConComodín(form.Código).OfType<ReadOnlyText>()
                       where texto.Txt.ToUpper() == form.CadenaBuscar.ToUpper()
                       select texto;

            return from texto in entities.QueTenganElCódigoConComodín(form.Código).OfType<ReadOnlyText>()
                   where texto.Txt.ToUpper().Contains(form.CadenaBuscar.ToUpper())
                   select texto;
        }
    }
}
