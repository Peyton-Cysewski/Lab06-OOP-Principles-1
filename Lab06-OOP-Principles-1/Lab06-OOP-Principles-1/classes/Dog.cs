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

        /*public string PeeingOnTree()
        {
            if (IsLoveable)
            {
                Console.WriteLine("Only pees on other people\'s trees!");
                return "Only pees on other people\'s trees!";
            }
            else
            {
                Console.WriteLine("Pees on your house.");
                return "Pees on your house.";
            }
        }

        public string GivingHumanNoPersonalSpace()
        {
            if (!IsLoveable)
            {
                Console.WriteLine("Refuses to cuddle with human.");
                return "Refuses to cuddle with human.";
            }
            else
            {
                Console.WriteLine("Follows human on heel.");
                return "Follows human on heel.";
            }
        }*/
    }
}
