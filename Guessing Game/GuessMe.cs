using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class GuessMe
    {
        Guesser Player;
        //public static List<int> attempted = new List<int>();
        public static int tries = 0;
        public int NumberToGuess;

        public GuessMe(Guesser Player, int numberToGuess)
        {
            this.Player = Player;
            int guess = Player.Guess();
            this.NumberToGuess = numberToGuess;

            Play(numberToGuess, guess);
        }

        public void Play(int numberToGuess, int guess)
        {
            bool run = true;
            while (run)
            {
                tries++;
                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine(tries);
                //Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.WriteLine(numberToGuess);
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine(guess);
                //Console.ForegroundColor = ConsoleColor.White;

                if (numberToGuess == guess)
                {
                    //Console.ForegroundColor = ConsoleColor.Blue;
                    //Console.WriteLine($"!!!WINNER!!! Guess: {guess} Tries:  {tries}");
                    run = false;
                }
                else if (numberToGuess != guess)
                {
                    guess = Player.Guess();                    
                }
            }
        }
    }
}
