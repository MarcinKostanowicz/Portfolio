using NUnit.Framework;

namespace Portfolio.basic2.Konstruktory
{
    public class KonstruktoryUnitTest
    {
        [TestCase(true)]
        [TestCase(false)]
        public void TestKonstruktoraBazowego(bool czyHetero)
        {
            Osoba osoba = new Osoba(czyHetero);
            Assert.AreEqual(czyHetero, osoba.CzyHetero);
        }

        [Test]
        public void TestOsobaBezParametrowy()
        {
            Czlowiek czlowiek = new Czlowiek();
            Assert.AreEqual(true, czlowiek.CzyHetero);
            Assert.IsTrue(czlowiek.Imie.Equals("Karol"));
        }

        [Test]
        public void TestOsobaParametrowy()
        {
            Czlowiek czlowiek = new Czlowiek("Marcin", true);
            Assert.AreEqual(true, czlowiek.CzyHetero);
            Assert.IsTrue(czlowiek.Imie.Equals("Marcin"));
        }

        [Test]
        public void TestOsobaParametrowy2()
        {
            Czlowiek czlowiek = new Czlowiek("Ula", 25);
            Assert.AreEqual(true, czlowiek.CzyHetero);
            Assert.IsTrue(czlowiek.Imie.Equals("Karol"), "Oczekiwalem Ula a jest Karol");
            Assert.AreEqual(25, czlowiek.Wiek);
        }
    }
}
