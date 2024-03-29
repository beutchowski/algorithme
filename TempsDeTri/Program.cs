﻿using System;
using System.Collections.Generic;

namespace TempsDeTri
{
    internal class Program
    {
        static Random rand = new Random();
        const int TAILLE = 100000;
        static List<double> stockageSortieBubble;
        static List<double> stockageSortieInser;
        static List<double> stockageSortieSelec;
        static void Main(string[] args)
        {

            stockageSortieBubble = new List<double>();


            for (int i = 1; i < 2; i++)
            {
                int[] tab1 = Tab(TAILLE);
                int[] tab2 = Tab(TAILLE);
                int[] tab3 = Tab(TAILLE);
                int[] tab4 = Tab(TAILLE);
                TriParBubbleSort bubble = new TriParBubbleSort(tab1);
                TriParInsertion triInser = new TriParInsertion(tab2);
                TriParSelection triSelec = new TriParSelection(tab3);
                TriParBinSort triBin = new TriParBinSort(tab4);

                /*
                bubble.Sort();
                Console.WriteLine($"Tri BubbleSort test {i} : " + bubble.stopwatch.ElapsedMilliseconds + "ms");
                triInser.Sort();
                Console.WriteLine($"Tri par insertion test {i} : " + triInser.stopwatch.ElapsedMilliseconds + "ms");
                triSelec.Sort();
                Console.WriteLine($"Tri par sélection test {i} : " + triSelec.stopwatch.ElapsedMilliseconds + "ms");
                */
                triBin.Sort();
                Console.WriteLine($"Tri par Binsort test {i} : " + triBin.stopwatch.ElapsedMilliseconds + "ms");

                Console.WriteLine("\n");

                





                




            }




        }

        static int[] Tab(int taille)
        {
            int[] tab = new int[taille];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(1,1000);
            }
            return tab;
        }





    }
}
