using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana8dll.Dominio
{
    public class Asignatura
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
