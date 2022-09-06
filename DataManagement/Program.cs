using System;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Liste liste1 = new Liste(4);

            liste1.add(1);
            liste1.add(18);
            liste1.add(32);

            liste1.Display();
            liste1.remove(1);
            Console.WriteLine();
            liste1.Display();

            Console.WriteLine("\n");
            Console.WriteLine("********Pile**********");
            Pile pile1 = new Pile(10);
            pile1.Display();
            Console.WriteLine("\n");
            pile1.MettreLeTrucSurLaPile(4);
            pile1.MettreLeTrucSurLaPile(8);
            pile1.MettreLeTrucSurLaPile(15);
            pile1.MettreLeTrucSurLaPile(16);
            pile1.MettreLeTrucSurLaPile(23);
            pile1.MettreLeTrucSurLaPile(42);
            pile1.Display();
            Console.WriteLine("\n");
            pile1.RemplacerUnTrucAuSommetdeLaPile(41);
            pile1.Display();
            Console.WriteLine("\n");
            Console.WriteLine("La valeur au sommet de la pile est :" + pile1.ValeurAuSommetDeLaPile());
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.Display();
            Console.WriteLine("\n");
            Console.WriteLine("La valeur au sommet de la pile est :" + pile1.ValeurAuSommetDeLaPile());
            Console.WriteLine("\n");
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.MettreLeTrucSurLaPile(4);
            pile1.MettreLeTrucSurLaPile(8);
            pile1.MettreLeTrucSurLaPile(15);
            pile1.MettreLeTrucSurLaPile(16);
            pile1.MettreLeTrucSurLaPile(23);
            pile1.MettreLeTrucSurLaPile(42);
            pile1.MettreLeTrucSurLaPile(4);
            pile1.MettreLeTrucSurLaPile(8);
            pile1.MettreLeTrucSurLaPile(15);
            pile1.MettreLeTrucSurLaPile(16);
            Console.WriteLine("\n");
            pile1.Display();
            Console.WriteLine("\n");
            pile1.PilePleine();
            Console.WriteLine("\n");
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            pile1.DésempilerLaValeurAuSommetDeLaPile();
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            pile1.Display();
            Console.WriteLine("\n");
            pile1.PileVide();
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");


        }
    }
}
