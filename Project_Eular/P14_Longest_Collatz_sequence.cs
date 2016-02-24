using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Eular
{
    class P14_Longest_Collatz_sequence
    {
        public P14_Longest_Collatz_sequence(int numberToIterateTo)
        {
            int counter = 0, maxValue = 0;           

            for (int i = 2; i <= numberToIterateTo; i++ )
            {
                //Console.Write(i);
                int result = chainLength(i);

                if (result > counter)
                {
                    counter = result;
                    maxValue = i;
                    //Console.WriteLine(i);
                }
            }

            Console.WriteLine("\nThe number {0} has the biggest Collatz chain and is {1} numbers long.", maxValue, counter);                
        }

        private int chainLength(int startingValue)
        {
            int privateCounter = 1;
            uint currentValue = (uint)startingValue;

            while (currentValue != 1)
            {
                privateCounter++;

                if ((currentValue & 1) == 0)
                {
                    currentValue >>= 1;
                }
                else
                {
                    currentValue = (3 * currentValue) + 1;
                }
                
               // Console.Write(" -> " + currentValue);
            }
            //Console.WriteLine();
            return privateCounter;
        }
    }
}
