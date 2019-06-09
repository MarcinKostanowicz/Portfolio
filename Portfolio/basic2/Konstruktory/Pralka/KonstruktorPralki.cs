using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.dziedziczenie.Pralki;

namespace Portfolio.basic2.Konstruktory.Pralka
{
    class Pralka
    {
        private bool czySieWlaczy;
        private string Dupa;

        public bool CzySieWlaczy { get; set; }

        public Pralka(bool CzySieWlaczy)
        {
            CzySieWlaczy = czySieWlaczy;
        }

        public Pralka(string dupa)
        {
            this.Dupa = dupa;
        }
    }

    public class Pralka : Whirpool 
    {
        private string marka;

        public Pralka(string Marka, bool czySieWlaczy) : base(czySieWlaczy) 
        {
            Marka = marka;
        }


    }

    public void UnitTestKonstruktorPralki()
    {
        Pralka Whirpool = new Pralka();

        Pralka Amica = new Pralka(true);

        Pralka Dupa = new Pralka("Dupa");

    }














}   
    
