using System;
namespace AnonymousMethod
{
    delegate void ChangeNumber(int n);
    class Program
    {
        static int number = 10;
        public static void AddNumber(int a)
        {
            number += a;
            Console.WriteLine("Metoda nazwana: {0}", number);
        }
        public static void MultiplyNumber(int m)
        {
            number *= m;
            Console.WriteLine("Metoda nazwana: {0}", number);
        }
        public static int GetNumber()
        {
            return number;
        }
        static void Main(string[] args)
        {
            // Tworzymy instancję delegata używając metody anonimowej
            ChangeNumber cn = delegate (int x)
            {
                Console.WriteLine("Metoda anonimowa: {0}", x);
            };
            // wywołanie delegata używając metody anonimowej
            cn(10);
            // a teraz inicjowanie delgata używając metody nazwanej
            cn = new ChangeNumber(AddNumber);
            // wywołanie delegata używając metody nazwanej
            cn(10);
            // inicjowanie delegata przy użyciu innej metody nazwanej
            cn = new ChangeNumber(MultiplyNumber);
            // wywołanie delegata
            cn(2);
            // Zwrócenie liczby po dokonanych zmianach
            Console.WriteLine("Rezultat: {0}", Program.GetNumber());
            Console.ReadKey();
            // Wynik działania programu
            // Metoda anonimowa: 10
            // Metoda nazwana: 20
            // Metoda nazwana: 40
            // Rezultat: 40
        }
    }
}
