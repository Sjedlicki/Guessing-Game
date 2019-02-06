using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    abstract class Guesser
    {
       // public List<string> guess = Enumerable.Range(1, 100).ToString();

        public abstract int Guess();
    }
}
