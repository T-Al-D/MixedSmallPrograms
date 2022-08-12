using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedLibrary
{
    public static class NumCreator
    {
        // returns a random number including lower- and upperBound
        public static int GetRandomNumWithinBound(int lowerBound, int upperBound)
        {
            Random random = new Random();
            int randomNum = random.Next(lowerBound, upperBound + 1);
            return randomNum;
        }
    }
}
