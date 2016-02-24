using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Eular
{
    class P04_LargestPalindrome
    {
        public P04_LargestPalindrome()
        {
            int largestPal = 0;
            for (int i = 100; i <= 999; i++)
            {
                for (int j = i; j <= 999; j++)
                {
                    if (isPalendrome(i * j) && (i*j > largestPal))
                        largestPal = i * j;
                }
            }
            Console.WriteLine(largestPal);
        }

        private bool isPalendrome(int p)
        {
            
            string r = p.ToString();
            string s = "";

            for (int i = r.Length - 1; i >= 0; i--)
                s += r[i];

            if (r.CompareTo(s) != 0)
                return false;
            return true;
        }
    }


}
