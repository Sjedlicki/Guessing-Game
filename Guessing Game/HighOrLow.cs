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
        public int Max;
        public int guess;
        public int numberToGuess;
        public int Min = 1;

        public HighOrLow(Random num, int Max, int numberToGuess)
        {
            this.num = num;
            this.Max = Max;
            this.numberToGuess = numberToGuess;
        }

        public override int Guess()
        {
            
            bool run = true;
            //while (run)
            //{                
                guess = num.Next(Min, Max);
                if (guess > numberToGuess)
                {
                    Max = guess;
                }
                else if ( guess < numberToGuess)
                {
                    Min  = guess + 1;
                }
            //}
            return guess;
        }
    }
}
