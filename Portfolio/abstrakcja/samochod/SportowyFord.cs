using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.abstrakcja.samochod
{
    public class SportowyFord : Ford
    {
        //tutaj mozesz w konstruktorze przekazac dodatkowa moc i masz wartosc domyslna
        public SportowyFord() : base(80)
        {
        }
    }
}
