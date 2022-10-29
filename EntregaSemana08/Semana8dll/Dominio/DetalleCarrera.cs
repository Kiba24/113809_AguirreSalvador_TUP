using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana8dll.Dominio
{
    public class DetalleCarrera
    {
        public int id { get; set; }
        public int aniocursado { get; set; }
        public int cuatrimestre { get; set; }
        public Asignatura asignatura { set; get; }
        public string estado { get; set; }
        
       
       

        public DetalleCarrera(int acursado, int cuatri, Asignatura asignatura, string estado)
        {

            this.aniocursado = acursado;
            this.cuatrimestre = cuatri;
            this.asignatura = asignatura;
            this.estado = estado;
            
        }

        public DetalleCarrera()
        {
            estado = "A";
            aniocursado = 2000;
            cuatrimestre = 1;

            
        }

        public override string ToString()
        {
            return " Anio Cursado: " + aniocursado + " cuatrimestre: " + cuatrimestre
               + " asignatura : " + asignatura.nombre.ToString();      
        }

    }
}
