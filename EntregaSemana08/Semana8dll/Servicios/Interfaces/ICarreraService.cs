using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Semana8dll.Dominio;

namespace Semana8dll.Servicios.Interfaces
{
    public interface ICarreraService
    {
        public bool NuevaCarrera(Carrera c);
        public DataTable Detalles(int id_carrera);
        public bool BajaLogica(string procedure, int id_carrera);
        public DataTable querySQL(string procedure);
        public bool NuevaAsignatura(string procedure, List<Parametro> lparametros);
        public DataTable getUsuarios(string procedure);
    }
}
