using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetasSLN.dominio;

namespace RecetasSLN.Servicios.Interfaces
{
    internal interface IRecetaService
    {
        bool NuevaReceta(Receta r);
        int ProximaReceta();
    }
}
