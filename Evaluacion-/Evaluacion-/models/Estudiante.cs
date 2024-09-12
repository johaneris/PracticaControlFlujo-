using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_.models
{
    internal class Estudiante
    {
        private string[] estudiantes = new string[25];

        public void AddElement(string nombreCompleto, int pos)
        {
            estudiantes[pos] = nombreCompleto;
        }

        public string[] GetElements()
        {
            return estudiantes;
        }
    }
}
