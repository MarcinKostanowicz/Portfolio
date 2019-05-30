using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.dziedziczenie.Sklepy
{
    public class HAndM : Sklep
    {
        public new string GetTowary()
        {
            return "H&M";
        }
    }
}
