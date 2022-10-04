using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    internal class Table
    {
        int[] tab;

        public Table(int grandeurTable) 
        {
            tab = new int [grandeurTable];
        }

        public int Consulter(int valeurAtrouver)
        {
            int index = 0;
            do
            {
                index++; 
            } while (index < tab.Length && valeurAtrouver != tab[index]);
            return index;

        }

        public void Insérer(int valeurAInsérer)
        {

        }

        public int Retirer()
        {
            return 0;
        }

        public void initialiser()
        {

        }




    }

}
