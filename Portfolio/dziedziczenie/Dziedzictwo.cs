using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Portfolio.basic2
{

    public interface ILiga
    {
        string GetTabela();
    }

    public class Liga
    {
       

        public virtual string GetTabela()
        {
            return "punktacja";

        }
    }

    public class Legia : ILiga
    {

        public string GetTabela()
        {
            return "Legia";
        }
    }

    public class Wisla : ILiga
    {
        
        public string GetTabela()
        {
            return "Wisla";
        }
    }
    
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
