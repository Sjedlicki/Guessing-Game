using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    abstract class Guesser
    {
        public int x;
        public int Min;
        public int Max;
        public Guesser()
        {

        }

        public abstract int Guess();

        public void Reset(int max)
        {
            x = max - 1;          
        }

        public void ResetMinMax(int min, int max)
        {
            this.Min = min;
            this.Max = max;
        }
    }
}
