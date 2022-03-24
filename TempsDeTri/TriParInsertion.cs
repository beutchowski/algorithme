using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempsDeTri
{
    internal class TriParInsertion
    {
        public double time;
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
        public TriParInsertion(int[] tab)
        {
            this.tab = tab;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Sort()
        {
            StartChrono();
            var DateStart = DateTime.Now;
            StartTri();
            var DateEnd = DateTime.Now;
            resultTime(DateStart, DateEnd);
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
            //foreach (int i in tab)
            //{
            //    Console.Write($"| {i} |");
            //}
            //Console.WriteLine("----------------------------------------------------------------------");
            //Console.WriteLine("----------------------------------------------------------------------");
            //Console.WriteLine("----------------------------------------------------------------------");
            //Console.WriteLine("----------------------------------------------------------------------");
            for (int cptPassage = 1; cptPassage < tab.Length; cptPassage++)
            {
                int temp = tab[cptPassage];
                int cptElement = cptPassage;

                while (cptElement - 1 >= 0 && temp < tab[cptElement - 1])
                {
                    tab[cptElement] = tab[cptElement - 1];
                    cptElement--;
                }
                tab[cptElement] = temp;
                
            }

            //foreach (int i in tab)
            //{
            //    Console.Write($"| {i} |");
            //}
        }

        public void resultTime(DateTime start, DateTime end)
        {
            var Time = end - start;
            time = Time.TotalSeconds;
        }

    }
}
