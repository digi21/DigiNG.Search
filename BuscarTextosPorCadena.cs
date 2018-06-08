using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarTextosPorCadenaName")]
    public class BuscarTextosPorCadena : ISearcher
    {
        private readonly FormularioPideCadena form = new FormularioPideCadena();
        public Form Form => form;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            if( form.CoincidirMayúsculasMinúsculas && form.SóloPalabrasCompletas )
                return from texto in entities.OfType<ReadOnlyText>().OfType<ReadOnlyText>()
                       where texto.Txt == form.CadenaBuscar
                        select texto;

            if( form.CoincidirMayúsculasMinúsculas )
                return from texto in entities.OfType<ReadOnlyText>()
                       where texto.Txt.Contains(form.CadenaBuscar)
                       select texto;

            if( form.SóloPalabrasCompletas )
                return from texto in entities.OfType<ReadOnlyText>()
                       where texto.Txt.ToUpper() == form.CadenaBuscar.ToUpper()
                       select texto;

            return from texto in entities.OfType<ReadOnlyText>()
                   where texto.Txt.ToUpper().Contains(form.CadenaBuscar.ToUpper())
                   select texto;
        }
    }
}
