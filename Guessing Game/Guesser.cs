using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    abstract class Guesser
    {        
        public Guesser()
        {

        }

        public abstract int Guess();
    }
}
