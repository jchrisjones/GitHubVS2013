using System;
using System.Collections;

namespace Project_Eular
{
	class p21_Amicable_Numbers
	{
		public p21_Amicable_Numbers()
		{
			int[,] an = new int[10000,2];
			int amNumsCount = 0;

			for (int i = 1; i < 10000; i++) {
				int sumOfDivisors = 1;
				for (int j = 2; j * j < i; j++) {
					if (i % j == 0) {
						sumOfDivisors += j;
						sumOfDivisors += (i / j);
					}
					an[i,0] = i;
					an [i, 1] = sumOfDivisors;
				}
			}

			for (int i = 1; i < 10000; i++) {
				int an2 = an[i,1];
				if (an2 < 10000 && an [an2, 1] == i && i < an2) {
					amNumsCount += (i + an2);
				}
			}
			Console.WriteLine (amNumsCount);
		}
	}
 
}
