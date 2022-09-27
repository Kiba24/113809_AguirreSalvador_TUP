using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    internal class Parametro
    {
        public object value { get; set; }
        public string nombre { get; set; }

        public Parametro()
        {
            value = 0;
            nombre = String.Empty;
        }

        public Parametro(object value, string nombre)
        {
            this.value = value;
            this.nombre = nombre;
        }
    }
}
