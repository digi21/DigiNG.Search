using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin.Search;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarTextosPorCadenaName")]
    public class BuscarTextosPorCadena : ISearcher
    {
        private readonly FormularioPideCadena _form = new FormularioPideCadena();
        public Form Form => _form;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            if( _form.CoincidirMayúsculasMinúsculas && _form.SóloPalabrasCompletas )
                return from texto in entities.OfType<ReadOnlyText>()
                       where texto.Txt == _form.CadenaBuscar
                        select texto;

            if( _form.CoincidirMayúsculasMinúsculas )
                return from texto in entities.OfType<ReadOnlyText>()
                       where texto.Txt.Contains(_form.CadenaBuscar)
                       select texto;

            if( _form.SóloPalabrasCompletas )
                return from texto in entities.OfType<ReadOnlyText>()
                       where string.Equals(texto.Txt, _form.CadenaBuscar, StringComparison.CurrentCultureIgnoreCase)
                       select texto;

            return from texto in entities.OfType<ReadOnlyText>()
                   where texto.Txt.ToUpper().Contains(_form.CadenaBuscar.ToUpper())
                   select texto;
        }
    }
}
