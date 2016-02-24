using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Eular
{
    class P05_SmallestMultiple
    // Calculate the smallest positive number that is evenly divisible by all of the numbers from 1 to 20
    {
        public P05_SmallestMultiple()
        {
            /**
             * a) Using the LCM algorithm to see which number has the highest multiple of a prime as
             * its factors, ie 16 can be divided by 2 four times which is the greatest amount in 
             * numbers 1 - 20. 
             * b) Raise that prime to its multiple ie 2^4 and multiply it to the running total LCM
             * 
             * c) Then do the same with the next prime 3 an so on up to the highest 
             * prime number in the set.
             * 
             * d) Finally print out the LCM
             * 
             */
            int[] primeArray = { 2, 3, 5, 7, 11, 13, 17, 19 }; // all the primes in the set 1 - 20
            long lcm = 1; // Initialise the LCM of 1 to 1
            int max = 0; // placeholder of the highest occurence of the current prime being tested
            int number = 0; // Aid debugging

            for(int i = 0; i < primeArray.Length; i++) // loop through each prime
            {
                for(int j = 2; j <= 20; j++) // loop through set, checking each number against its prime
                {
                    int count = 0;
                    int divisor = j;
                    while(divisor % primeArray[i] == 0) // while loop to count the number of times the prime                    
                    {                                   // will divide into the number
                        divisor /= primeArray[i];
                        count++;
                    }
                    if (count > max)    // if statment to record the maximum number of times the prime divides into
                    {                   // a number in the set
                        max = count;
                        number = j;
                    }
                }
                Console.Write("Max number of {0}'s was {1} and it was in number {2}\n", primeArray[i], max, number);
                lcm *= (long)Math.Pow(primeArray[i], max); // running total of LCM of 1; then 1,2; then 1,2,3 etc
                max = 0;
            }

            Console.WriteLine(lcm);
        }
    }
}
