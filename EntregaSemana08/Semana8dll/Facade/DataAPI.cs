using Semana8dll.Dominio;
using Semana8dll.Implementaciones;
using Semana8dll.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semana8dll.Facade
{
    public class DataAPI : IDataAPI
    {
        private ICarreraDAO dao;

        public DataAPI()
        {
            dao = new CarreraDAO();
        }

        public DataTable getCarreras(string procedure)
        {
            return dao.getComboCarreras(procedure);
        }

        public DataTable getDetalles(int id)
        {
            return dao.getDetalles(id);
        }

        public DataTable getUsuarios(string procedure)
        {
            return dao.getUsuarios(procedure);
        }

        public bool NuevaCarrera(Carrera c)
        {
            return dao.getNuevaCarrera(c);
        }


    }
}
