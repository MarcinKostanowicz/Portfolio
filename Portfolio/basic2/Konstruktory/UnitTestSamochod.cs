using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Portfolio.basic2.Konstruktory
{
    class UnitTestSamochod
    {

        [Test]
        public void TestSamochodMarka()
        {
            Samochod samochod = new Samochod();
            samochod.Marka("Audi");
        }
        [Test]
        public void TestSamochodMoc()
        {
            Samochod samochod = new Samochod();
            samochod.Moc(60);
        }













    }
}
