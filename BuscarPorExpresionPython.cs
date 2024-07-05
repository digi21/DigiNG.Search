using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin.Search;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarExpresionPython")]
    public class BuscarPorExpresionPython : ISearcher, IDisposable
    {
        private readonly FormularioExpresionPython _form = new();
        public Form Form => _form;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            return Digi21.DigiNG.DigiNG.SelectByPythonExpression(entities, _form.Expresion.Text);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _form.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
