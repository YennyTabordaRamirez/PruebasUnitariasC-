using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Negocioo
{
    public class Multiplicacion    {
        public Multiplicacion()
        {
            this.AccesoDatosMultiplicacion = new AccesoDatosMultiplicacion();
            //AccesoDatosMultiplicacion accesoDatosMultiplicacion = new AccesoDatosMultiplicacion();
        }

        public IAccesoDatosMultiplicacion AccesoDatosMultiplicacion { get; set; }

        public int Multiplicar(int numero1, int numero2)
        {
            int suma = this.AccesoDatosMultiplicacion.ObtenerParametroMultiplicacion() + numero2;
            return numero1 * suma;
        }        
    }
}
