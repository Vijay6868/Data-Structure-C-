using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_1547108_VIJAY_KUMAR
{
    public class BST
    {
        private Node root;
        private class Node // inner node class to show in the tree
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int value)
            {
                this.value = value;
                left = null;
                right = null;
            }
            
        }
        public BST()
        {
            root = null;
        }

        public void Insert(int value)// inserting new node with given value in tree
        {
            Node newNode = new Node(value);

            if(root == null)// while tree is empty, new node will be root node
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;

                while (true)// identifiying the correct position for the new node through transverse
                {
                    parent = current;

                    if(value < current.value)
                    {
                        current = current.left;

                        if(current == null)// if reached to leaf node, insert the new node here
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;

                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// transverse through left and right node unitl reach to leaf node
        /// initial node is root node
        /// </summary> 
        /// <returns>present value else false</returns>
        public bool Find(int value)
        {
            Node current = root;

            while(current != null) // unitl it doesn't reach to leaf node
            {
                if(value == current.value)
                {
                    return true;
                }
                else if(value < current.value) 
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }
            return false;
            

        }
        /// <summary>
        /// inorder traverse to sort values in binary search tree
        /// Initial node value is root
        /// </summary>
        
        private void InorderTraversal(Node node)
        {
            if (node != null)
            {
                
                InorderTraversal(node.left);
                Console.Write(node.value + " ");

                
                InorderTraversal(node.right);
            }
        }
        public void Sort()
        {
            InorderTraversal(root);
        }
       /// <summary>
       /// tranverse through right nodes until reaches leaf node
       /// </summary>
       /// <returns>maximum value in binary search tree </returns>
        public int Max()
        {
            if (root == null)
            {
                throw new Exception("Tree is empty");
            }

            Node current = root;

            while (current.right != null)
            {
                current = current.right;
            }

            return current.value;
        }
        /// <summary>
        /// tranverse through left nodes until reaches leaf node
        /// </summary>
        /// <returns>minimum value in binary search tree </returns>
        public int Min()
        {
            if (root == null)
            {
                throw new Exception("Tree is empty");
            }

            Node current = root;

            while (current.left != null)
            {
                current = current.left;
            }

            return current.value;
        }
       
    } 

   
}
