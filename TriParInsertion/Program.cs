using System;

namespace TriParInsertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[] { 1, 7, 3, 2, 0, 5, 0, 8 };

            for(int cptPassage = 1; cptPassage < tab.Length; cptPassage++)
            {
                int temp = tab[cptPassage];
                int cptElement = cptPassage;

                while(cptElement - 1 >= 0 && temp < tab[cptElement-1])
                {
                    tab[cptElement] = tab[cptElement-1];
                    cptElement --;
                }
                tab[cptElement] = temp;

                foreach (int k in tab)
                {
                    Console.Write(k);
                }
                Console.WriteLine("\n");

            }

        }
    }
}
