using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles_1.classes
{
    public class Bear : Mammal
    {
        public string FurColor { get; set; }
        public string HbernationLocation { get; set; }
        public string CartoonNickname { get; set; }
        override public bool Carnivore { get; set; } = false;
        override public bool Herbivore { get; set; } = false;
        override public bool Omnivore { get; set; } = true;

        /// <summary>
        /// Writes a new distinct string for the Bear class
        /// </summary>
        /// <returns>Distinct Bear string</returns>
        public override string Eating()
        {
            Console.WriteLine("*Indistinct Screaming*");
            return "*Indistinct Screaming*";
        }

        /// <summary>
        /// Writes a new distinct string for the Bear class
        /// </summary>
        /// <returns>Distinct Bear string</returns>
        public override string SayHi()
        {
            Console.WriteLine("Roar");
            return "Roar!";
        }
    }
}
