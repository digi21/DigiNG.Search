using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Entities;
using UtilidadesDigi;

namespace Buscadores
{
    [Searcher(Title = "Textos por código y cadena")]
    public class BuscarTextosPorCódigoYCadena : ISearcher
    {
        FormularioPideCódigoYCadena form = new FormularioPideCódigoYCadena();

        public Form Form
        {
            get { return form; }
        }

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            if (form.CoincidirMayúsculasMinúsculas && form.SóloPalabrasCompletas)
                return from texto in entities.QueTenganElCódigoConComodín(form.Código).SoloTextos()
                       where texto.Txt == form.CadenaBuscar
                       select texto;

            if (form.CoincidirMayúsculasMinúsculas)
                return from texto in entities.QueTenganElCódigoConComodín(form.Código).SoloTextos()
                       where texto.Txt.Contains(form.CadenaBuscar)
                       select texto;

            if (form.SóloPalabrasCompletas)
                return from texto in entities.QueTenganElCódigoConComodín(form.Código).SoloTextos()
                       where texto.Txt.ToUpper() == form.CadenaBuscar.ToUpper()
                       select texto;

            return from texto in entities.QueTenganElCódigoConComodín(form.Código).SoloTextos()
                   where texto.Txt.ToUpper().Contains(form.CadenaBuscar.ToUpper())
                   select texto;
        }
    }
}
