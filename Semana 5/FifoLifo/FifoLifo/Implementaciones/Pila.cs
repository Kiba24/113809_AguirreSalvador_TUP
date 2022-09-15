using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FifoLifo.Interfaces;

namespace FifoLifo.Implementaciones 
{

    internal class Pila : ICollection
    {
        public object[] ArrayPila = new object[10];

     

        public bool EstaVacia()
        {
            if (ArrayPila.Length == 0 )
            {
                return true;
            }
            return false;
        }

        public void Añadir(object obj , int ultimo)
        {
            ArrayPila[ultimo] = obj;
            ultimo++;
        }

        public object Extraer(int ultimo)
        {
            object tempUltimo = ArrayPila[ultimo];
            ArrayPila[ultimo] = null;
            return tempUltimo;
        }

        public object Primero(int ultimo)
        {
            return ArrayPila[ultimo];
        }


    }
}
