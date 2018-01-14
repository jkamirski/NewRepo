using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzielenieZeroTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Obliczenia obl = new Obliczenia();
            double wynik;
            wynik = obl.Dzielenie(4,2);
            Console.WriteLine("Wynik obliczeń {0}", wynik);
            Console.ReadKey();

        }
    }
    class Obliczenia
    {
        // dzielenie przez zero
        //public int a;
        //public int b;
        public double podzielone;

        public double Dzielenie(int w1, int w2)
        {
            try
            {
                // w1 = a;
                // w2 = b;
                podzielone = w1 / w2;
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("wyjatek dzielenie przez zero {0}", ex);
            }
            /*finally
            {
                Console.WriteLine("finally zawsze wykonywany blok");
                Console.ReadLine();
            } */
            return podzielone;
        }
    }
}
