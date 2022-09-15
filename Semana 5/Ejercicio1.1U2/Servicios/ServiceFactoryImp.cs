using Ejercicio1._1U2.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1._1U2.Servicios.Implementaciones;

namespace Ejercicio1._1U2.Servicios
{
    internal class ServiceFactoryImp : AbstractServiceFactory
    {
        public override IService CrearService()
        {
            return new CarreraService();
        }

        /*
        public override Producto CrearProducto()
        {
            return new Producto
        }
         * */
    }
}
