using System;
using System.Collections.Generic;

namespace LabExerciseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> myList = new LinkedList<String>();

            myList.AddFirst("Enzo");
            myList.AddFirst("Vijay");

            myList.RemoveFirst();

            MyStack mystack = new MyStack();

            int[] arr = { 1, 2, 3, 4 };
            mystack.ms = new Stack<int>(arr);

            mystack.ms.Push(5);
            mystack.ms.Pop();
            Console.WriteLine(mystack.ms.Contains(5));

            foreach( var item in mystack.ms)
            {
                Console.WriteLine(item);
            }

            foreach(string str in myList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
