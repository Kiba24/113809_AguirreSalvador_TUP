using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1._1U2.Servicios.Interfaces;

namespace Ejercicio1._1U2.Servicios
{
    internal abstract class AbstractServiceFactory
    {
        public abstract IService CrearService();


    }
}
