using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    internal class Table
    {
        int[] tab;
        Random rnd = new Random();

        public Table(int grandeurTable) 
        {
            tab = new int [grandeurTable];
            RemplirTab();
            ConsulterDichotomie(1201, 1000,2000);
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


        public int ConsulterDic(int cle, int index0, int index1)
        {
            int temp;
            // partage en deux
            if ((index1 - index0) >= 2)
            {
                if (tab[index0 + (index1 - index0) / 2] <= (cle))
                    temp = ConsulterDic(cle, index0 + (index1 - index0) / 2, index1);
                else
                    temp = ConsulterDic(cle, index0, (index1 - index0) / 2);
            }
            else
            {
                temp = index0;// nombres[index0];
            }
            return temp;
        }
        
        private int[] RemplirTab()
        {
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd.Next(1000, 2000);
                Console.Write($"{tab[i]}|");
            }
            Array.Sort(tab);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"{tab[i]}|");
            }

            return tab;
        }




    }

}
