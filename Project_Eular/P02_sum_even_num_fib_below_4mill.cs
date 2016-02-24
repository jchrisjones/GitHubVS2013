using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Eular
{
    class P02_sum_even_num_fib_below_4mill
    {
        // Calculate the sum of the even-valued terms in Fibonacci sequence
        public P02_sum_even_num_fib_below_4mill(int maxValue)
        {
            int n = 2;
            int value1 = 1, value2 = 2, sum = 2;
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            while(value2 <= maxValue)
            {
                int temp = value1 + value2;
                value1 = value2;
                value2 = temp;
                n++;
                if (value2 % 2 == 1)
                    sum += value2;

                Console.WriteLine(value2+" sum = " + sum);
            }
            Console.WriteLine("The total of the even-valued terms = " + sum);
 
        }
    }
}
