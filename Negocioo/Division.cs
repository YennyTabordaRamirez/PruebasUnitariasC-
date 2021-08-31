using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Negocioo
{
    public class Division    {
        public Division()
        {
            this.AccesoDatosDivision = new AccesoDatosDivision();
        }
        public IAccesoDatosDivision AccesoDatosDivision { get; set; }//atributo pùblico  

        public int Dividir(int numero1, int numero2)
        {            
            int suma = this.AccesoDatosDivision.ObtenerParametroDivision() + numero2;
            return numero1 / suma;
        }

        public void ObtenerParametroDivision()
        {
            throw new DivideByZeroException();
        }
    }
}
