using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitAssignment
{
    class Tests
    {
        static public void RunTests()
        {
            Console.WriteLine("Tests");
            Console.WriteLine("3 is prime: " + isPrime(3).ToString());
            Console.WriteLine("4 is prime: " + isPrime(4).ToString());
            Console.WriteLine("11 is prime: " + isPrime(11).ToString());
            Console.WriteLine("12 is prime: " + isPrime(12).ToString());
            Console.WriteLine("7561 is prime: " + isPrime(7561).ToString());
        }


        static bool isPrime(long n)
        {
            if (n <= 3)
            {
                return n >= 2;
            }
            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            for (int i = 5; i <= Math.Sqrt(n) + 1; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
