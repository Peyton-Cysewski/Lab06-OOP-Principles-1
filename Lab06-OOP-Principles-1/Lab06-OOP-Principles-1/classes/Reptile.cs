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
        public override int Age { get; set; } = 0;


        abstract public string LayingEggs();

        /// <summary>
        /// Writes a distinct string to the console to determine it is the EatingHumans function
        /// </summary>
        /// <returns>Distinct string</returns>
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
