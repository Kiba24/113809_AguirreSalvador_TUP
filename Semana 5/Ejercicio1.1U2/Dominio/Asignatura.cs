using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._1U2
{
    internal class Asignatura
    {
        public int id_asignatura { get; set; }
        public string nombre { get; set; }

        public Asignatura(string nombre)
        {
            this.nombre = nombre;
        }

        public Asignatura()
        {
            nombre = String.Empty;
        }

    }
}
