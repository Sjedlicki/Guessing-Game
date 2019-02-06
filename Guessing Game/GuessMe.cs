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
        public static int num2 = 0;

        public GuessMe(Guesser player, int numberToGuess)
        {
            this.player = player;
            int guess = player.Guess();

            Play(numberToGuess, guess);
        }


        public void Play(int num1, int guess)
        {
            

            while (num1 != guess)
            {               
                Console.WriteLine($"Number to guess: {num1}");
                Console.WriteLine($"This is my guess: {guess}");
                Console.WriteLine($"Num1: {num1}");
                guess = player.Guess();
                //Console.WriteLine("Testing: " + player.Guess());
                Console.ReadKey();
                attemps++;
            }

            Console.WriteLine("Congratulations! You're a WINNER!");
            Console.WriteLine($"Attempts: {attemps}");

        }
    }
}
