using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.abstrakcja.samochod
{
   public class Fiat : Pojazd
    {
        private readonly int _konie;
        private int konie;

        public Fiat(int bok) : base("Fiat")
        {
            _konie = konie;
        }

        public override double ObliczPredkosc()
        {
            return _konie * _konie;
        }
    }
}
