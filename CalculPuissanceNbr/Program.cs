using System;

namespace CalculPuissanceNbr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(puissance(4, 2));
        }

        static int puissance(int mantisse, int exposant)
        {
            int nPow;
            if (exposant > 0)
            {
                nPow = mantisse * puissance(mantisse, exposant - 1);
            }
            else
                nPow = 1;
            return nPow;
        }
    }
}

