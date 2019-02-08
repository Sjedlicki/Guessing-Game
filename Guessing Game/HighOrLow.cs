using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class HighOrLow : Guesser
    {
        public Random num;
        public int guess;
        public int numberToGuess;

        public HighOrLow(Random num, int numberToGuess)
        {
            this.num = num;
            this.numberToGuess = numberToGuess;
        }

        public override int Guess()
        {            
                guess = num.Next(Min, Max);
                if (guess > numberToGuess)
                {
                    Max = guess;
                }
                else if ( guess < numberToGuess)
                {
                    Min  = guess + 1;
                }
            return guess;
        }
    }
}
