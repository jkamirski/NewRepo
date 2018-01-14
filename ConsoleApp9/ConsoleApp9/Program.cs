using System;
namespace WlasciwosciAbstrakcja
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperCar sc = new SuperCar();
            sc.Brand = "Pagani";
            sc.Model = "Zonda F";
            sc.Capacity = 7.3;
            Console.WriteLine("Info: {0}", sc.ToString());
            Console.ReadKey();
            // Wynik działania programu
            // Info: Marka: Pagani | Model: Zonda F | Pojemnosc: 7.3 l
        }
    }
    abstract class Car
    {
        private string brand = "N.A";
        private string model = "N.A";
        private double capacity = 0.0;
        // Deklaracja właściwości Brand z dostępem do pola prywatnego brand
        public abstract string Brand
        {
            get;
            set;
        }
        public abstract string Model
        {
            get;
            set;
        }
        public abstract double Capacity
        {
            get;
            set;
        }
    }
    class SuperCar : Car
    {
        private string brand;
        private string model;
        private double capacity;
        // Celowo przedstawiam różne zapisy, żebyś wybrał ten, który najbardziej Ci odpowiada
        public override string Brand { get { return brand; } set { brand = value; } }
        public override string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public override double Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public override string ToString()
        {
            string returnedString = string.Format("Marka: {0} | Model: {1} | Pojemnosc: {2} l", brand, model, capacity);
            return returnedString;
        }
    }
}
                                                                                                                                                     