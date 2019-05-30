using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.basic2                              
{
    public class Inter                             //Interface dziedziczy Mogłbys wyjasnic jak ?
    {
        public interface IWyjasnienia        // każdy interface zaczynamy od dużej litery I
        {
            void Woj (int pkt);   //przechowywana metoda nie moze zawierac ciala             // moga zawierac tylko metody zmienne nie
            void Atak1(int pkt);


            void Atak5(int pkt);
        }


        public interface IPojazd
        {
            void Wlacz();
            void Wylacz();
            bool CzyWlaczony();
            //void Plyn(); //tutaj nie powinno byc tej metody, poniewaz jest zbyt szczegolowa
        }

        public interface IStatek : IPojazd 
        {
            void Plyn();
        }

        public interface ISamochod : IPojazd
        {
            void Jedz();
        }

        public class KuterRybacki : IStatek
        {
            public bool CzyWlaczony()
            {
                throw new NotImplementedException();
            }

            public void Plyn()
            {
                throw new NotImplementedException();
            }

            public void Wlacz()
            {
                throw new NotImplementedException();
            }

            public void Wylacz()
            {
                throw new NotImplementedException();
            }


        }

    }
}
