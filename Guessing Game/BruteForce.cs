using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class BruteForce : Guesser
    {
        //int Max;
        public BruteForce()
        {
            //this.Max = Max;
            //x = Max - 1;
        }

        public override int Guess()
        {
            if (x >= 1)
            {
                return x--;
            }
            return x;
        }
    }
}




