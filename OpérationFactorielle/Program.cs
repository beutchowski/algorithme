using System;

namespace OpérationFactorielle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool onrecommence = true;
            do
            {
                Console.Write("Le facteur désiré est le : ");
                double facto = double.Parse(Console.ReadLine());
                double resultat = OpérationFactorielle(facto);
                Console.Write("\nON recommence? ");
                char ouinon = char.Parse(Console.ReadLine());
                if (ouinon == 'o')
                    onrecommence = true;
                else if (ouinon == 'n')
                    onrecommence = false;
            }
            while (onrecommence);


            static double OpérationFactorielle(double n)
            {
                double temp = 0;
                    if (n == 0)
                        temp = 1;
                    else
                        temp = n * OpérationFactorielle(n - 1);
                Console.WriteLine($"{n} : {temp}");
                return temp;

            }
        }
    }
}
