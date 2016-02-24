using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Project_Eular
{
    class P06_SumSquareDifference
    {
        public P06_SumSquareDifference(int numbers)
        {
            ulong sumOfSquares = 0;
            ulong squareOfSums = 0;
            ulong solution = 0;

            for(uint i = 1; i <= numbers; i++)
            {
                sumOfSquares += (ulong)Math.Pow(i, 2);
                squareOfSums += i;
            }
            squareOfSums = squareOfSums * squareOfSums;
            solution = squareOfSums - sumOfSquares;

            Console.WriteLine(solution);

        }
    }
}
