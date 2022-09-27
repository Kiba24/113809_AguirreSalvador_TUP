using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetasSLN.datos.Implementaciones;
using RecetasSLN.datos.Interfaces ;
using RecetasSLN.Servicios.Interfaces;
using RecetasSLN.dominio;


namespace RecetasSLN.Servicios.Implementaciones
{

    internal class RecetaServiceIMP : IRecetaService
    {
        private IRecetaDAO _recetaDAO;

        public RecetaServiceIMP()
        {
            _recetaDAO = new RecetaDAO();
        }

        public bool NuevaReceta(Receta r)
        {
            return _recetaDAO.GetNuevaReceta(r);
        }

        public int ProximaReceta()
        {
            return _recetaDAO.GetProximaReceta();
        }
    }
}
