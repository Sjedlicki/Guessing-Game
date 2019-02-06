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
            this.max = max;

            Random r = new Random();
            int num1 = r.Next(1, max);
            Play(player.Guess(), num1);
        }

        public void Play(int guess, int num1)
        {
            Console.WriteLine($"Number to guess: {num1}");
            Console.WriteLine($"This is my guess: {guess}");

            while (num1 != guess)
            {
                Console.WriteLine($"Num1: {num1}");                
                Console.WriteLine("Testing: " + player.Guess());
                Console.ReadKey();
                attemps++;
            }

            Console.WriteLine("Congratulations! You're a WINNER!");
            Console.WriteLine($"Attempts: {attemps}");

        }
    }
}
