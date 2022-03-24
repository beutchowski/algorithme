using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempsDeTri
{
    internal class TriParSelection
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
        public TriParSelection(int[] tab)
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
            for (int indexPosition = 0; indexPosition < tab.Length; indexPosition++)
            {
                int indexDuMin = indexPosition;

                for (int indexNombreAComparer = indexPosition; indexNombreAComparer < tab.Length; indexNombreAComparer++)
                {
                    if (tab[indexNombreAComparer] < tab[indexDuMin])
                        indexDuMin = indexNombreAComparer;
                }

                if (indexPosition != indexDuMin)
                {
                    int temp = tab[indexPosition];
                    tab[indexPosition] = tab[indexDuMin];
                    tab[indexDuMin] = temp;
                }
            }
        }
    }
}
