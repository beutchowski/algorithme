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
            sommet = null;
        }

        public void AjouterElémentALaPile(Elément élémentAAjouter)
        {
            if (sommet == null)
                sommet = élémentAAjouter;
            else
                élémentAAjouter.MarquerElémentSuivant(sommet);
        }
        
        public void RetirerElémentALaPile()
        {
            sommet = 
        }




    }
}
