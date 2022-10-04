using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    internal class Elément
    {
        private double valeur;
        private Elément next;
        public Elément()
        {
            next = null;
            valeur = 0;
        }
        // permet de modifier la valeur
        public void SetInfo(double val)
        {
            this.valeur = val;
        }
        public void SetSuivant(Elément suivant)
        {
            this.next = suivant;
        }
        public double GetVal()
        {
            return this.valeur;
        }
        public Elément GetSuivant()
        {
            return this.next;
        }
    }
}
