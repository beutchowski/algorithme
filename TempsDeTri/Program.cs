using System;
using System.Collections.Generic;

namespace TempsDeTri
{
    internal class Program
    {
        static Random rand = new Random();
        const int TAILLE = 50000;
        static List<double> stockageSortieBubble;
        static List<double> stockageSortieInser;
        static List<double> stockageSortieSelec;
        static void Main(string[] args)
        {

            stockageSortieBubble = new List<double>();


            for (int i = 1; i < 3; i++)
            {
                int[] tab = Tab(TAILLE);
                TriParBubbleSort bubble = new TriParBubbleSort(tab);
                TriParInsertion triInser = new TriParInsertion(tab);
                TriParSelection triSelec = new TriParSelection(tab);

                bubble.Sort();
                

                triInser.Sort();

                triSelec.Sort();


            }


            Console.WriteLine($"Tri BubbleSort test {i} : " + bubble.stopwatch.ElapsedMilliseconds + "ms");

            Console.WriteLine($"Tri par insertion test {i} : " + triInser.stopwatch.ElapsedMilliseconds + "ms");

            Console.WriteLine($"Tri par insertion test {i} : {triInser.time:F5}ms");

            Console.WriteLine($"Tri par sélection test {i} : " + triSelec.stopwatch.ElapsedMilliseconds + "ms");

        }

        static int[] Tab(int taille)
        {
            int[] tab = new int[taille];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(100000,1000000);
            }
            return tab;
        }
        
    }
}
