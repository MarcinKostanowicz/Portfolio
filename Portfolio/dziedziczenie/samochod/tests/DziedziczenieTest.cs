using NUnit.Framework;

namespace Portfolio.dziedziczenie.samochod.tests
{
    public class DziedziczenieTest
    {
        [Test]
        public void TestMarek()
        {
            Samochod samochod = new Samochod();
            samochod.GetMarka();

            Samochod audi = new Audi();
            audi.GetMarka();

            Bmw bmw = new Bmw();
            bmw.GetMarka();
        }
    }



}
