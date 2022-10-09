using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class FisherYatesShuffler  // class/methods are static to be used and called upon whenever adding to any existing classes.
    {
        private static Random randomNumber = new Random();  

        public static void DoFisherYatesShuffle(this object[] objects)
        {
            for (int i = objects.Length - 1; i > 0; i--)  // start from the end of array
            {
                objects.SwapValues(i, GetRandomNumber(i)); //swap values from one of the random chosen number that is less then objetcs.length 
            }
        }
        public static void DoFisherYatesAlternateShuffle(this object[] objects)
        {
            for (int i = 0; i < objects.Length - 2; i++)
            {
                int j = GetRandomNumber(objects.Length - i)-1;
                objects.SwapValues(i, i + j);
            }
        }

        private static int GetRandomNumber(int i)
        {
            return randomNumber.Next(i + 1);
        }
    }
}
