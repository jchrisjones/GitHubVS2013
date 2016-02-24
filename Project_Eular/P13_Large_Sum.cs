using System;
using System.IO;
using System.Numerics;

namespace Project_Eular
{
    class P13_Large_Sum
    {
        /** 
         * Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
         */
        public P13_Large_Sum()
        {
            BigInteger solution = new BigInteger(0);
            // Read in and Storing the numbers in a string array

            string filePath = 
                @"C:\Users\Christopher\Documents\Visual Studio 2013\Projects\Project_Eular\Project_Eular\Resources\Numbers.txt";
            string[] numberLines = File.ReadAllLines(filePath);

            BigInteger[] bigIntArray = new BigInteger[numberLines.Length]; 

            for(int i = 0; i < numberLines.Length; i++)
            {
                bigIntArray[i] = BigInteger.Parse(numberLines[i]);
            }

            foreach(BigInteger bigI in bigIntArray)
            {
                solution += bigI;                
            }

            string sol = solution.ToString();
            Console.WriteLine(sol.Substring(0, 10));
        }
    }
}
