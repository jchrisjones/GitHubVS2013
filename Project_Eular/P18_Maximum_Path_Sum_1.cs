using System;
using System.Collections.Generic;
using System.IO;


namespace Project_Eular
{
    class P18_Maximum_Path_Sum_1
    {
        public P18_Maximum_Path_Sum_1()
        {
            string filePath = @"C:\Users\Christopher\Documents\Visual Studio 2013\Projects\Project_Eular\Project_Eular\Resources\MaxPath1.txt";
            string pyramidString = File.ReadAllText(filePath);

            char[] splitTokens = { ' ', '\n', '\r' };
            string[] splitPyramidString = pyramidString.Split(splitTokens, StringSplitOptions.RemoveEmptyEntries);

            int numOfRows = 0;
            int numOfItems = splitPyramidString.Length;
            int c = 1;

            while(numOfItems > 0)
            {                
                numOfItems -= c;
                c++;                
            }
            numOfRows = c - 1;
                       
            int count = 0;
            c = 0;
            int[,] pyramidIntArray = new int[15, 15];

            
            for(int i = 0; i < pyramidIntArray.GetLength(0); i++)
            {
                for(int j = 0; j < count; j++)
                {
                    pyramidIntArray[i, j] = Int32.Parse(splitPyramidString[count]);
                    c++;
                }
                count++;
            }

            count = 0;
            for (int i = 0; i < pyramidIntArray.GetLength(0); i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(pyramidIntArray[i, j] + " ");                    
                }
                Console.WriteLine();
                count++;
            }
        }
    }
}
