using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Eular
{
    class P03_LargestPrimeFactor
        // Calculate the largest prime factor of a big number?
    {
        public P03_LargestPrimeFactor(long bigNumber)
        {
            long highestPrime = 0;
            for(long i = 3; i*i <= bigNumber; i += 2)
            {
                if (bigNumber % i == 0)
                {
                    if (isPrime(i))
                        highestPrime = i;
                }                    
            }
            Console.WriteLine(highestPrime);
        }

        private static bool isPrime(long divisior)
        {
            if(divisior % 2 == 0)
                return false;
            for (long i = 3; i * i <= divisior; i += 2 )
            {
                if (divisior % i == 0)
                    return false;
            }
            return true;
        }
    }
}
