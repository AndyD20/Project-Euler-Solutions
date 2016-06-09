using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /*
     * A palindromic number reads the same both ways. 
     * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
     * Find the largest palindrome made from the product of two 3-digit numbers.
     * 
     * */
    class Problem_4
    {

        public static void run()
        {
            int result = searchForPalindrome();

            if (result != 0)
            {

                Console.Write(result + " ");
            } 
            else
            {

                Console.Write("Failed");
            }
        }


        // Searches through all products of 3-digit numbers to find largest palindromic number
        private static int searchForPalindrome()
        {

            int result = 0;

            for (int num1 = 999; num1 > 0; num1--)
            {
                for (int num2 = 999; num2 > 0; num2--)
                {
                    int num2check = num1 * num2;

                    if (isPalindrome(num2check) && num2check > result)
                    {
                        result = num2check;
                    }
                }
            }

            return result;

        }


        // Checks if parameter is a palindromic number
        private static bool isPalindrome(int number)
        {
            if (number == reverseInt(number))
            {
                return true;

            }
            else
            {
                return false;
            }
        }


        // Returns a back to front version of the parameter
        private static int reverseInt(int num2Rev)
        {
            int result = 0;
            while (num2Rev > 0)
            {
                result = result * 10 + num2Rev % 10;
                num2Rev /= 10;
            }
            return result;
        }
    }
}
