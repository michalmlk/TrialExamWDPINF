using System;

namespace zadanie_2_probne
{
    class Program
    {
        static int Sumuj(int start, int koniec)
        {
            int suma = 0;
            for(int i=start;i<koniec+1;i++)
            {
                if (i % 3 != 0 && i % 7 == 0)
                    suma += i;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sumuj(1, 21));
            Console.WriteLine("Hello World!");
        }
    }
}
