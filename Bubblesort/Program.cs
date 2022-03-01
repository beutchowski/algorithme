using System;

namespace Bubblesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[] { 1, 7, 3, 2, 0, 5, 0, 8 };

            for(int i = 0; i < tab.Length; i++)
            {
                foreach (int k in tab)
                {
                    Console.Write(k);
                }

                Console.WriteLine("\n");
                for (int j = i+1; j < tab.Length; j++)
                {
    
                    if (tab[i] > tab[j])
                    {
                        int temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;

                    }
                }
            }

            foreach (int k in tab)
            {
                Console.Write(k);
            }

        }
    }
}
