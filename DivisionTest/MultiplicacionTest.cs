using System;
using AccesoDatos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Negocioo;

namespace MultiplicacionTest
{
    [TestClass]
    public class MiltiplicacionTest
    {
        
        [TestMethod]
        public void MultiplicarEnvioDosPositivosNoCeroRetornaPositivoNoCero()
        {
            int numero1 = 2;
            int numero2 = 2;

            Multiplicacion operacionMultiplicar = new Multiplicacion();
            int respuestaEsperada = 8;

            Mock<IAccesoDatosMultiplicacion> mock = new Mock<IAccesoDatosMultiplicacion>();

            mock.Setup(accesoDatos => accesoDatos.ObtenerParametroMultiplicacion()).Returns(2);

            operacionMultiplicar.AccesoDatosMultiplicacion = mock.Object;

            int resuestaObtenida = operacionMultiplicar.Multiplicar(numero1, numero2);
            Assert.AreEqual(respuestaEsperada, resuestaObtenida);
        }

        [TestMethod]        
        public void MultiplicarEnvioUnCeroYUnPositivoNoCeroRetornaCero()
        {
            int numero1 = 0;
            int numero2 = 5;

            Multiplicacion operacionMultiplicar = new Multiplicacion();
            int respuestaEsperada = 0;

            Mock<IAccesoDatosMultiplicacion> mock = new Mock<IAccesoDatosMultiplicacion>();

            mock.Setup(accesoDatos => accesoDatos.ObtenerParametroMultiplicacion()).Returns(5);

            operacionMultiplicar.AccesoDatosMultiplicacion = mock.Object;

            int resuestaObtenida = operacionMultiplicar.Multiplicar(numero1, numero2);
            Assert.AreEqual(respuestaEsperada, resuestaObtenida);
        }

       
        [TestMethod]        
        public void MultiplicarEnvioNegativoNoCeroYPositivoNoCeroRetornaNegativoNoCero()
        {
            int numero1 = -9;
            int numero2 = 1;

            Multiplicacion operacionMultiplicar = new Multiplicacion();
            int respuestaEsperada = -27;

            Mock<IAccesoDatosMultiplicacion> mock = new Mock<IAccesoDatosMultiplicacion>();

            mock.Setup(accesoDatos => accesoDatos.ObtenerParametroMultiplicacion()).Returns(2);

            operacionMultiplicar.AccesoDatosMultiplicacion = mock.Object;

            int resuestaObtenida = operacionMultiplicar.Multiplicar(numero1, numero2);
            Assert.AreEqual(respuestaEsperada, resuestaObtenida);
        }
        
        [TestMethod]
        public void MultiplicarEnvioDosNegativosNoCeroRetornaPositivoNoCero()
        {
            int numero1 = -9;
            int numero2 = -1;

            Multiplicacion operacionMultiplicar = new Multiplicacion();
            int respuestaEsperada = 27;

            Mock<IAccesoDatosMultiplicacion> mock = new Mock<IAccesoDatosMultiplicacion>();

            mock.Setup(accesoDatos => accesoDatos.ObtenerParametroMultiplicacion()).Returns(-2);

            operacionMultiplicar.AccesoDatosMultiplicacion = mock.Object;

            int resuestaObtenida = operacionMultiplicar.Multiplicar(numero1, numero2);
            Assert.AreEqual(respuestaEsperada, resuestaObtenida);
        }        
        
    }
}
