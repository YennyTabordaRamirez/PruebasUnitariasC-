using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoDatosMultiplicacion : IAccesoDatosMultiplicacion
    {

        public int ObtenerParametroMultiplicacion()
        {
            return DateTime.Now.Year + DateTime.Now.Day;
        }
    }
}

