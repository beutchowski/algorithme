using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    internal class Elément
    {
        private int valeur;
        private Elément prochainElément;

        public Elément(int valeur)
        {
            prochainElément = null;
        }

        public void AjouterValeur(int valeur)
        {
                this.valeur = valeur;
        }

        public int GetValeur()
        {
            return valeur;
        }

        public void MarquerElémentSuivant(Elément prochainElément)
        {
            this.prochainElément = prochainElément;
        }

        public Elément GetProchainElément()
        {
            return prochainElément;
        }




    }
}
