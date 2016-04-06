using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeteoNamespace;

namespace MeteoTest
{
    [TestClass]
    public class MeteoTest
    {
        [TestMethod]
        public void TestMaxTemp()
        {
            //Arrange
            Meteo MyMeteo = new Meteo();

            MyMeteo.temperatures.Add(1);
            MyMeteo.temperatures.Add(1);
            MyMeteo.temperatures.Add(1);
            MyMeteo.temperatures.Add(1);
            MyMeteo.temperatures.Add(1);
            MyMeteo.temperatures.Add(1);
            MyMeteo.temperatures.Add(8);
            MyMeteo.temperatures.Add(1);
            MyMeteo.temperatures.Add(1);
            MyMeteo.temperatures.Add(1);
            
            //Act
            int Max = MyMeteo.MaxTemp();

            //Assert
            Assert.AreEqual(8, Max);
        }

        [TestMethod]
        public void Prova1()
        {
            //Arrange
            Meteo MyMeteo = new Meteo();
            int temp = 30;
            int pluja = 5;
            bool vent_fort = true;

            //Act
            bool Max = MyMeteo.alerta_incendi(temp, pluja, vent_fort);

            //Assert
            Assert.AreEqual(true, Max);
        }

        [TestMethod]
        public void Prova2()
        {
            //Arrange
            Meteo MyMeteo = new Meteo();
            int temp = 30;
            int pluja = 5;
            bool vent_fort = false;

            //Act
            bool Max = MyMeteo.alerta_incendi(temp, pluja, vent_fort);

            //Assert
            Assert.AreEqual(false, Max);
        }

        [TestMethod]
        public void Prova3()
        {
            //Arrange
            Meteo MyMeteo = new Meteo();
            int temp = 30;
            int pluja = 12;
            bool vent_fort = true;

            //Act
            bool Max = MyMeteo.alerta_incendi(temp, pluja, vent_fort);

            //Assert
            Assert.AreEqual(false, Max);
        }

        [TestMethod]
        public void Prova4()
        {
            //Arrange
            Meteo MyMeteo = new Meteo();
            int temp = 30;
            int pluja = 12;
            bool vent_fort = false;

            //Act
            bool Max = MyMeteo.alerta_incendi(temp, pluja, vent_fort);

            //Assert
            Assert.AreEqual(false, Max);
        }




    }
}
