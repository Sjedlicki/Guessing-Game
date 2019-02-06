using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class GuessMe
    {
        Guesser player;
        public int max;
        public int attemps = 0;

        public GuessMe(Guesser player, int max)
        {
            this.player = player;

        }

        public void Play(int guess)
        {
            Random r = new Random();
            int num1 = r.Next(1, max);
            //int num2 = r.Next(1, max);


            while (num1 != guess)
            {

                attemps++;
            }

        }

        public bool Correct()
        {
            for (int i = 0; i < max; i++)
            {
                if (foundLetters[i] != word[i])
                {
                    return false;
                }
            }
            Console.WriteLine("You won! Good Job!");
            return true;
        }
    }
}
