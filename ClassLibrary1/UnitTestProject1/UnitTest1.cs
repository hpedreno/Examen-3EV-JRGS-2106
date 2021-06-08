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
        //[ExpectedException(typeof(System.ArgumentException))]
        public void TestMethod1()
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

            try
            {
                Examen3EV prueba1 = new Examen3EV(notas);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e)
            }

        }
    }
}
