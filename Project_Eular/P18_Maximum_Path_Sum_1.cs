using System;
using System.Collections.Generic;
using System.IO;


namespace Project_Eular
{
    class P18_Maximum_Path_Sum_1
    {
        public P18_Maximum_Path_Sum_1()
        {
            string filePath = Directory.GetCurrentDirectory();
            for (int i = 0; i <= 1; i++)
                filePath = filePath.Substring(0, filePath.LastIndexOf("\\"));
            filePath += "\\Resources\\MaxPath1.txt";

            char[] tokens = { '\r', '\n', ' ' };
            string[] numbers =
                File.ReadAllText(filePath).Split(tokens, StringSplitOptions.RemoveEmptyEntries);

            BinarySearchTree nums = new BinarySearchTree();
            foreach(string s in numbers)
            {
                nums.Insert(Int32.Parse(s));
            }
        }
    }
}
