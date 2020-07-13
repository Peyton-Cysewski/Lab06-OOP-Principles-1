﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles_1.classes
{
    public abstract class Animal
    {
        public string Gender { get; set; }
        public bool Carnivore { get; set; }
        public bool Herbivore { get; set; }
        public bool Omnivore { get; set; }
        public int Age { get; set; }

        public void Eating()
        {
            if (Carnivore)
            {
                Console.WriteLine("*Indistinct screams*");
            }
            else
            {
                Console.WriteLine("Nom nom nom...");

            }
        }

        public void Sleeping()
        {
            Console.WriteLine("Zzzzzzzzz...");
        }

        public void Living()
        {
            if (Herbivore)
            {
                Console.WriteLine("Was murdered by a carnivore!");
            }
            else
            {
                Console.WriteLine("Dreaming about eating a herbivore...");
            }
        }
    }
}
