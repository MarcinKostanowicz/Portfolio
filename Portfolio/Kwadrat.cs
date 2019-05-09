namespace Portfolio
{
    public class Kwadrat : Figura // dziedziczenie
    {
        private readonly int _bok;
        //zmienne prywatne warto oznaczać na poczatku _ -> dobre praktyki;
        //jezeli zmienna jest inicjalizowana tylko w kostruktorze mozna oznaczyc pole jako readonly

        public Kwadrat(int bok) : base("Kwadrat") //konstruktor, jezeli dziedziczysz po jakies klasie i jest tylko jeden konstruktor musisz uzyc konstruktora klasy dziedziczacej
        {
            _bok = bok;
        }

        public override double ObliczPole() //metoda musi byc override poniewaz dziedziczy po metodzie abstrakcyjnej
        {
            return _bok * _bok;
        }
    }
}
