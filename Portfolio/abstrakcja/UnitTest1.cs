using NUnit.Framework;
using System;

namespace Portfolio.basic2
{
    public enum Figury {        //Enum typ wyliczeniowy 
        Kwadrat = 0,
        Prostokat = 1, 
        Trapez = 2
    }

    [TestFixture] //atrybut nunit
    public class UnitTest1
    {
        
        [Test] //atrybut nunit 
        public void TestMethod1()
        {
            Figura _kwadrat, _prostokat;
            double _pole;


            //Figura figura = new Figura("figura"); //Bedzie blad kompilacji, Figura jest klasa abstrakcyjna wiec nie mozna jej zainicjalizowac

            _kwadrat = new Kwadrat(5);
            _kwadrat.ZwrocNazweFigury();
            _pole = _kwadrat.ObliczPole();

            _prostokat = new Prostokat(5, 3);
            _prostokat.ZwrocNazweFigury();
            _pole = _prostokat.ObliczPole();
        }

        [TestCase(Figury.Kwadrat)] //atrybut nunit 
        public void TestMethodWithIf(Figury figuraDoObliczenia)
        {
            //Figura figura = new Figura("figura"); //Bedzie blad kompilacji, Figura jest klasa abstrakcyjna wiec nie mozna jej zainicjalizowac
            Figura figura;

            if (figuraDoObliczenia.Equals(Figury.Kwadrat))
            {
                figura = new Kwadrat(5);
            }
            else if (figuraDoObliczenia.Equals(Figury.Prostokat))
            {
                figura = new Prostokat(5, 3);
            }
            else
            {
                throw new NotImplementedException();
            }

            figura.ZwrocNazweFigury();
            var pole = figura.ObliczPole();
        }

        [TestCase(Figury.Kwadrat)] //atrybut nunit 
        [TestCase(Figury.Prostokat)] //atrybut nunit 
        [TestCase(Figury.Trapez)] //atrybut nunit 
        public void TestMethodWithSwitch(Figury figuraDoObliczenia)
        {
            //Figura figura = new Figura("figura"); //Bedzie blad kompilacji, Figura jest klasa abstrakcyjna wiec nie mozna jej zainicjalizowac
            Figura figura = null;

            switch (figuraDoObliczenia)
            {
                case Figury.Kwadrat:
                    figura = new Kwadrat(5);
                    break;
                case Figury.Prostokat:
                    figura = new Prostokat(5, 3);
                    break;
                case Figury.Trapez:
                    try
                    {
                        throw new NotImplementedException();
                    }
                    catch(NotImplementedException)
                    {
                        Assert.Fail("Trapez nie obsluzony");
                    }
                    break;
            }
                      
            if(figura == null)
            {
                Assert.Fail($"Figura [{figura}] zwrocil null!");
            }
            
            figura.ZwrocNazweFigury();
            var pole = figura.ObliczPole();
            

        }
    }
}
