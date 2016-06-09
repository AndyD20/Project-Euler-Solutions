using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /*
     * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
     * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
     * 
     * */
    class Problem_5
    {

        public static void run()
        {
            // Time data gathered at start and end for benchmarking purposes
            DateTime before = DateTime.Now;

            // Arbitrarily high number to stop searching at
            long result = 300000000;

            //Search for values that divide evenly by all numbers 1-20, if one is found, search is stopped
            for (long i = 1; i < 300000000; i++)
            {
                if (remainderCheck(i) && i < result)
                {
                    result = i;
                    break;
                }
            }

            DateTime after = DateTime.Now;

            Console.Write(result + "\n" + "Operation took: " + after.Subtract(before) + " ");
        }


        // Checks that the parameter is evenly divisible by 1-20
        private static bool remainderCheck(long toCheck)
        {
            bool result = true;
            if ((toCheck % 20 != 0) || (toCheck % 19 != 0) || (toCheck % 18 != 0) || (toCheck % 17 != 0) || (toCheck % 16 != 0) || (toCheck % 15 != 0) || (toCheck % 14 != 0) || (toCheck % 13 != 0) || (toCheck % 12 != 0) || (toCheck % 11 != 0) || (toCheck % 10 != 0) || (toCheck % 9 != 0) || (toCheck % 8 != 0) || (toCheck % 7 != 0) || (toCheck % 6 != 0) || (toCheck % 5 != 0) || (toCheck % 4 != 0) || (toCheck % 3 != 0) || (toCheck % 2 != 0) || (toCheck % 1 != 0))
            {
                result = false;
            }
            return result;
        }
    }
}
