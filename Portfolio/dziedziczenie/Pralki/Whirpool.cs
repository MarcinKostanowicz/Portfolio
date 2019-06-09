using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.dziedziczenie.Pralki
{
    class Whirpool : Pralka
    {
        private bool czySieWlaczy;

        public Whirpool(bool czySieWlaczy)
        {
            this.czySieWlaczy = czySieWlaczy;
        }

        public new string GetNazwa()
        {
            return "Whirpool";
        }
    }
}
