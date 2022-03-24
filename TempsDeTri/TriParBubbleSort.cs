using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempsDeTri
{
     class TriParBubbleSort
    {
        /// <summary>
        /// 
        /// </summary>
        private int [] tab;

        /// <summary>
        /// 
        /// </summary>
        public Stopwatch stopwatch { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tab"></param>
        public TriParBubbleSort(int[] tab)
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
            for (int i = 0; i < tab.Length; i++)
            {
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
