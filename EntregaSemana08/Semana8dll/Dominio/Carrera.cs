using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana8dll.Dominio
{
    public class Carrera
    {
        public int id { set; get; } //Solo lo traigo
        public string nombre { set; get; }

        public List<DetalleCarrera> ldetalles { set; get; } = new List<DetalleCarrera>();


        public void AgregarDetalle(DetalleCarrera d)
        {
            ldetalles.Add(d);
        }


        public void QuitarDetalle(int pos)
        {
            ldetalles.RemoveAt(pos);
        }

        public string mostrarCarrera()
        {
            return "Carrera: " + nombre;
        }
    }
}
