using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    internal class Pile
    {
        int[] pile;
        private int sommet;


        public Pile(int nbrElément)
        {
            this.pile = new int[nbrElément];
            sommet = 0;
        }

        public void MettreLeTrucSurLaPile(int valeurAjoutéeSurLaPile)
        {
            if (pile.Length > sommet)
            {
                pile[sommet] = valeurAjoutéeSurLaPile;
                sommet++;
            }
 
            else
                Console.WriteLine("La pile est pleine!!!!");

        }

        public void RemplacerUnTrucAuSommetdeLaPile(int valeurARemplacerAuSommetDeLaPile)
        {
            pile[sommet-1] = valeurARemplacerAuSommetDeLaPile;

        }

        public void DésempilerLaValeurAuSommetDeLaPile()
        {
            if (sommet>0)
            {
                sommet--;
            }
            else
            {
                Console.WriteLine("La pile est vide!!!!");
            }
        }


        public int ValeurAuSommetDeLaPile()
        {
            return pile[sommet-1];
        }


        public void PilePleine()
        {
            if (sommet == pile.Length)
                Console.WriteLine("La pile est pleine videz la un peu svp!!!");
        }

        public void PileVide()
        {
            if (sommet == 0)
                Console.WriteLine("La pile est vide, empiler des truc svp!!!!");
        }

        public void LongueurDePile()
        {
            Console.WriteLine("La hauteur de la pile est de : " + sommet);
        }

        public void Effacer()
        {
            sommet = 0;
        }



        public void Display()
        {
            for (int i = 0; i < pile.Length; i++)
            {
                Console.Write(pile[i] + "|");
            }
        }


    }
}
