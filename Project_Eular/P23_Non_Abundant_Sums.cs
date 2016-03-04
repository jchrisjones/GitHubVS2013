using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Eular
{
	class P23_Non_Abundant_Sums
	{
		public P23_Non_Abundant_Sums()
		{
            int max = 20161;
			uint[] allNumbers = new uint[max + 1];
            int count = 0;
            List<uint> abundant = new List<uint> ();
            List<uint> abundantSums = new List<uint>();
            ulong sum = 0;
                       
			for (int i = 0; i < allNumbers.Length; i++)
				allNumbers [i] = (uint)i;
            

			for (int i = 12; i < max + 1; i++) {
                count = 1;
                for (int j = 2; j * j <= i; j++) {
					if (i % j == 0) {
						count += j;
                        if(!(j == i/j))
						count += (i / j);
					}					
				}
                if (count > i)
                {
                    abundant.Add((uint)i);
                }
			}
            
            foreach(uint ai in abundant)
            {
                foreach(uint aj in abundant)
                {
                    abundantSums.Add(ai + aj);                   
                }
            }
            abundantSums = abundantSums.Distinct().ToList();
            abundantSums.Sort();

            foreach (uint us in abundantSums)
            {
                if (us <= max)
                    allNumbers[us] = 0;

            }
            foreach (uint us in allNumbers)
            {                
                sum += us;
            }
            Console.WriteLine(sum);
            
		}
	}
 
}
