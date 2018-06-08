using System;
using System.Collections.Generic;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarLíneasConNúmeroImparDeVérticesName")]
    internal class BuscarLíneasConNúmeroImparDeVértices : ISearcher
    {
        public System.Windows.Forms.Form Form => throw new NotImplementedException();

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            var listaEntidades = new List<Entity>(entities);
            var entidadesSeleccionadas = new List<Entity>();

            foreach (var entidad in listaEntidades)
            {
                if (!(entidad is ReadOnlyLine línea))
                    continue;

                if (línea.Points.Count % 2 == 1)
                    entidadesSeleccionadas.Add(línea);
            }

            return entidadesSeleccionadas;
        }
    }
}
