using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Eular
{
    class P12_Highly_divisible_triangular_number
    {
        public P12_Highly_divisible_triangular_number()
        {
            bool doesTriangleNumberHave500divisors = false;
            int nthTriangleNumber = 8;                      // start searching triangle numbers from the 8th one.
            int valueOfnthTriangleNumber = 0;

            while(!doesTriangleNumberHave500divisors)
            {
                valueOfnthTriangleNumber = 0;
                for (int i = 1; i <= nthTriangleNumber; i++)
                    valueOfnthTriangleNumber += i;

                doesTriangleNumberHave500divisors = this.checkNumberOfDivisors(valueOfnthTriangleNumber);
                nthTriangleNumber++;
            }
            Console.WriteLine(valueOfnthTriangleNumber);
        }

        private bool checkNumberOfDivisors(int valueOfnthTriangleNumber)
        {
            int v = valueOfnthTriangleNumber;
            int numberOfDivisors = 0;
            for (int i = 1; i * i <= v; i++)
            {
                if (v % i == 0)
                    numberOfDivisors++;
            }
            numberOfDivisors *= 2;
            //Console.WriteLine(numberOfDivisors);
            if(numberOfDivisors > 500)
                return true;
            return false;
        }
    }
}
