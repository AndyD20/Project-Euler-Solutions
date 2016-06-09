using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /* Project Euler problem 1:
     * 
     * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
     * The sum of these multiples is 23.
     * Find the sum of all the multiples of 3 or 5 below 1000.
     * 
     */
    class Problem_1
    {
        public static void run()
        {
            int result = 0;

            
            for (int i = 1; i < 1000; i++)
            {
                // Filter i by remainder, if remainder is 0 when divided by 3 or 5, value is kept and added to result.
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    result += i;
                }
            }

            Console.Write(" " + result + " ");

        }
    }
}
