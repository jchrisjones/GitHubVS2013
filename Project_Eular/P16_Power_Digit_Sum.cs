using System;
using System.Numerics;

namespace Project_Eular
{
	public class P16_Power_Digit_Sum
	{
		public P16_Power_Digit_Sum()
		{
			int sum = 0;
			string power = "";
			BigInteger bigI = new BigInteger (2);
			bigI = BigInteger.Pow (bigI, 1000);

			power = bigI.ToString ();
			for (int i = 0; i < power.Length; i++)
				sum += Int32.Parse (power.Substring (i, 1));
			Console.WriteLine (sum);
		}

	}

}
