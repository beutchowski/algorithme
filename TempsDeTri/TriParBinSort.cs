using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempsDeTri
{
    internal class TriParBinSort
    {

        /// <summary>
        /// 
        /// </summary>
        public int[] tab;

        /// <summary>
        /// 
        /// </summary>
        public Stopwatch stopwatch { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tab"></param>
        public TriParBinSort(int[] tab)
        {
            this.tab = tab;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Sort()
        {
            StartChrono();
            StartTri();
            StopChrono();
        }
        /// <summary>
        /// 
        /// </summary>
        private void StartChrono()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }
        /// <summary>
        /// 
        /// </summary>
        private void StopChrono()
        {
            stopwatch.Stop();
        }
        /// <summary>
        /// 
        /// </summary>
        public void StartTri()
        {
            int minValue = tab[0];
            int maxValue = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > maxValue)
                    maxValue = tab[i];
                if (tab[i] < minValue)
                    minValue = tab[i];
            }

            int[] tabBin = new int[maxValue + 1];

            for(int i = 0; i < tab.Length; i++)
            {
                tabBin[tab[i]] = tab[i];
            }

            int k = 0;
            for(int j = 0; j < tabBin.Length; j++)
            {
                if(tabBin[j] > 0)
                {
                    tab[k] = tabBin[j];
                    k++;
                }
            }

            foreach (int g in tabBin)
            {
                Console.Write($"|{g}");
            }

            Console.WriteLine("\n **************************************************");

            foreach (int t in tab)
            {
                Console.Write($"|{t}");
            }

            
        }

    }
}
