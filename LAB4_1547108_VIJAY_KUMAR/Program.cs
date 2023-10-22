using System;

namespace LAB4_1547108_VIJAY_KUMAR
{// Vijay Kumar 1547108 - LAB4
    class Program
    {
        /// <summary>
        /// dirver code - add integers randomly
        /// search given number (user input) in binary search tree
        /// sorts tree in ascending order
        /// finds smallest and largest value in tree
        /// testing  function
        /// generate random numbers and inserts into tree
        /// </summary>

        static void Main(string[] args)
        {
            Console.WriteLine(">>>>Binary Search Tree Demonstration<<<<");

            BST bst = new BST();
            Console.WriteLine("Integers inserted randomly: ");
            for (int i = 0; i <= 10; i++)
            {
                int num = genRandNum();
                duplicate(bst, num);
                
            }

            Console.WriteLine("max number in Tree:");
            Console.WriteLine(bst.Max());

            Console.WriteLine("min number in Tree:");
            Console.WriteLine(bst.Min());

           
            bst.Sort();
            Console.WriteLine();

            userInput(bst);

        }
        /// <summary>
        /// genrates random number b/w 10 and 99
        /// </summary>
        /// <returns>random number b/w 10 and 99</returns>
        public static int genRandNum()
        {
            Random rd = new Random();
            int num = rd.Next(10, 99);

            

            return num;
        }
        /// <summary>
        /// allows users input
        /// </summary>
        
        public static void userInput(BST bst)
        {

            while (true)
            {
                Console.WriteLine("\nEnter [i] to insert, [f] to find, [l] to find largest number, " +
                "[s] to find smallest number, [sort] to sort the tree, [q] to quit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "i":
                        Console.WriteLine("enter integer value to insert in tree");
                        if (int.TryParse(Console.ReadLine(), out int item))
                        {
                            duplicate(bst, item);
                        }
                        else
                        {
                            Console.WriteLine("invalid input, please enter a integer");
                        }
                        break;
                    case "f":
                        Console.WriteLine("enter a integer to find it in tree");
                        if(int.TryParse(Console.ReadLine(), out int item1))
                        {
                            bool result = bst.Find(item1);
                            printFind(result);
                        }
                        else
                        {
                            Console.WriteLine("invalid input, please enter a integer");
                        }
                        break;
                    case"l":
                        Console.WriteLine(bst.Max());
                        break;
                    case "s":
                        Console.WriteLine(bst.Min());
                        break;
                    case "sort":
                        bst.Sort();
                        break;
                    case "p":
                        Console.WriteLine("Printing in ascending order:");
                        bst.Sort();
                        break;
                    case"q":
                            return;
                    default:
                        Console.WriteLine("invalid choice");
                        break;

                            
                }

            }
        }/// <summary>
        /// display apporpraite message if value found in tree or not
        /// </summary>
        /// <param name="result"></param>
        public static void printFind(bool result) {

            if (result)
            {
                Console.WriteLine("\nValue found in Tree\n");
            }
            else
            {
                Console.WriteLine("\nvalue not found\n");
            }
        }/// <summary>
        /// check duplicate value in tree
        /// </summary>
  
        public static void duplicate(BST bst ,int num)
        {
            bool numExist = bst.Find(num);// check if number already present? to avoid duplication
            if (numExist)// if present display message
            {
                Console.WriteLine("Number already present");
            }
            else// else insert the number
            {

                bst.Insert(num);
                Console.WriteLine(num);
            }
            
        }
    }
}
