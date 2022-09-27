using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Receta
    {
        public int numReceta { get; set; }
        public string nombre { get; set; }
        public int TipoReceta { get; set; }
        public string Chef { get; set; }
        public List<DetalleReceta> ldetalles = new List<DetalleReceta>();

        public void AgregarDetalle(DetalleReceta d)
        {
            ldetalles.Add(d);
        }

        public void QuitarDetalle(int pos)
        {
            ldetalles.RemoveAt(pos);
        }

        public Receta()
        {
            numReceta = 0;
            nombre = string.Empty;
            TipoReceta = 0;
            Chef = string.Empty;
        }
    }
}
