using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles_1.classes
{
    public abstract class Reptile : Animal
    {
        public bool IsALoner { get; set; } = true;
        public bool LaysEggs { get; set; } = false;
        public bool WillEatPeople { get; set; } = true;

        public string LayingEggs()
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

        public string EatingHumans()
        {
            if (WillEatPeople)
            {
                Console.WriteLine("They are saltier than I remember!");
                return "They are saltier than I remember!";
            }
            else
            {
                Console.WriteLine("The small one got away today.");
                return "The small one got away today.";
            }
        }
    }
}
