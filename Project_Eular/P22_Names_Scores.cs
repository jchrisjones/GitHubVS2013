using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Eular
{
	class P22_Names_Scores
	{
		public P22_Names_Scores()
		{
			string filePath = Directory.GetCurrentDirectory ();
			for(int i = 0; i <= 1; i++)
				filePath = filePath.Substring(0, filePath.LastIndexOf(@"\"));
			filePath += @"\Resources\p022_names.txt";

			List<string> Names = new List<string> ();

			char[] tokens = { '\r', '\n', ' ', ',', '"' };
			string[] name =
				File.ReadAllText (filePath).Split (tokens, StringSplitOptions.RemoveEmptyEntries);

			Array.Sort (name);
			ulong total = 0;
			uint count = 1;
			foreach (string s in name) {
				uint stringTotal = 0;
				foreach (char c in s) {
					stringTotal += (uint)(c) - 64;
				}
				total += stringTotal * count;
				count++;
			}

			Console.WriteLine (total);

		}
	}
 
}
