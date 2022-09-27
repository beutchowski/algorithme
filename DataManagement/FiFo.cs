using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    internal class FiFo
    {
        private int[] queue;
        private int inpos = 0;
        private int outpos = 0;
        private int compteur = 0;

        public FiFo()
        {
            queue = new int[10];
        }


        public void AjouterValeur(int valeur)
        {
            if (!(queue.Count() == compteur))
            {
                queue[inpos % 10] = valeur;
                inpos++;
                compteur++;
            }
            else
            {
                inpos++;
                compteur++;
                Console.WriteLine("Attention! La queue est pleine!!!!");
            }
        }

        public int RetirerValeur()
        {
            if (!(inpos == outpos))
            {   
                outpos++;
                compteur--;
            }
            else
                Console.WriteLine("La queue est vide!!!!");
            return queue[outpos-1];
        }

        public void QueuePleine()
        {
            if (queue.Count() == 0)
                Console.WriteLine("La queue est vide!");

        }

        public void AfficherQueue()
        {
            foreach(int i in queue)
            {
                Console.Write($"{i} |");
            }
        }


    }
}
