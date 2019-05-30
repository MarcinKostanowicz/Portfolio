

using NUnit.Framework;

namespace Portfolio.basic2
{
    
    public class Osoba
    {
        public bool CzyHetero { get; set; }

        public Osoba(bool czyHetero)
        {
            CzyHetero = czyHetero;
        }
    }

    public class Czlowiek : Osoba
    {
        public string Imie { get; set; }
        public int Wiek { get; set; }

        public Czlowiek() : base(true) //konstruktor bezprametrowy
        {
            Imie = "Karol";
        }

        public Czlowiek(string imie, int wiek) : this()
        {
            Wiek = wiek;
        }

        public Czlowiek(string imie, bool czyHetero) : base(czyHetero) //kostruktor parametrowy
        {
            Imie = imie;
        }
        

        public void UnitTestCzlowiekKonstruktory()
        {
            Czlowiek karol = new Czlowiek();

            Czlowiek marcin = new Czlowiek("Marcin", true);

            Czlowiek krzysiek = new Czlowiek("Krzysiek", 34);

            
            
        }
        
        [Test]
        public void Test()
        {

        }
    }
}
