using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Node1
    {
        public int value;
        public Node1 left;
        public Node1 right;

        public void show()
        {
            Console.Write("[");
            Console.Write(value);
            Console.Write("]"); 
        }
    }
}
