using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles_1.classes
{
    public class PolarBear : Bear
    {
        public bool CanClimb { get; set; }

        public void Lonely()
        {
            if (!CanClimb)
            {
                Console.WriteLine("I am a sad, lonely bear stuck in Antarctica.");
            }
        }
    }
}
