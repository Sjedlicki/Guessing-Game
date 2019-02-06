using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class RandomGuesser : Guesser
    {
        public Random num;
        public int max;
        //Random num = new Random();

        public RandomGuesser(Random num, int Max)
        {
            this.num = num;
            this.max = Max;
        }

        public override int Guess()
        {
            int guess = num.Next(1, max);
            return guess;
        }
    }
}
