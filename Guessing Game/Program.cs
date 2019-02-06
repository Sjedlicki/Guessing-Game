using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 101;

            Random r = new Random();
            int numberToGuess = r.Next(1, max);

            //Guesser g1 = new RandomGuesser(r, max);
            //Guesser brute = new BruteForce(max);
            Guesser hol = new HighOrLow(r, max, numberToGuess);

            //GuessMe bf = new GuessMe(brute, numberToGuess);
            //GuessMe rg = new GuessMe(g1, numberToGuess);
            GuessMe hl = new GuessMe(hol, numberToGuess);
        }
    }
}
