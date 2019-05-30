using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Portfolio.dziedziczenie.Sklepy.test
{
    public class DziedziczenieTest
    {
        [Test]
        public void TestTowary()
        {
            Sklep sklep = new Sklep();
            sklep.GetTowary();

            Sklep mango = new Mango();
            mango.GetTowary();
            Sklep grycan = new Grycan();
            grycan.GetTowary();
            Sklep hAndM = new HAndM();
            hAndM.GetTowary();

            Sklep empik = new Empik();
            empik.GetTowary();

        }
    }

}
