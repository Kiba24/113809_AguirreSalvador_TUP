using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Semana8dll.Dominio;

namespace Semana8dll.Facade
{
    public interface IDataAPI
    {
        public DataTable getCarreras(string procedure);
        public DataTable getDetalles(int id);
        public bool NuevaCarrera(Carrera c);
        public DataTable getUsuarios(string procedure);
    }
}
