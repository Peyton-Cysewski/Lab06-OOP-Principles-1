using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles_1.classes
{
    public abstract class Mammal : Animal
    {
        public bool HasParties { get; set; }
        public bool HumansLikeUs { get; set; }
        public bool IsTamable { get; set; }

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
