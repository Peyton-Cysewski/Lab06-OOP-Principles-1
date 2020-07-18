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

    
        /// <summary>
        /// Determines the ikeability number based on the HumansLikeus property
        /// </summary>
        /// <returns>Likeability number</returns>
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

        /// <summary>
        /// Determines the pettable number based on the IsPettable property
        /// </summary>
        /// <returns>Likeability number</returns>
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

        public abstract string SayHi();
    }
}
