using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class BruteForce : Guesser
    {
        int i = 100;
        public BruteForce()
        {

        }

        public override int Guess()
        {
            return i--;
        }



    }
}




