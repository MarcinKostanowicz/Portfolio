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


        public Samochod()
        {
            Marka = "Audi";
        }

        internal void Marka(string v)
        {
            throw new NotImplementedException();
        }

        public Samochod (string marka, int moc) : this()
        {
            Moc = moc;
        }

        internal void Moc(int v)
        {
            throw new NotImplementedException();
        }
    }
}
