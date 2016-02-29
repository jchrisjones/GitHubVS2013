using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Project_Eular
{
	class P20_Factorial_Digit_Sum
	{
		public P20_Factorial_Digit_Sum()
		{
			BigInteger bi = new BigInteger (100);
			BigInteger bi1;
			for(int i = 99; i >= 1; i--)
			{
				bi1 = new BigInteger (i);
				bi = BigInteger.Multiply (bi, bi1);
			}
			int answer = 0;
			string factorial100 = bi.ToString ();
			for (int i = 0; i < factorial100.Length; i++)
				answer += Int32.Parse (factorial100 [i].ToString());

			Console.WriteLine (answer);
		}
	}
 
}
