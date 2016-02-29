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
			for (int i = 0; i <= 1; i++)
				filePath = filePath.Substring (0, filePath.LastIndexOf ("\\"));
			filePath += "\\Resources\\triangle.txt";

			char[] tokens = { '\r', '\n', ' ' };
			string[] numbers =
				File.ReadAllText (filePath).Split (tokens, StringSplitOptions.RemoveEmptyEntries);
			int[] pyramidArray = new int[numbers.Length];
			for(int i = 0; i < numbers.Length; i++)
				pyramidArray[i] = Int32.Parse(numbers[i]);

			int rows = 0, elements = pyramidArray.Length;

			while (elements > 0) {
				elements -= rows;
				rows++;
			}
			rows -= 1;

			Array.Reverse (pyramidArray);

			Console.WriteLine(calcMaxPath(pyramidArray, rows));

		}

		public static int calcMaxPath(int[] array, int rows)
		{
			int iterator = 0;
            int[] maxPathArray = new int[array.Length];			

			for (int i = 0; i < rows; i++) {
                maxPathArray[i] = array[iterator];
				iterator++;
			}

			for (int i = rows - 1; i >= 0; i--) 
            {
			    for(int j = 0; j < i; j++)
                {
                    int tempMax1 = array[iterator] + maxPathArray[iterator - (i + 1)];
                    int tempMax2 = array[iterator] + maxPathArray[iterator - i];
                    maxPathArray[iterator] = Math.Max(tempMax1, tempMax2);
                    iterator++;
                }
			}

            return maxPathArray[maxPathArray.Length - 1];

		}

	}
}

			/*

			Node[][] pyramidArray = new Node[100][];
			for (int i = 1; i <= 100; i++)
				pyramidArray [i - 1] = new Node[i];

			int numbersCount = 0; 

			for (int i = 0; i < pyramidArray.Length; i++) {
				for (int j = 0; j < pyramidArray[i].Length; j++) {
					pyramidArray [i] [j] = new Node(Int32.Parse(numbers [numbersCount]));
					if (i == pyramidArray.Length - 1)
						pyramidArray [i] [j].pathScore.Add (pyramidArray [i] [j].value);
					numbersCount++;
					//Console.Write (pyramidArray[i][j].value + " ");
				}
				//Console.WriteLine ();
			}

			Console.WriteLine (calcMaxPath (pyramidArray));
        }

		public static int calcMaxPath(Node[][] pArray)
		{
			Node n_null = new Node (0);
			for (int i = pArray.Length - 2; i >= 0; i--) {
				for (int j = 0; j < pArray [i].Length; j++) {
					for(int v = 0; v < pArray[i+1][j].pathScore.Count; v++) {
						pArray [i] [j].pathScore.Add (pArray [i] [j].value + pArray[i+1][j].pathScore[v]);

					}
					for(int v = 0; v < pArray[i+1][j+1].pathScore.Count; v++) {
						pArray [i] [j].pathScore.Add (pArray [i] [j].value + pArray[i+1][j+1].pathScore[v]);
						}
				}
				for (int j = 0; j < pArray [i].Length; j++) {
					pArray [i + 1] [j] = n_null;
					pArray [i + 1] [j + 1] = n_null;
					GC.Collect ();
					GC.WaitForPendingFinalizers ();
				}
			}
			pArray[0][0].pathScore.Sort();
			return pArray [0] [0].pathScore [pArray [0] [0].pathScore.Count - 1];
		}
		*/
