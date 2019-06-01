using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.abstrakcja.samochod

{
   public abstract class Pojazd
    {
        protected int Konie { get; set; }
        protected string NazwaPojazdu { private get; set; }

        public Pojazd(string nazwaPojazdu)
        {
            NazwaPojazdu = nazwaPojazdu;
        }

        public abstract double ObliczPredkosc(); 

        public string ZwrocNazwePojazdu() 
        {
            return NazwaPojazdu;
        }
   }
}