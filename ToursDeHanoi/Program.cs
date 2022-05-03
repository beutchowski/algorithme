using System;

namespace ToursDeHanoi
{
    internal class Program
    {
        static int qtéPalet = 3;
        static int tourDépart = 1;
        static int tourInter = 2;
        static int tourFinale = 3;

        static int déplacement = 1;


        static void Main(string[] args)
        {
            Déplace(qtéPalet, tourDépart, tourInter, tourFinale);   
        }

        //Voir photo du pseudo code du prof

        static void Déplace(int qtéPalet, int tourDépart, int tourInter, int tourFinale)
        {
            if (qtéPalet >=1)
            {
                Déplace(qtéPalet - 1, tourDépart, tourFinale, tourInter);
                Console.WriteLine($"Déplacer le disque sur la tour de départ ({tourDépart}) vers socle d'arrivée ({tourFinale}). Déplacement n°{déplacement}");
                déplacement++;
                Déplace(qtéPalet - 1, tourInter, tourDépart, tourFinale);
            }
        }
    }
}
