using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Eular
{
    class P07_10001st_Prime
    {
        public P07_10001st_Prime(int testNumber)
        {
            // declare values
            int counter = 0;                     // counter to the 
            int number = 0;                      // value of the number being tested
            int[] primeArray = new int[testNumber + 1];   // array to store the primes
            bool isPrime = false;                // boolean flag to register wheather a number is prime

            // initialise values
            primeArray[1] = 2;
            primeArray[2] = 3;
            primeArray[3] = 5;
            counter = 3;
            number = 7;
            isPrime = true;

            while (counter < testNumber)  // while loop to reach the 10,001st Prime
            {
                for(int i = 1; i <= counter; i++) // Loop through to populated part of the prime sieve
                {
                    if (primeArray[i] > (int)Math.Sqrt(number)) // break the loop if the prime is greater
                        break;                                  // the number being tested

                    if (number % primeArray[i] == 0)            // break the loop if the number being tested
                    {                                           // is a factor of the existing known primes.
                        isPrime = false;
                        break;
                    }
                }

                // Console.WriteLine(counter);
                if(isPrime)
                {
                    counter++;
                    primeArray[counter] = number;
                }
                number += 2;
                isPrime = true;
            }

            Console.WriteLine(primeArray[testNumber]);
        }
    }
}
