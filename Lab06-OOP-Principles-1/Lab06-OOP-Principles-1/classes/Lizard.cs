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

        /*public string BeingSneaky()
        {
            if (IsSketchy)
            {
                Console.WriteLine("Almost tripped a human today!");
                return "Almost tripped a human today!";
            }
            else
            {
                Console.WriteLine("I knocked over a human today!");
                return "I knocked over a human today!";
            }
        }*/
    }
}