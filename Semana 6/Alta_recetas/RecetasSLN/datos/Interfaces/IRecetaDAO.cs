using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RecetasSLN.dominio;
using System.Threading.Tasks;

namespace RecetasSLN.datos.Interfaces
{
    internal interface IRecetaDAO
    {
        bool GetNuevaReceta(Receta r);
        int GetProximaReceta();
    }
}
