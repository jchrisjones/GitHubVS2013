using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Eular
{
    public class Node
    {
        public int value;
        public Node parentLeft;
        public Node parentRight;
        public List<int> pathScore;
    }
}
