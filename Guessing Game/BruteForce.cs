using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class BruteForce : Guesser
    {
        public static List<int> number = new List<int>();
        int x = 100;

        public BruteForce()
        {

        }

        public override int Guess()
        {
            return x--;
        }
    }
}




