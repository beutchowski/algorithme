using System;

namespace CalculInterêtsComposés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculIntéret(1000, 0.01, 4));
        }

        static decimal CalculIntéret(decimal somme, double intérêt, int nbrAnnées)
        {
            decimal produit;
            if (nbrAnnées > 0)
            {
                produit = CalculIntéret(somme + somme * (decimal)intérêt, intérêt, nbrAnnées - 1);
            }
            else
                produit = somme;
            return produit;
        }
    }
}
