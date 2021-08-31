using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoDatosDivision : IAccesoDatosDivision
    {
        public int ObtenerParametroDivision()
        {
            return DateTime.Now.Day;
        }
        //public void ObtenerParametroDivision()
        //{
        //    throw new DivideByZeroException();
        //}  //sobrecarga de metodos
    }
}
