using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataManagement
{
    internal class FifoElément
    {
        private Elément début;
        private Elément fin;

        public FifoElément()
        {
            début = null;
            fin = null;
        }

        public void AjouterElément(double valeur)
        {
            Elément élément = new Elément();
            élément.SetInfo(valeur);

            if (élément == null)
            {
                début = élément;
            }
            else
            {
                fin.SetSuivant(élément);
            }

            fin = élément; //AU début comme quand on en a déjà, chaque nouvel élément devient la fin...
           
        }


        public double EnleverElément()
        {
            Elément élémentAEnlever = null;
            if (QueueVide())
                return -1;
            else
            {
                élémentAEnlever = début;
                début = début.GetSuivant();
            }
            if (QueueVide())
                fin = null;
            return élémentAEnlever.GetVal();

        }

        public int longueurDeQueue()
        {
            int qteElément = 0;
            Elément élémentActuel = this.début;

            while(élémentActuel != null)
            {
                qteElément++;
                élémentActuel = élémentActuel.GetSuivant();
            }

            return qteElément;
        }

        public bool QueueVide()
        {
            return début == null;
        }








    }
}
