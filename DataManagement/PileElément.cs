using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    internal class PileElément
    {
        private Elément sommet;

        public PileElément()
        {

        }

        public Boolean PileVide()
        {
            return sommet == null;
        }

        public int Longueur()
        {
            int l = 1;
            if (sommet == null) l = 0;
            else
            {
                Elément  actuel = sommet;
                while (actuel.GetSuivant() != null)
                {
                    l++;
                    actuel = actuel.GetSuivant();
                }
            }
            return l;
        }

        public double Sommet()
        {
            double valeur;
            if (sommet != null)
            {
                valeur = sommet.GetVal();
            }
            else valeur = -1;
            return valeur;
        }

        public void Empile(double val)
        {
            Elément nouveau = new Elément();
            nouveau.SetInfo(val);
            if (PileVide())
            {
                sommet = nouveau;
            }
            else
            {
                nouveau.SetSuivant(sommet);
                sommet = nouveau;
            }
        }

        public void Remplacer(double val)
        {

            if (PileVide())
            {

            }
            else
            {
                sommet.SetInfo(val);
            }
        }

        public double Depile()
        {
            double temp = -1;
            if (!PileVide())
            {
                temp = sommet.GetVal();
                sommet = sommet.GetSuivant();
            }
            Console.WriteLine("Pile vide!!");
            return temp;
        }

        public void Efface()
        {
            sommet = null;
        }

        public void Affiche()
        {
            Elément aff = new Elément();
            aff = sommet;
            Console.WriteLine();
            while (aff != null)
            {
                Console.Write(aff.GetVal() + "/");
                aff = aff.GetSuivant();
            }
            Console.WriteLine();
        }




    }
}
