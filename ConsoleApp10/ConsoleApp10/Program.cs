using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace RefleksjaWlasnyAtrybut
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2.5, 3.5);
            Type type = typeof(Rectangle);
            // W pierwszym kroku sprawdzimy atrybuty klasy
            Console.WriteLine("Atrybuty klasy:");
            foreach (Object item in type.GetCustomAttributes(false))
            {
                DebugInfo di = item as DebugInfo;
                if (di != null)
                {
                    Console.WriteLine("Numer błędu: {0}", di.CodeNumber);
                    Console.WriteLine("Programista: {0}", di.DeveloperName);
                    Console.WriteLine("Przegląd kodu: {0}", di.LastReviewData);
                    Console.WriteLine("Info: {0}", di.message);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Atrybuty metod:");
            // W pierwszej kolejności pobieramy wszystkie metody
            foreach (MethodInfo method in type.GetMethods())
            {
                foreach (Attribute a in method.GetCustomAttributes(true))
                {
                    DebugInfo di = a as DebugInfo;
                    if (di != null)
                    {
                        Console.WriteLine("Numer błędu: {0}", di.CodeNumber);
                        Console.WriteLine("Programista: {0}", di.DeveloperName);
                        Console.WriteLine("Przegląd kodu: {0}", di.LastReviewData);
                        Console.WriteLine("Info: {0}", di.message);
                    }
                }
            }
            Console.ReadKey();
            // Wynik działania programu
            // Atrybuty klasy:
            // Numer bledu: 23
            // Programista: Pawel
            // Przeglad kodu: 27/11/2015
            // Info: Zly zwracany typ
            // Numer bledu: 223
            // Programista: Pawel
            // Przeglad kodu: 29/11/2015
            // Info: Nieprzypisana wartosc
            // Atrybuty metod:
            // Numer bledu: 11
            // Programista: Pawel
            // Przeglad kodu: 22/11/2015
            // Info: Zly zwracany typ
        }
    }
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Constructor |
        AttributeTargets.Method |
        AttributeTargets.Field |
        AttributeTargets.Property,
        AllowMultiple = true)]
    public class DebugInfo : Attribute
    {
        // pola prywatne
        private int codeNumber;
        private string developerName;
        private string lastReviewData;
        public string message;
        public DebugInfo(int code, string dev, string d)
        {
            this.codeNumber = code;
            this.developerName = dev;
            this.lastReviewData = d;
        }
        // właściowości, które dają nam dostęp do pól prywatnych
        // ich użycie będzie potrzebne podczas korzystania z mechanizmu refleksji
        // ale o tym w kolejnym rozdziale
        public int CodeNumber
        {
            get
            {
                return codeNumber;
            }
        }
        public string DeveloperName
        {
            get
            {
                return developerName;
            }
        }
        public string LastReviewData
        {
            get
            {
                return lastReviewData;
            }
        }
    }
    [DebugInfo(23, "Paweł", "27/11/2015", message = "Zły zwracany typ")]
    [DebugInfo(223, "Paweł", "29/11/2015", message = "Nieprzypisana wartość")]
    class Rectangle
    {
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        [DebugInfo(11, "Paweł", "22/11/2015", message = "Zły zwracany typ")]
        public double GetArea()
        {
            return length * width;
        }
    }
}
