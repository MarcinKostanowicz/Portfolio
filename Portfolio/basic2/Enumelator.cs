using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Portfolio.basic2
{
    enum PoryRoku                              //Typ wyliczeniowy
    {
        Wiosna = 0, Lato = 1, Zima = 2
    }

    class Enumelator                                  //mozemy wywołac tylko to co mamy w enumie
    { 
        public void Pogoda()
        {
            PoryRoku poraroku = PoryRoku.Lato;
            Console.WriteLine( PoryRoku.Wiosna );
        }




    }
}
