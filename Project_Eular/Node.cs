using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Eular
{
    public class Node
    {
        public int value;       
        public List<int> pathScore;

		public Node(int i)
		{
			value = i;
			pathScore = new List<int> ();
		}
    }
}
