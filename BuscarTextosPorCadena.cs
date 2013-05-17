using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Entities;
using Digi21.Utilities;

namespace Buscadores
{
    [Searcher(Title = "Textos por cadena")]
    public class BuscarTextosPorCadena : ISearcher
    {
        FormularioPideCadena form = new FormularioPideCadena();

        public Form Form
        {
            get { return form; }
        }

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            if( form.CoincidirMayúsculasMinúsculas && form.SóloPalabrasCompletas )
                return from texto in entities.SoloTextos()
                       where texto.Txt == form.CadenaBuscar
                        select texto;

            if( form.CoincidirMayúsculasMinúsculas )
                return from texto in entities.SoloTextos()
                       where texto.Txt.Contains(form.CadenaBuscar)
                       select texto;

            if( form.SóloPalabrasCompletas )
                return from texto in entities.SoloTextos()
                       where texto.Txt.ToUpper() == form.CadenaBuscar.ToUpper()
                       select texto;

            return from texto in entities.SoloTextos()
                   where texto.Txt.ToUpper().Contains(form.CadenaBuscar.ToUpper())
                   select texto;
        }
    }
}
