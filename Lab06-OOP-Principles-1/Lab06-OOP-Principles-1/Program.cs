using Lab06_OOP_Principles_1.classes;
using System;

namespace Lab06_OOP_Principles_1
{
    class Program
    {
        static void Main(string[] args)
        {
           Examples();
        }

        public static void Examples()
        {
            PolarBear beary = new PolarBear();
            Console.WriteLine("Beary the Polar Bear is part of the Polar Bear class. He is capable of all these things even though all of these they were all inherited:");
            Console.WriteLine("Sleeping() method output:");
            beary.Sleeping();
            Console.WriteLine("Eating() method output:");
            beary.Eating();
            Console.WriteLine("Living() method output:");
            beary.Living();
            Console.WriteLine("LikeableScale() and PettableScale() method outputs:");
            Console.WriteLine($"Beary has a likeable scale number of {beary.LikeableScale()} and a pettable scale number of {beary.PettableScale()}.");

        }
    }
}
