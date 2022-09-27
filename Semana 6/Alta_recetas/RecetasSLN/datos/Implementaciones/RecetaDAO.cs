using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RecetasSLN.datos.Interfaces;
using RecetasSLN.dominio;
using System.Threading.Tasks;
using RecetasSLN.datos;

namespace RecetasSLN.datos.Implementaciones
{
    internal class RecetaDAO : IRecetaDAO //hereda de la interfaz 
    {

        public bool GetNuevaReceta(Receta R)
        {
            return helperDAO.ObtenerInstancia().AltaReceta(R);
        }

        public int GetProximaReceta()
        {
            return helperDAO.ObtenerInstancia().SParametroSalida("@proximo","SP_Consultar_Proximo");
        }
    }
}
