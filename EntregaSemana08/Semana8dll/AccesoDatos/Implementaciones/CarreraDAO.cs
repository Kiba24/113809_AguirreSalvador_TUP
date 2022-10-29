using Semana8dll.AccesoDatos;
using Semana8dll.Dominio;
using Semana8dll.Implementaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana8dll.Interfaces
{
    internal class CarreraDAO : ICarreraDAO
    {
        public bool getBajaLogica(string procedure, int id_carrera)
        {
            return HelperSingleton.obtenerInstancia().BajaLogica(procedure, id_carrera);
        }

        public DataTable getComboCarreras(string procedure)
        {
            return HelperSingleton.obtenerInstancia().consultarDB(procedure);
        }

        public DataTable getDetalles(int id_carrera)
        {
            return HelperSingleton.obtenerInstancia().CargarDetallesCarrera(id_carrera);
        }

        public bool getNuevaAsignatura(string procedure, List<Dominio.Parametro> lparametros)
        {
            return HelperSingleton.obtenerInstancia().AgregarNuevo(procedure, lparametros);
        }

        public bool getNuevaCarrera(Carrera c)
        {
            return HelperSingleton.obtenerInstancia().NuevaCarrera(c);
        }

        public DataTable getUsuarios(string procedure)
        {
            return HelperSingleton.obtenerInstancia().consultarDB(procedure);
        }
    }
}
