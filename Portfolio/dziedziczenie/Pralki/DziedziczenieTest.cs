using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Portfolio.dziedziczenie.Pralki
{
    class DziedziczenieTest
    {
        [Test]
       public void TestPralek()
        {
            Pralka pralka = new Pralka();
            pralka.GetNazwa();

            Pralka amica = new Amica();
            amica.GetNazwa();

            Pralka samsung = new Samsung();
            samsung.GetNazwa();

            Pralka Whirpool = new Whirpool();
            Whirpool.GetNazwa();

        }
    }
}
