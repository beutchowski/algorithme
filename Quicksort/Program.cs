using System;

namespace Quicksort
{
    internal class Program
    {

        static int[] tab;
        static void Main(string[] args)
        {

            tab = new int[16] {22, 36, 6, 79, 26, 49, 75, 13, 31, 62, 27, 76, 33, 16, 62, 47 };

            foreach(int i in tab)
            {
                Console.Write("|");
                Console.Write(i);
            }
            Quicksort(0, tab.Length-1);
            Console.WriteLine("\n");
            foreach (int i in tab)
            {
                Console.Write("|");
                Console.Write(i);
            }




        }

        static void Quicksort(int borneMin, int borneMax)
        {
            int indexRéf = (((borneMax - borneMin) / 2) + borneMin) +1;

            int valeurRéférence = tab[indexRéf];

            int compteurMin = borneMin;
            int compteurMax = borneMax;

            while (compteurMin < compteurMax)
            {
                while (compteurMin < compteurMax && tab[compteurMin] < valeurRéférence)
                {
                    compteurMin++;
                }
                
                while (compteurMin < compteurMax && tab[compteurMax] > valeurRéférence)
                {
                    compteurMax--;
                }
                if (tab[compteurMin] > valeurRéférence || tab[compteurMax] < valeurRéférence)
                {
                    int tempMin = tab[compteurMin];
                    int tempMax = tab[compteurMax];
                    tab[compteurMin] = tempMax;
                    tab[compteurMax] = tempMin;
                    compteurMax--;
                    compteurMin++;
                }
            }




            




   







        }


        static void BubbleSort()
        {
            for (int i = 0; i < tab.Length; i++)
            {
                foreach (int k in tab)
                {
                    Console.Write(k);
                }

                Console.WriteLine("\n");
                for (int j = i + 1; j < tab.Length; j++)
                {

                    if (tab[i] > tab[j])
                    {
                        int temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;

                    }
                }
            }
        }



    }
}