using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    internal class Liste
    {
        int[] tab;
        private int grandeurTableau;

        public Liste(int nbrEléments)
        {
            this.tab = new int[nbrEléments];
            this.grandeurTableau = 0;
        }

        
        public void add(int élément)
        {

            tab[grandeurTableau] = élément;
            grandeurTableau++;

        }

        public void remove(int élémentAEnlever)
        {
            int i = 0;

            while(tab[i] != élémentAEnlever && i < tab.Length)
            {
                i++;
            }

            if (i == tab.Length)
            {
                return;
            }

            for(int j = i; j < tab.Length -1; j++)
            {
                tab[j] = tab[j + 1];
            }

        }

        public void Display()
        {
            for(int i = 0; i < grandeurTableau; i++)
            {
                Console.Write(tab[i] + "|");
            }
        }

    }
}
