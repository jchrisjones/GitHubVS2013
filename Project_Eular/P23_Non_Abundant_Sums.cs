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
			ushort[] allNumbers = new ushort[28124];
			for (int i = 0; i < allNumbers.Length; i++)
				allNumbers [i] = (ushort)i;

			List<ushort> abundant = new List<ushort> ();

			for (int i = 12; i <= 28124; i++) {
				int count = 1;
				for (int j = 2; j * j < i; j++) {
					if ((((double)i / (double)j) - (i/j)) !=  0.0) {
						count += j;
						count += (i / j);
					}
					if (count > i && count < 28123) {						
							abundant.Add ((ushort)count);
					}
				}
			}

			Console.WriteLine ("Here");
			Console.WriteLine (abundant.Count);

			for (int i = 0; i < abundant.Count; i++) {
				for (int j = i; j < abundant.Count; j++) {
					int temp = abundant [i] + abundant [j];
					if (temp > 28123)
						continue;
					else
						allNumbers [temp] = 0;
				}

			}
			ulong totaling = 0;
			for (int i = 0; i < allNumbers.Length; i++) {
				totaling += allNumbers [i];
			}
			Console.WriteLine (totaling);
		}
	}
 
}
