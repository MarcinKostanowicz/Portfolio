using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.basic2.Konstruktory
{
    public class Samochod
    {
        public string Marka { get; set; }
        public int Moc { get; set; }

        public Samochod(string marka, int moc) : this(marka)
        {
            Moc = moc;
        }

        public Samochod(string marka)
        {
            Marka = marka;
        }

        public Samochod()
        {
            Marka = "Audi";
        }
    }
}
