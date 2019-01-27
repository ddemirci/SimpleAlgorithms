using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    public static class RecursiveAlgorithms
    {

        public static double power(int a, int b) // returns a^b
        {
            if (b < 0)
                return (double)1 / power(a, b * (-1));
            else if (b == 0)
                return 1;
            else
            {
                double result = power(a, b / 2);
                if (b % 2 == 1)
                    return result * result * a;
                else
                    return result * result;
            }
        }

        public static int numberOfDigits(int num) //returns the number of digits in num
        {
            if (num / 10 == 0)
                return 1;
            else
                return 1 + numberOfDigits(num / 10);
        }

        public static int gcd(int a, int b) //returns the greatest common divisor of a & b
        {
            if (a == 1 || b == 1)
                return 1;

            while (a != b)
            {
                if (a > b)
                    return gcd(a - b, b);
                else
                    return gcd(a, b - a);
            }
            return a;
        }

        public static bool isPalindrome(string str)
        {
            if (str.Length <= 1)
                return true;
            else if (String.Equals(str.Substring(0, 1), str.Substring(str.Length - 1), StringComparison.OrdinalIgnoreCase))
                return isPalindrome(str.Substring(1, str.Length - 2));
            else
                return false;
        }

        public static long factorial(int number)
        {
            if (number < 0)
                return 0;
            else if (number <= 1)
                return 1;
            else
                return number * factorial(number - 1);
        }

        public static int fibonacci(int term)
        {
            if (term == 1)
                return 1;
            else if (term == 2)
                return 1;
            else
                return fibonacci(term - 1) + fibonacci(term - 2);
        }
    }
}
