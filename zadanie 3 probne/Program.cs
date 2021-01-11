using System;

namespace zadanie_3_probne
{
    class Program
    {
        static int SumaRek(int n)
        {
            if (n < 7)
                return 0;
            else if (n % 7 == 0)
            {
                return n + SumaRek(n - 1);
            }
            else
                 return SumaRek(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumaRek(28));
        }
    }
}
