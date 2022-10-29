using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Semana8dll.Dominio;

namespace Semana8dll.Implementaciones
{
    internal interface ICarreraDAO
    {
        public bool getNuevaCarrera(Carrera c);
        public DataTable getDetalles(int id_carrera);
        public bool getBajaLogica(string procedure, int id_carrera);
        public DataTable getComboCarreras(string procedure);
        public bool getNuevaAsignatura(string procedure, List<Parametro> lparametros);
        public DataTable getUsuarios(string procedure);
    }
}
