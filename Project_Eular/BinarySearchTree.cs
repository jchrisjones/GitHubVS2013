using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Eular
{
    class BinarySearchTree
    {
        public Node root;
        
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while(true)
                {
                    parent = current;
                    
                }
            }
        }
    }
}
