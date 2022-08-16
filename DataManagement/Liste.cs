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

        public Liste(int nbrEléments)
        {
            this.tab = new int[nbrEléments];
        }

        
        public void add(int élément)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == null)
                {
                    tab[i] = élément;
                }
            }


        }

    }
}
