using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Eular
{
    class P09_Pythagorean_Triplet
    {
        public P09_Pythagorean_Triplet()
        {
            int c = 0;
            int cSquared = 0;
            bool a_Plus_B_Plus_C_equal_1000 = false;

            for(int a = 1; a <= 334; a++)
            {
                for(int b = a + 1; b <= 335 + 2; b++)
                {
                    cSquared = (a * a) + (b * b);
                    c = (int)Math.Sqrt(cSquared);
                    
                    Console.WriteLine(a + b + c);

                    if(cSquared % c == 0 && a + b + c == 1000)
                    {
                        Console.WriteLine(a * b * c);
                        a_Plus_B_Plus_C_equal_1000 = true;
                        break;
                    }                    
                }
                if(a_Plus_B_Plus_C_equal_1000)
                        break;
            }
        }
    }
}
