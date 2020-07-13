using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles_1.classes
{
    public class Lizard : Reptile
    {
        public bool IsSlimy { get; set; }
        public bool IsSketchy { get; set; }

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