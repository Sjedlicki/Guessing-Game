using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class RandomGuesser : Guesser
    {
        Random num = new Random();

        public RandomGuesser()
        {

        }

        public override int Guess()
        {
            return num.Next(1, 100);
        }
    }
}
