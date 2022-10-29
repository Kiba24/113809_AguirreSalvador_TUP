using Semana8dll.Dominio;
using Semana8dll.Implementaciones;
using Semana8dll.Interfaces;
using Semana8dll.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semana8dll.Servicios.Implementaciones
{
    public class CarreraService : ICarreraService
    {

        private ICarreraDAO carreraDAO;

        public CarreraService()
        {
            carreraDAO = new CarreraDAO();
        }

        public bool BajaLogica(string procedure, int id_carrera)
        {
            return carreraDAO.getBajaLogica(procedure,id_carrera);
        }

        public DataTable Detalles(int id_carrera)
        {
            return carreraDAO.getDetalles(id_carrera);
        }

        public DataTable getUsuarios(string procedure)
        {
            return carreraDAO.getUsuarios(procedure);
        }

        public bool NuevaAsignatura(string procedure, List<Parametro> lparametros)
        {
            return carreraDAO.getNuevaAsignatura(procedure, lparametros);
        }

        public bool NuevaCarrera(Carrera c)
        {
            return carreraDAO.getNuevaCarrera(c);
        }

        public DataTable querySQL(string procedure)
        {
            return carreraDAO.getComboCarreras(procedure);
        }
    }
}
