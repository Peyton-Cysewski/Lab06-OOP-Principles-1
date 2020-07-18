using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles_1.classes
{
    public class Dog : Mammal
    {
        public bool IsLoveable { get; set; }
        public bool WillFetch { get; set; }
        public bool HatesHoses { get; set; }
        override public bool Carnivore { get; set; } = false;
        override public bool Herbivore { get; set; } = false;
        override public bool Omnivore { get; set; } = true;

        /// <summary>
        /// Writes a new distinct string for the Dog class
        /// </summary>
        /// <returns>Distinct Dog string</returns>
        public override string SayHi()
        {
            Console.WriteLine("Ruff Ruff!");
            return "Ruff Ruff!";
        }
    }
}
