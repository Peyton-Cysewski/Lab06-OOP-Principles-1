using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles_1.classes
{
    public class PolarBear : Bear
    {
        public bool CanClimb { get; set; }

        /*public string Lonely()
        {
            if (!CanClimb)
            {
                Console.WriteLine("I am a sad, lonely bear stuck in Antarctica.");
                return "I am a sad, lonely bear stuck in Antarctica.";
            }
            else
            {
                Console.WriteLine("I\'m an awesome bear that isn\'t freezing cold!");
                return "I\'m an awesome bear that isn\'t freezing cold!";
            }
        }*/
    }
}
