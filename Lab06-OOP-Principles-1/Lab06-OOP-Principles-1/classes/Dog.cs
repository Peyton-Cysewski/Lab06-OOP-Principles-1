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

        public void PeeingOnTree()
        {
            if (IsLoveable)
            {
                Console.WriteLine("Only pees on other people\'s trees!");
            }
            else
            {
                Console.WriteLine("Pees on your house.");
            }
        }

        public void GivingHumanNoPersonalSpace()
        {
            if (!IsLoveable)
            {
                Console.WriteLine("Refuses to cuddle with human.");
            }
            else
            {
                Console.WriteLine("Follows human on heel.");
            }
        }
    }
}
