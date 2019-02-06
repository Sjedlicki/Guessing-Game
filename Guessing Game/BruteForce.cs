using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class BruteForce : Guesser
    {
        public int x;

        public BruteForce(int max)
        {
            this.x = max;
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




