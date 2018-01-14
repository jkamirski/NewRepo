using System;
namespace ModyfikatoryDostepu
{
    class Program
    {
        // Tutaj dojdzie do wykonania kodu naszej klasy
        static void Main(string[] args)
        {
            Prostokat pr = new Prostokat();
            //pr.wysokosc = 4.5;
            //pr.szerokosc = 3.5;
            pr.PobierzDane();
            pr.WyswietlInformacje();
            Console.ReadKey();
            // Wykonanie programu
            //Szerokosc: 3.5
            //Wysokosc: 4.5
            //Powierzchnia: 15.75
        }
    }
    class Prostokat
    {
        // pola klasy
        private double szerokosc;
        private double wysokosc;
        public double ObliczPowierzchnie()
        {
            return szerokosc * wysokosc;
        }
        public void PobierzDane()
        {
            Console.WriteLine("Podaj szerokość: ");
            szerokosc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wysokość: ");
            wysokosc = Convert.ToDouble(Console.ReadLine());
        }
        public void WyswietlInformacje()
        {
            Console.WriteLine("Szerokość: {0}", szerokosc);
            Console.WriteLine("Wysokość: {0}", wysokosc);
            Console.WriteLine("Powierzchnia: {0}", ObliczPowierzchnie());
        }
    }
}
