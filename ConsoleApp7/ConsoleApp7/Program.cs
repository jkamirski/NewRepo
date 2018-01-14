using System;

namespace DziedziczenieBazowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Blat tp = new Blat(4, 5);
            tp.WyswietInformacje();
            Console.ReadKey();

            // Wynik działania programu
            //Dlugosc: 4
            //Szerokosc: 5
            //Powierzchnia: 20
            //Koszt: 1000
        }
    }

    // klasa bazowa
    class Prostokat
    {
        protected int dlugosc;
        protected int szerokosc;

        public Prostokat(int d, int s)
        {
            dlugosc = d;
            szerokosc = s;
        }

        public int ObliczPowierzchnie()
        {
            return dlugosc * szerokosc;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Długość: {0}", dlugosc);
            Console.WriteLine("Szerokość: {0}", szerokosc);
            Console.WriteLine("Powierzchnia: {0}", ObliczPowierzchnie());
        }
    }

    // klasa pochodna
    class Blat : Prostokat
    {
        // Słowo kluczowe base przy konstruktorze pozwala nam wywowołać konsturktor klasy bazowej
        // W tym momencie przekazaliśmy nasze parametry do konstruktora klasy bazowej
        public Blat(int d, int s) : base(d, s)
        {
        }

        public int Koszt()
        {
            int koszt;
            koszt = ObliczPowierzchnie() * 50;
            return koszt;
        }

        public void WyswietInformacje()
        {
            // słowo kluczowe base pozwala nam odwołać się do składowych klasy bazowej
            // dla kompilatora ważniejsze się zmienne z klasy w której właśnie jesteśmy
            // za pomocą słowa kluczowe base wskazujemy jednoznacznie do której składowej
            // chcemy się odwołać. Dziękimi poniższemu wywołaniu w obecnej metodzie wywołamy
            // również metodę z klasy bazowej - wyświetlona zostanie większa ilość informacji
            base.WyswietlInformacje();
            Console.WriteLine("Koszt: {0}", Koszt());
        }

    }
}
