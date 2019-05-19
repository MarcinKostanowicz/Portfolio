using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.basic
{
    class IfElse
    {

        public void InstrukcjeWarunkowe()
        {

            int a = -1;

            if (a > 0)
            {
                Console.WriteLine("a jest wieksze od zera");
            }
            else
            {
                Console.WriteLine("a jest mniejsze od zera");
            }
        }    
           public void Switch()
            {
                int liczba;
                liczba = int.Parse(Console.ReadLine());

                switch (liczba)
                {
                    case 1:
                        Console.WriteLine("jeden");
                        break;
                    case 2:
                        Console.WriteLine("dwa");
                        break;
                     case 3:
                    Console.WriteLine("trzy");
                    break;
                  default:
                    Console.WriteLine("inna wartosc");
                    break;






                }




            }






        




















    }
}
