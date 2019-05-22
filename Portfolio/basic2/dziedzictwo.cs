using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Portfolio.basic2
{
    public class Liga
    {
        public virtual string GetTabela()
        {
            return "punktacja";

        }

    } 
    
    public class Legia : Liga
    {
        public override string GetTabela()
        {
            return "Legia";
        }
    }         
    
    public class Wisla : Liga
    {
        public override string GetTabela()
        {
            return "Wisla";
        }
    }
    
    public class DziedziczenieTest2
    {
        [Test]
        public void TestTabela()
        {
            Liga liga = new Liga();
            liga.GetTabela();

            Liga legia = new Legia();
            legia.GetTabela();


        }
            
            

            
            



            
        





    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
     
    
    
}
