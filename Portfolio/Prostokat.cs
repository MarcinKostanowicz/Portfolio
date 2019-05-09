namespace Portfolio
{
    public class Prostokat : Figura //dziedziczenie
    {
        private readonly int _bokA, _bokB; 
        //zmienne prywatne warto oznaczać na poczatku _ -> dobre praktyki;
        //jezeli zmienna jest inicjalizowana tylko w kostruktorze mozna oznaczyc pole jako readonly

        public Prostokat(int bokA, int bokB) : base("Prostokat")//konstruktor, jezeli dziedziczysz po jakies klasie i jest tylko jeden konstruktor musisz uzyc konstruktora klasy dziedziczacej
        {
            _bokA = bokA;
            _bokB = bokB;
        }

        public override double ObliczPole()//metoda musi byc override poniewaz dziedziczy po metodzie abstrakcyjnej
        {
            return _bokA * _bokB;
        }
    }
}
