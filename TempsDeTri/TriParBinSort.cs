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

            // tri d'entiers 
            int max = 0;
            for (int CptMax = 0; CptMax < tab.Length; CptMax++)
            {
                if (tab[CptMax] > max) max = tab[CptMax];
            }
            //Console.WriteLine("Max: " + max);
            int [] B = new int[max + 1];
            for (int i = 0; i < tab.Length; i++)
            {
                B[tab[i]] = tab[i];
            }
            //B[nombres[cpti]]=300;
            int j = 0;
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] > 0)
                {
                    tab[j] = B[i];
                    j++;
                }

            }
        }

    }
}
