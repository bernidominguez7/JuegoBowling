using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using JuegoBowling;

namespace UnitTestProjectBowling
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void JugadaPeor()
        {

            for (int i = 0; i < 10; i++)
            {
                Juego.Tirar(0);
                Juego.Tirar(0);
            }
            int resultado = Juego.Score();
            Assert.AreEqual(resultado, 0);
        }

        [TestMethod]
        public void JugadaMediocre()
        {

            for (int i = 0; i < 10; i++)
            {
                Juego.Tirar(1);
                Juego.Tirar(0);
            }
            int resultado = Juego.Score();
            Assert.AreEqual(resultado, 10);
        }

        [TestMethod]
        public void JugadaAlMenosSpare()
        {
            Juego.Tirar(7);
            Juego.Tirar(3);

            for (int i = 1; i < 10; i++)
            {
                Juego.Tirar(1);
                Juego.Tirar(0);
            }
            int resultado = Juego.Score();
            Assert.AreEqual(resultado, 20);
        }

        [TestMethod]
        public void JugadaAlMenosStrike()
        {
            Juego.Tirar(10);
            Juego.Tirar(0);

            for (int i = 1; i < 10; i++)
            {
                Juego.Tirar(1);
                Juego.Tirar(0);
            }
            int resultado = Juego.Score();
            Assert.AreEqual(resultado, 21);
        }

        [TestMethod]
        public void JugadaAlMenosStrikeYSpare()
        {
            Juego.Tirar(10);
            Juego.Tirar(0);
            Juego.Tirar(7);
            Juego.Tirar(3);

            for (int i = 2; i < 10; i++)
            {
                Juego.Tirar(1);
                Juego.Tirar(0);
            }
            int resultado = Juego.Score();
            Assert.AreEqual(resultado, 40);
        }


        [TestMethod]
        public void JugadaTodoSpare()
        {
          
            for (int i = 0; i < 11; i++)
            {
                Juego.Tirar(7);
                Juego.Tirar(3);
            }
            int resultado = Juego.Score();
            Assert.AreEqual(resultado, 200);
        }

        [TestMethod]
        public void JugadaTodoStrike()
        {

            for (int i = 0; i < 12; i++)
            {
                Juego.Tirar(10);
                Juego.Tirar(0);
            }
            int resultado = Juego.Score();
            Assert.AreEqual(resultado, 300);
        }
    }
}
