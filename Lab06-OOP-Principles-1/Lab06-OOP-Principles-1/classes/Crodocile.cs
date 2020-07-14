using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles_1.classes
{
    public class Crodocile : Reptile
    {
        public bool HasScales { get; set; }
        public bool IsScary { get; set; }
        override public bool Carnivore { get; set; } = true;
        override public bool Herbivore { get; set; } = false;
        override public bool Omnivore { get; set; } = false;

        public override string LayingEggs()
        {
            if (LaysEggs)
            {
                Console.WriteLine("I just laid an egg, but it wasn\'t golden.");
                return "I just laid an egg, but it wasn\'t golden.";
            }
            else
            {
                Console.WriteLine("Whoops, that\'s not an egg...");
                return "Whoops, that\'s not an egg...";
            }
        }

        /*public string BeingScary()
        {
            if (IsScary)
            {
                Console.WriteLine("RAWR XD");
                return "RAWR XD";
            }
            else
            {
                Console.WriteLine("Hello, how\'s it going?");
                return "Hello, how\'s it going?";
            }
        }*/
    }
}
