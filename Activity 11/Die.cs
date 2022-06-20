using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_11
{
    internal class Die
    {
        //declare private variable numsides
        private int numSides = 0;
        
        //constructor
        public Die(int numSides)
        {
            this.numSides = numSides;
        }

        //determines numSides using rand num from 4-20
        public int GetNumSides()
        {
            Random r = new Random();
            return numSides = r.Next(4, 20);
        }

        //RollDice generates a random number from 1 - the random number generated for the number of sides
        public int RollDice()
        {
            Random rand = new Random();
            return rand.Next(1, GetNumSides());
        }

    }
}
