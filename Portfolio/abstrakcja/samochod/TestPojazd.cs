using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Portfolio.abstrakcja.samochod
{
    public class TestPojazd
    {
        private Fiat fiat;
        private double konie;
        private Ford ford;
        
        public Fiat TestPojazdu { get; private set; }

        public enum Pojazd
        {
           Fiat = 60,
           Ford = 90


        }

        [Test]
        public void TestPojazdui()
        {
            fiat = new Fiat();
            fiat.ZwrocNazwePojazdu();
            konie = fiat.ObliczPredkosc();

            ford = new Ford();
            ford.ZwrocNazwePojazdu();
            konie = ford.ObliczPredkosc();

        }

        [TestCase(Pojazd.Fiat)]
        public void TestPojazduWithIf(Pojazd pojazdObliczPredkosc)
        {
            if (pojazdObliczPredkosc.Equals(Pojazd.Fiat))
            {
                TestPojazd = new Fiat();
            }
            if (pojazdObliczPredkosc.Equals(Pojazd.Fiat))
            {
                TestPojazd = new Ford(); 

           
            
                

            
        }







    }


















}
