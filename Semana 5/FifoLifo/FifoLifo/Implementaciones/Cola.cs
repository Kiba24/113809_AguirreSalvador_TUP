using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FifoLifo.Interfaces;

namespace FifoLifo.Implementaciones
{
    internal class Cola : ICollection
    {
        List<object> ListCola = new List<object>();

        public bool EstaVacia()
        {
            if (ListCola.Count == 0)
            {
                return true;
            }

            return false;
        }

        public object Extraer(int ultimo)
        {
            object tempObj = ListCola[ultimo];
            ListCola.RemoveAt(0);
            return tempObj;
        }

        public object Primero(int n)
        {
            return ListCola[0];
        }

        public void Añadir(object o, int ultimo)
        {
            ListCola.Add(o);
        }
    }
}
