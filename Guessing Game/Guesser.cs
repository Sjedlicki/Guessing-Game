using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    abstract class Guesser
    {
        public static List<int> numberz = new List<int>();
        public static IEnumerable<int> numbers = Enumerable.Range(1, 100);
        
        public Guesser()
        {

        }

        public abstract int Guess();




    }
}
