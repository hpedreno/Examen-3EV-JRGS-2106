using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen3EV_NS;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //[ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestListaCorrecta()
        {
            try
            {
                List<int> notas = new List<int>();

                notas.Add(0);
                notas.Add(5);
                notas.Add(9);
                notas.Add(3);
                notas.Add(7);
                notas.Add(4);
                notas.Add(8);

                double mediaEsperada = 5.143;
                int susE = 3;
                int aprE = 1;
                int notE = 2;
                int sbrE = 1;
                EstablecerNota prueba1 = new EstablecerNota(notas);
                Assert.AreEqual(mediaEsperada, prueba1.GetNotaMedia());
            }
            catch (ArgumentOutOfRangeException e)
            {   
                Console.WriteLine(e);
            }

        }

        [TestMethod]
        //[ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestListaVacia()
        {
            try
            {
                List<int> notas = new List<int>();

                double mediaEsperada = 5.0;
                int susE = 3;
                int aprE = 1;
                int notE = 2;
                int sbrE = 1;
                EstablecerNota prueba1 = new EstablecerNota();
                Assert.AreEqual(mediaEsperada, prueba1.GetNotaMedia());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }

        }

        [TestMethod]
        //[ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestNotasIncorrectas()
        {
            try
            {
                List<int> notas = new List<int>();

                notas.Add(-4);
                notas.Add(5);
                notas.Add(14);
                notas.Add(3);

                double mediaEsperada = 18.0;
                int susE = 3;
                int aprE = 1;
                int notE = 2;
                int sbrE = 1;
                EstablecerNota prueba1 = new EstablecerNota(notas);
                Assert.AreEqual(mediaEsperada, prueba1.GetNotaMedia());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
