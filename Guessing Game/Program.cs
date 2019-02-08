using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        public static int attempts;
        public static List<int> tries = new List<int>();
        public static int numberToGuess;        

        static void Main(string[] args)
        {
            int batch = 100;
            int min = 1;
            int max = 101;
            int wins = batch;
            int count = 0;

            Random r = new Random();
            numberToGuess = r.Next(1, max);


            Guesser g1 = new RandomGuesser(r, max);
            Guesser brute = new BruteForce();
            Guesser hol = new HighOrLow(r, numberToGuess);

            wins = batch;
            count = 0;
            while (wins > 0)
            {
                hol.ResetMinMax(min, max);
                GuessMe hl = new GuessMe(hol, numberToGuess);
                numberToGuess = GenerateNumber(r, max);
                hol = new HighOrLow(r, numberToGuess);
                Tracking();
                wins--;
                count++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("High or Low");
            Console.WriteLine($"Wins: {count}");
            Stats();

            wins = batch;
            count = 0;
            while (wins > 0)
            {
                brute.Reset(max);
                GuessMe bf = new GuessMe(brute, numberToGuess);
                numberToGuess = GenerateNumber(r, max);
                Tracking();
                wins--;
                count++;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("BruteForcer");
            Console.WriteLine($"Wins: {count}");
            Stats();

            wins = batch;
            count = 0;
            while (wins > 0)
            {
                GuessMe rg = new GuessMe(g1, numberToGuess);
                numberToGuess = r.Next(1, max);
                Tracking();
                wins--;
                count++;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine($"Random Guesser");
            Console.WriteLine($"Wins: {count}");
            Stats();



            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static int GenerateNumber(Random r, int max)
        {
            numberToGuess = r.Next(1, max);
            return numberToGuess;
        }

        public static void Tracking()
        {
            attempts = GuessMe.tries;
            tries.Add(attempts);
            //GuessMe.attempted.Clear();
            GuessMe.tries = 0;
        }

        public static void Stats()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Random attempts: {tries.Sum()}");
            Console.WriteLine($"Best Case: {tries.Min()}");
            Console.WriteLine($"Worse Case: {tries.Max()}");
            Console.WriteLine($"Average case: {tries.Average()}");
            tries.Clear();
            //GuessMe.attempted.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
