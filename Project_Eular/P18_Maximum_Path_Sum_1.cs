using System;
using System.Collections.Generic;
using System.IO;


namespace Project_Eular
{
    class P18_Maximum_Path_Sum_1
    {
        public P18_Maximum_Path_Sum_1()
        {
			string filePath = Directory.GetCurrentDirectory ();
			for(int i = 0; i <= 1; i++)
				filePath = filePath.Substring(0, filePath.LastIndexOf("\\"));
			filePath += "\\Resources\\MaxPath1.txt";

			char[] tokens = { '\r', '\n', ' ' };
			string[] numbers = 
				File.ReadAllText (filePath).Split (tokens, StringSplitOptions.RemoveEmptyEntries);

			int rows = countRows (numbers);
			int[][] pyramidArray = new int[rows][];
			for (int i = 0; i < rows; i++)
				pyramidArray [i] = new int[i + 1];

			for (int i = 0; i < pyramidArray.GetLength (0); i++) {
				for(int j = 0; 
			}
        }

		public static int countRows(string[] numbers)
		{
			int numberOfRows = 0, num = numbers.Length;
			while (num > 0) {
				num -= numberOfRows;
				numberOfRows++;
			}

			return numberOfRows - 1;
		}
    }
}
