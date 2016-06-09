using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /*
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143 ?
     * 
     * */
    class Problem_3
    {
        public static void run()
        {
            // Target number to find largest prime factor for
            long targetNumber = 600851475143;

            // Arbitrarily high number to begin searching from
            long primeFactor = 5000000;

            bool flag = false;
            while (!flag)
            {
                // If the target number is evenly divisible by the primeFactor number and the primeFactor number is a prime number;
                // primeFactor is printed to console as the result
                if (targetNumber != primeFactor && targetNumber % primeFactor == 0 && isPrime(primeFactor))
                {
                    Console.Write(primeFactor + " ");
                    flag = true;
                    
                }

                // Ensures the program ends if primeFactor reaches 0, stops infinite looping
                if (primeFactor <= 0)
                {
                    flag = true;
                }
                primeFactor--;
            }
        }

        // Determines if parameter is a prime number
        private static bool isPrime(long num2Check)
        {
            if (num2Check == 1)
            {
                return false;
            }
            else if (num2Check == 2)
            {
                return true;
            }
            else if (num2Check % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i*i <= num2Check; i += 2)
                {
                    if (num2Check % i == 0)
                    {
                        
                        return false;
                    }
                }
                Console.Write(num2Check + " ");
                return true;
            }

            
        }
        
    }
}
