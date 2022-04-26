using System;

namespace ToursDeHanoi
{
    internal class Program
    {
        int qtéPalet = 4;
        int tourDépart = 1;
        int tourInter = 2;
        int tourFinale = 3;

        int déplacements = 0;

        static void Main(string[] args)
        {

        }

        //Voir photo du pseudo code du prof

        public void Déplace(int qtéPalet, int tourDépart, int tourFinale, int tourInter)
        {

            Déplace(qtéPalet - 1, tourDépart, tourFinale, tourInter);
            Console.WriteLine();


            return 0;
        }

    }
}
