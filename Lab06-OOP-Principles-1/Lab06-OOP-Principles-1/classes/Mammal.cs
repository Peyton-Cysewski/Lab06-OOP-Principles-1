using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles_1.classes
{
    public abstract class Mammal : Animal
    {
        public bool HasParties { get; set; } = true;
        public bool HumansLikeUs { get; set; } = true;
        public bool IsTamable { get; set; } = true;

    
        public int LikeableScale()
        {
            if (HumansLikeUs)
            {
                return 9000;
            }
            else
            {
                return -9000;
            }
        }

        public int PettableScale()
        {
            if (IsTamable && HumansLikeUs)
            {
                return 900000;
            }
            else
            {
                return -900000;
            }
        }
    }
}
