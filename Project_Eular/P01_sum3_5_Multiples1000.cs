using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Eular
{
    class P01_sum3_5_Multiples1000
        // This problem is to find all the multipules of 3 and 5 below 1000.
    {
        public P01_sum3_5_Multiples1000(int multi1, int multi2, int scope)
        {
            int sum1 = this.sumOfMultiple(multi1, multi2, scope);
           
            Console.WriteLine("The sum of multipules {0} and {1} below {2} is {3}", multi1, multi2, scope, sum1);
        }

        public int sumOfMultiple(int multiple1, int multiple2, int range)
        {
            int sum = 0;
            for (int i = 0; i < range; i++)
            {
                if ( ((i % multiple1 == 0) || (i % multiple2 == 0))) 
                    sum += i;
            }
                return sum;
        }
    }
}
