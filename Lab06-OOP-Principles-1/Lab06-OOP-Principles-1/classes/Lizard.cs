using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles_1.classes
{
    public class Lizard : Reptile
    {
        public bool IsSlimy { get; set; }
        public bool IsSketchy { get; set; }
        public override int Age { get; set; } = 12;
        override public bool Carnivore { get; set; } = false;
        override public bool Herbivore { get; set; } = false;
        override public bool Omnivore { get; set; } = true;

        /// <summary>
        /// Writes a new distinct string for the Lizard class based on the inherited LaysEggs property
        /// </summary>
        /// <returns>Distinct Lizard string</returns>
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
    }
}