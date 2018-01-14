using System;
using System.Linq;
namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            TabliceParametryczne tp = new TabliceParametryczne();
            // W tym momencie do wnętrza naszej metody możemy przekazać różną
            // liczbę parametrów. Nie określamy na sztywno ile może ich być.
            int suma = tp.DodajElementy(1, 2, 3, 4, 6);
            Console.WriteLine("Wynik dodawania to: {0}", suma);
            Console.ReadLine();
        }
    }
    class TabliceParametryczne
    {
        public int DodajElementy(params int[] tablica)
        {
            int suma = 0;
            foreach (var item in tablica)
            {
                suma += item;
            }
            return suma;
        }
    }
}