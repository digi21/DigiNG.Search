using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin.Search;
using Digi21.Utilities;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarTextosPorCódigoYCadenaName")]
    public class BuscarTextosPorCódigoYCadena : ISearcher
    {
        private readonly FormularioPideCódigoYCadena _form = new FormularioPideCódigoYCadena();
        public Form Form => _form;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            if (_form.CoincidirMayúsculasMinúsculas && _form.SóloPalabrasCompletas)
                return from texto in entities.QueTenganElCódigoConComodín(_form.Código).OfType<ReadOnlyText>()
                       where texto.Txt == _form.CadenaBuscar
                       select texto;

            if (_form.CoincidirMayúsculasMinúsculas)
                return from texto in entities.QueTenganElCódigoConComodín(_form.Código).OfType<ReadOnlyText>()
                       where texto.Txt.Contains(_form.CadenaBuscar)
                       select texto;

            if (_form.SóloPalabrasCompletas)
                return from texto in entities.QueTenganElCódigoConComodín(_form.Código).OfType<ReadOnlyText>()
                       where string.Equals(texto.Txt, _form.CadenaBuscar, StringComparison.CurrentCultureIgnoreCase)
                       select texto;

            return from texto in entities.QueTenganElCódigoConComodín(_form.Código).OfType<ReadOnlyText>()
                   where texto.Txt.ToUpper().Contains(_form.CadenaBuscar.ToUpper())
                   select texto;
        }
    }
}
