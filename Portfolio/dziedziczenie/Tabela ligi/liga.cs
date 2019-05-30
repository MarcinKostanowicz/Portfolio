using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.dziedziczenie.Tabela_ligi
{
   public class Liga
    {
        public virtual string GetTabela()
        {
            return "punktacja";

        }
    }
}






public interface ILiga  
{
    string GetTabela();
}


