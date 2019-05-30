namespace Portfolio.basic2
{
    public abstract class Figura //abstract czyli nie może być zainicjalizowana, przynajmniej jedna metoda powinna byc abstrakcyjna (ale nie musi)
    {
        protected string NazwaFigury { private get; set; }

        //private string _nazwaFiguty;
        //public string NazwaFigury2
        //{
        //    get
        //    {
        //        return _nazwaFiguty;
        //    }
        //    set
        //    {
        //        _nazwaFiguty = value;
        //    }
        //}

        public Figura(string nazwaFigury)
        {
            NazwaFigury = nazwaFigury;
        }

        public abstract double ObliczPole(); //metoda abstrakcyjna nie ma ciała

        public string ZwrocNazweFigury() // klasy dziedziczace beda mialy dostep do tej metody bo jest publiczna
        {
            return NazwaFigury;
        }
    }

}
