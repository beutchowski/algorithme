﻿using System;

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
        }
    }
}
