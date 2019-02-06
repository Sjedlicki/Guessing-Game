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
            Guesser g1 = new RandomGuesser();
            Guesser brute = new BruteForce();
            Random r = new Random();
            int num = r.Next(1, 100);
            int guess = r.Next(1, 100);
            int count = 1;
            int count2 = 1;

            //Console.ReadKey();

            while (num != guess)
            {
                guess = r.Next(1, 100);
                count++;
            }
            Console.WriteLine($"Real number: {num}");
            Console.WriteLine($"Random Tries: {count}");

            Console.WriteLine(brute.Guess());
            while (num != brute.Guess())
            {
                brute.Guess();
                count2++;
            }
            Console.WriteLine($"Real number {num}");
            Console.WriteLine($"Brute Force Tries: {count2}");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        //public static int GetNumber(int min, int max)
        //{
        //    Random r = new Random();
        //    return r.Next(min, max);
        //}
    }
}
