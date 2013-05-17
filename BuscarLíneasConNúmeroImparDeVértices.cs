using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Digi21.DigiNG.Plugin;
using Digi21.DigiNG.Entities;
using Digi21.Utilities;

namespace Buscadores
{
    // He hecho la clase internal para que no aparezca
    [Searcher(Title = "Líneas con un número impar de vértices")]
    internal class BuscarLíneasConNúmeroImparDeVértices : ISearcher
    {
        public System.Windows.Forms.Form Form
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            List<Entity> listaEntidades = new List<Entity>(entities);
            List<Entity> entidadesSeleccionadas = new List<Entity>();

            for (int i = 0; i < listaEntidades.Count; i++)
            {
                ReadOnlyLine línea = listaEntidades[i] as ReadOnlyLine;
                if (línea == null)
                    continue;

                if (línea.Points.Count % 2 == 1)
                    entidadesSeleccionadas.Add(línea);
            }

            return entidadesSeleccionadas;
            //return from línea in entities.SoloLíneas()
            //       where línea.Points.Count % 2 == 1
            //       select línea;
        }
    }
}
