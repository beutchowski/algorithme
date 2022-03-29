using System;

namespace Fibonacci
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool onrecommence = true;
            do
            {
                Console.Write("Le chiffre de Fibonacci désiré est le : ");
                int fibo = int.Parse(Console.ReadLine());
                double resultat = fibonacci(fibo);
                Console.WriteLine($"\nRésultat : {resultat}");
                Console.Write("ON recommence? ");
                char ouinon = char.Parse(Console.ReadLine());
                if (ouinon == 'o')
                    onrecommence = true;
                else if (ouinon == 'n')
                    onrecommence = false;
            }
            while (onrecommence);


            static int fibonacci(int n)
            {
                Console.Write($"| {n} |");
                if ((n == 0) || (n == 1))
                    return n;
                else
                    return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }
    }
}
