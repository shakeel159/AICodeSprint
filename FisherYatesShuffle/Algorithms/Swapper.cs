using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Swapper
    {
        public static void SwapValues(this object[] objects, int i, int j)
        {
            // this bit of code swaps current value i position holds with value of what positon j holds.
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
    }
}
