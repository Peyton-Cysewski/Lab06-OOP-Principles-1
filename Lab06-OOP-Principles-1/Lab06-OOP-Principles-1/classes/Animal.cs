using System;
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
        public int Age { get; set; } = 0;

        public string Eating()
        {
            if (Carnivore)
            {
                Console.WriteLine("*Indistinct screams*");
                return "*Indistinct screams*";
            }
            else
            {
                Console.WriteLine("Nom nom nom...");
                return "Nom nom nom...";
            }
        }

        public string Sleeping()
        {
            Console.WriteLine("Zzzzzzzzz...");
            return "Zzzzzzzzz...";
        }

        public string Living()
        {
            if (Herbivore)
            {
                Console.WriteLine("Was murdered by a carnivore!");
                return "Was murdered by a carnivore!";
            }
            else
            {
                Console.WriteLine("Dreaming about eating a herbivore...");
                return "Dreaming about eating a herbivore...";
            }
        }
    }
}
