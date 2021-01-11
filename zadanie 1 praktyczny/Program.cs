using System;

namespace zadanie_1_praktyczny
{
    class Program
    {
        static int Ile(int [] T)
        {
            
            int counter = 0;
            for(int i=0;i<T.Length;i++)
            {
               // Console.WriteLine(T[i]);
                while(T[i]>=10)  // dzielimy przez 10, bo 7<10, w ten sposób zostanie nam tylko 1 cyfra nie większa niż 9. 
                {
                    T[i] /= 10;  
                }
                if (T[i] == 7)  //i jak znalezlismy 7 to kox, zwiekszamy licznik
                    counter++;
              
            }
            Console.WriteLine(counter);
            return counter; // zwracamy licznik
        }
        static void Main(string[] args)
        {
            int[] Tab = { 787, 232, 3, 7, 9, 70 };
            Ile(Tab);
        }
    }
}
