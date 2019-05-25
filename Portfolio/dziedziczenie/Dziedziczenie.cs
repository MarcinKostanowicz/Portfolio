using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Portfolio.basic2
{
    public class Samochod
    {
        public virtual string GetMarka()
        {
            return "Samochod zastepczy";
        }
    }

    public class Audi : Samochod
    {
        public new string GetMarka()
        {
            return "Audi";
        }
    }

    public class Bmw : Samochod
    {
        public override string GetMarka()
        {
            return "Bmw";
        }
    }
    public class DziedziczenieTest
    {
        [Test]
        public void TestMarek()
        {
            Samochod samochod = new Samochod();
            samochod.GetMarka();

            Samochod audi = new Audi();
            audi.GetMarka();

            Bmw bmw = new Bmw();
            bmw.GetMarka();
        }

    }
}
