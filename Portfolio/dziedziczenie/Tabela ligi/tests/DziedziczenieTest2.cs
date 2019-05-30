using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Portfolio.dziedziczenie.Tabela_ligi.tests
{
    public class DziedziczenieTest2
    {
        [Test]
        public void TestTabela()
        {
            ILiga liga = new Wisla();
            liga.GetTabela();

            ILiga legia = new Legia();
            legia.GetTabela();


        }

    }
}
