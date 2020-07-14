using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles_1.classes
{
    public abstract class Animal
    {
        virtual public string Gender { get; set; } = "male";
        abstract public bool Carnivore { get; set; }
        abstract public bool Herbivore { get; set; }
        abstract public bool Omnivore { get; set; }
        virtual public int Age { get; set; } = 0;

        virtual public string Eating()
        {
            Console.WriteLine("Nom nom nom...");
            return "Nom nom nom...";
        }

        virtual public string Sleeping()
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
