using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Portfolio.basic2.Konstruktory.Pralka
{
   public class UnitTestKonstruktorPralki
    {
        [Test]
        public void TestOsobaBezParametrowy()
        {
            Pralka pralka = new Pralka();
            Assert.AreEqual(true, pralka.CzySieWlaczy);
            Assert.IsTrue(pralka.CzySieWlaczy.Equals("Dupa"));
        }
    }
}
