using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.abstrakcja.samochod
{
   public class Ford : Pojazd
    {
        private int _dodatkoweKoniePoTuningu;

        //tutaj mozesz w konstruktorze przekazac dodatkowa moc i masz wartosc domyslna
        public Ford(int dodatkoweKoniePoTuningunie) : base("Ford") 
        {
            Konie = 90;
            _dodatkoweKoniePoTuningu = dodatkoweKoniePoTuningunie;
        }

        public override double ObliczPredkosc() 
        {
            return Konie + _dodatkoweKoniePoTuningu;
        }
    }
}
