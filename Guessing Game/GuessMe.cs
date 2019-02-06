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
            Play(player.Guess());
        }

        public void Play(int guess)
        {
            Random r = new Random();
            int num1 = r.Next(1, max);
            //int num2 = r.Next(1, max);

            Console.WriteLine($"Number to guess: {num1}");
            Console.WriteLine($"This is my guess: {guess}");
            while (num1 != guess)
            {
                player.Guess();
                Console.WriteLine("Testing: "+player.Guess());
                
                attemps++;
            }
            Console.WriteLine($"You win: {attemps}");
            Console.ReadKey();
        }

        //public bool Correct()
        //{
        //    for (int i = 0; i < max; i++)
        //    {
        //        if ()
        //        {
        //            return false;
        //        }
        //    }
        //    Console.WriteLine(");
        //    return true;
        //}
    }
}
