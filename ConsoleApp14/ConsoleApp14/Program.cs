using System;
namespace Generics
{
    // Definicja klasy generycznej, w tym przypadku własnej tablicy
    class MyGenericArray<T>
    {
        // definicja typowanej tablicy
        private int[] array;
        // definicja generycznej tablicy
        private T[] genericArray;
        // konstruktor klasy przyjmujący jako parametr rozmiar tablicy
        public MyGenericArray(int size)
        {
            // ustalenie rozmiaru zwykłej tablicy
            array = new int[size + 1];
            // ustalenie rozmiaru tablicy generycznej
            genericArray = new T[size + 1];
        }
        public int getItem(int index)
        {
            return array[index];
        }
        // Powyżej metoda zwracająca typ danych jako int
        // Poniżej metoda pozwalająca na zwrócenie dowolnego typu danych
        public T getGenericItem(int index)
        {
            return genericArray[index];
        }
        public void setValue(int index, int value)
        {
            array[index] = value;
        }
        // Powyżej metoda ustawiająca dane typu całkowitego (int)
        // Poniżej metoda pozwalająca na ustawienie dowolnego typu danych
        public void setGenericValue(int index, T value)
        {
            genericArray[index] = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Utworzenie tablicy liczb całkowitych oraz jej wypełnienie
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            for (int i = 0; i < 5; i++)
            {
                intArray.setGenericValue(i, i * 3);
            }
            // Wypisanie wszystkich danych
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Liczba: {0}", intArray.getGenericItem(i));
            }
            // Używając tej samej generycznej klasy jesteśmy w stanie zadeklarować innym typ danych
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);
            for (int i = 0; i < 5; i++)
            {
                charArray.setGenericValue(i, (char)(i + 97));
            }
            // Wypisanie wszystkich danych
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(charArray.getGenericItem(i));
            }
            Console.ReadKey();
            // Wynik działania programu
            // Liczba: 0
            // Liczba: 3
            // Liczba: 6
            // Liczba: 9
            // Liczba: 12
            // a
            // b
            // c
            // d
            // e
        }
    }
}
