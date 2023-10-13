using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Tree
    {
        public Node1 root;

        public Tree()
        {
            root =null;
        }
        public Node1 ReturnRoot()
        {
            return root;
        }
        public void Insert(int x)
        {
            Node1 newNode = new Node1();
            newNode.value = x;

            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Node1 current = root;
                Node1 parent ;

                while (true)
                {
                    parent = current;
                }
            }
        }
    }
}
