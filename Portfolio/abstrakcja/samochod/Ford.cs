using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.abstrakcja.samochod
{
   public class Ford : Pojazd
    {
        private readonly int _konie;
        private int konie;

        public Ford(int bok) : base("Ford") 
        {
            _konie = konie;
        }

        public override double ObliczPredkosc() 
        {
            return _konie * _konie;
        }
    }
}
