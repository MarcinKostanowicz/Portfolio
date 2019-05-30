using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.basic
{
    class z
    {
        IfElse ie = new IfElse();

        public z()
        {

        }
    }

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


        internal void Switch()
            {
                int liczba;
                liczba = int.Parse(Console.ReadLine()); // zwraca nam typ int w konsoli moge wpisywać liczby

                switch (liczba)
                {
                    case 1:                      // (case przypadek)
                        Console.WriteLine("jeden");
                        break;
                    case 2:


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
