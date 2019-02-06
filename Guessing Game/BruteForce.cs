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
        int x = 99;

        public BruteForce()
        {
            for (int i = 0; i < 100; i++)
            {
                number.Add(i);
            }
        }

        public override int Guess()
        {
            return number[x--];
        }
    }
}




