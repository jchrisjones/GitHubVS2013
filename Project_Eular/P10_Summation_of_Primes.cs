using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Project_Eular
{
    class P10_Summation_of_Primes
    {
       private static ArrayList primeSieve = new ArrayList();
       private long total = 0;

       public P10_Summation_of_Primes() 
       {
           primeSieve.Add(2);
       }

        public P10_Summation_of_Primes(int number)
        {
            primeSieve.Add(2);
            for(int i = 3; i < number; i += 2)
            {
                if (isPrime(i))
                    primeSieve.Add(i);
            }

            foreach(int i in primeSieve)
            {
                total += i;
            }
            Console.WriteLine(total);
        }

        public static bool isPrime(int testNumber)
        {
            foreach(int i in primeSieve) // Loop through to populated part of the prime sieve
            {
                if (i > (int)Math.Sqrt(testNumber)) // break the loop if the prime is greater than
                    break;                                  // the root of the number being tested.

                if (testNumber % i == 0)            // break the loop if the number being tested
                    return false;
            }
            return true;
        }
    }
}
