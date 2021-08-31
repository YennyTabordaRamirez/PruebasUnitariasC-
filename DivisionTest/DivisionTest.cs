using System;
using System.Threading.Tasks;
using AccesoDatos;
using Foundatio.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Negocioo;

namespace DivisionTest
{
    [TestClass]
    public class DivisionTest
    {
        public object AsyncMathsStatic { get; private set; }

        [TestMethod]
        public void DividirEnvioDosPositivosNoCeroRetornaPositivoNoCero()
        {
            int numero1 = 9;
            int numero2 = 3;

            Division operacionDividir = new Division();
            int respuestaEsperada = 2;

            Mock<IAccesoDatosDivision> mock = new Mock<IAccesoDatosDivision>();
            mock.Setup(accesoDatos => accesoDatos.ObtenerParametroDivision()).Returns(1);
            operacionDividir.AccesoDatosDivision = mock.Object;
            
            int resuestaObtenida = operacionDividir.Dividir(numero1, numero2);
            Assert.AreEqual(respuestaEsperada, resuestaObtenida);
        }

        [TestMethod]        
        public void DividirEnviarUnCeroYUnNumeroNoCeroRetornaCero()
        {
            int numero1 = 0;
            int numero2 = 5;

            Division operacionDividir = new Division();
            //int respuestaEsperada = 0;

            operacionDividir.Dividir(numero1, numero2);
            //Assert.AreEqual(respuestaEsperada, resuestaObtenida);
        }
       
        [TestMethod]        
        public void DividirEnvioNegativoNoCeroYPositivoNoCeroRetornaNegativoNoCero()
        {
            int numero1 = -9;
            int numero2 = 1;

            Division operacionDividir = new Division();
            int respuestaEsperada = -3;

            Mock<IAccesoDatosDivision> mock = new Mock<IAccesoDatosDivision>();

            mock.Setup(accesoDatos => accesoDatos.ObtenerParametroDivision()).Returns(2);

            operacionDividir.AccesoDatosDivision = mock.Object;

            int resuestaObtenida = operacionDividir.Dividir(numero1, numero2);
            Assert.AreEqual(respuestaEsperada, resuestaObtenida);
        }

        [TestMethod]
        public void DividirEnvioPositivoNoCeroYNegativoNoCeroRetornaNegativoNoCero()
        {
            int numero1 = 8;
            int numero2 = -2;

            Division operacionDividir = new Division();
            int respuestaEsperada = -2;

            Mock<IAccesoDatosDivision> mock = new Mock<IAccesoDatosDivision>();
            //porque minùscula la a?  dònde la estoy declarand minuscula?
            mock.Setup(accesoDatos => accesoDatos.ObtenerParametroDivision()).Returns(-2);

            operacionDividir.AccesoDatosDivision = mock.Object;

            int resuestaObtenida = operacionDividir.Dividir(numero1, numero2);
            Assert.AreEqual(respuestaEsperada, resuestaObtenida);
        }

        [TestMethod]
        public void DividirEnvioDosNegativosNoCeroRetornaPositivoNoCero()
        {
            int numero1 = -9;
            int numero2 = -1;

            Division operacionDividir = new Division();
            int respuestaEsperada = 3;

            Mock<IAccesoDatosDivision> mock = new Mock<IAccesoDatosDivision>();

            mock.Setup(accesoDatos => accesoDatos.ObtenerParametroDivision()).Returns(-2);

            operacionDividir.AccesoDatosDivision = mock.Object;

            int resuestaObtenida = operacionDividir.Dividir(numero1, numero2);
            Assert.AreEqual(respuestaEsperada, resuestaObtenida);
        }
        
        [TestMethod]
        public void DividirEnvioCeroYNegativoNoCeroRetornaCero()
        {
            int numero1 = 0;
            int numero2 = -3;

            Division operacionDividir = new Division();
            int respuestaEsperada = 0;

            int resuestaObtenida = operacionDividir.Dividir(numero1, numero2);
            Assert.AreEqual(respuestaEsperada, resuestaObtenida);
        }

        //[TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        //public void DividirEnviarNumeroNoCeroYUnCeroRetornaError()
        //{
        //    int numero1 = 4;
        //    int numero2 = 0;

        //    Division operacionDividir = new Division();
        //    //int respuestaEsperada = 0;

        //    operacionDividir.Dividir(numero1, numero2);
        //    //Assert.AreEqual(respuestaEsperada, resuestaObtenida);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        //public void DividirEnviarDosNumerosCeroRetornaNoDefinido()
        //{
        //    int numero1 = 0;
        //    int numero2 = 0;

        //    Division operacionDividir = new Division();
        //    //int respuestaEsperada = 0;

        //    Mock<Division> mock = new Mock<Division>();
        //    using Async
        //    async
        //    await.ThrowsException<DivideByZeroException>(async () => {
        //        int Result = await AsyncMathsStatic.Dividir();

        //        //    //Async().ThrowsException<DivideByZeroException>(async () => {
        //        //    //int Result = await AsyncMathsStatic.Divide();
        //        //});
        //        mock.Setup(accesoDatos => accesoDatos.ObtenerParametroDivision()).Throws<DivideByZeroException>;

        //        operacionDividir. = mock.Object;

        //        /*int resuestaObtenida =*/ //operacionDividir.Dividir(numero1, numero2);
        //                                   //Assert.AreEqual(respuestaEsperada, resuestaObtenida);
        //    }
        // }

    }
}
