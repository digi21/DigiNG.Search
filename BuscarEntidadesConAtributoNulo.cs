using System;
using System.Collections.Generic;
using System.Linq;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin.Search;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarEntidadesConAtributoNuloName")]
    public class BuscarEntidadesConAtributoNulo : ISearcher, IDisposable
    {
        private readonly FormularioBuscarEntidadesAtributoNulo _formulario = new();
        public System.Windows.Forms.Form Form => _formulario;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            var camposAExcluir = _formulario.CamposExcluir;

            var localizados = new List<Entity>();
            foreach (var entidad in entities)
            {
                foreach (var code in entidad.Codes)
                {
                    if (code.Attributes.Any(atributo => !camposAExcluir.Contains(atributo.Key) && atributo.Value == null))
                    {
                        localizados.Add(entidad);
                        break;
                    }
                }
            }

            return localizados;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _formulario?.Dispose();
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
