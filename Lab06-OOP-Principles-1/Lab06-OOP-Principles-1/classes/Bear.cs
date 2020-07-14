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

        public override string Eating()
        {
            Console.WriteLine("*Indistinct Screaming*");
            return "*Indistinct Screaming*";
        }

        public override string SayHi()
        {
            Console.WriteLine("Roar");
            return "Roar!";
        }

        /*public string LivingAtYellowstone()
        {
            if (CartoonNickname == "Yogi")
            {
                Console.WriteLine("I\'m smarter than the av-er-age bear!");
                return "I\'m smarter than the av-er-age bear!";
            }
            else
            {
                Console.WriteLine("I\'m a dumber than average bear that lives in Yellowstone.");
                return "I\'m a dumber than average bear that lives in Yellowstone.";
            }
        }*/
    }
}
