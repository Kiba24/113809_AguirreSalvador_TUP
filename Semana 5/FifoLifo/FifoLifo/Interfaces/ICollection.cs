using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifoLifo.Interfaces
{
    internal interface ICollection
    {
        bool EstaVacia();
        object Extraer(int ultimo);
        object Primero(int ultimo);
        void Añadir(object o, int ultimo);
    }
}
