using System;

namespace zadanie_4_probne
{
    class Program
    {
        static bool Check(string wyraz)  //funkcja ogarnie który wyraz spełnia warunki zadania
        {

            char[] sam = { 'a', 'e', 'o', 'u', 'i' };
            int samo=0;
            int spol=0;

            for (int i = 0; i < wyraz.Length; i++)
            {
                for (int w = 0; w < sam.Length; w++)
                {

                    if (wyraz[i] == sam[w])
                        samo += 1;
                    else
                        spol += 1;
                }

            }
            if (samo > spol) 
                return false;
            else
                return true;
        }

        static string Zwroc(string a)
        {
            string szukany = "";
            int spaces = 1; // ustawione na 1, bo zawsze jest n-1 spacji gdy n wyrazów
            for (int i = 0; i < a.Length; i++) //liczymy miejsca
            {
                if (a[i] == ' ') //szukajac spacji
                    spaces++;
            }

            int k = 0;
            string [] tab = new string[spaces]; //inicjalizujemy array o rozmiarze odpowiadającemu iloścy wyrazów

            for (int q = 0; q < a.Length; q++)
            {

                if (a[q] != ' ') //dopóki char rózny od spacji wrzucamy do tablicy literka po literce 1 wyraz
                {
                    tab[k] += a[q];
                }
                else // jak znajdziemy spacje, przeskakujemy na następne miejsce w naszej tablicy stringów
                {
                    k += 1;
                }
            }
            for (int q = 0; q < tab.Length; q++) // jak już tablice mamy załadowaną, stosujemy wczesniej napisaną funkcje, zeby ogarnąć który jest szukany
            {
                if (Check(tab[q]))
                    szukany = tab[q];  // no i jak znalezlismy to zajebiscie, przypisujemy go do stringa ktorego zwrocimy
            }
            Console.WriteLine(szukany); 
            return szukany;
        }
     
        
        static void Main(string[] args)
        {
            string p = "ala ma kotta filemmmmona";
            Zwroc(p);
        }
    }
}
