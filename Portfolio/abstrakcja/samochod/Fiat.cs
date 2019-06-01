using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.abstrakcja.samochod
{
    public class Fiat : Pojazd
    {
        // bez mozliwosci rozszerzenia ale jest algorytm w postaci metody ktory rozszerza moc samochodu
        public Fiat() : base("Fiat")
        {
            Konie = 60;
        }

        // jakis algorytm ktory wylicza dodatkowa moc
        private int DodatkowaMoc()
        {
            return 10 + 15;
        }

        public override double ObliczPredkosc()
        {
            return Konie + DodatkowaMoc();
        }
    }
}
