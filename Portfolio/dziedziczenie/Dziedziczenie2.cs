using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.basic2
{
    public class Sklep
    {

        public virtual string GetTowary()
        {
            return "zwroty";

        }

        public class Mango : Sklep
        {
            public new string GetTowary()
            {
                return "mango";
            }
        }

        public class Grycan : Sklep
        {
            public override string GetTowary()
            {
                return "grycan";
            }
        }
        public class Handm : Sklep
        {
            public new string GetTowary()
            {
                return "H&M";
            }
        }
        public class Empik : Sklep
        {
            public override string GetTowary()
            {
                return base.GetTowary();
            }
        }


    }

}
