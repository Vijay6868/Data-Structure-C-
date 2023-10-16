using System;
// student id - 1547108
namespace LAB2_VIJAY_KUMAR_1547108
{/// <summary>
/// driver code
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>(3);
            myStack.UserInput();

            Console.WriteLine("Stack before clearing:");
            while (!myStack.IsEmpty())
            {
                Console.WriteLine(myStack.Pop());
            }

            myStack.Clear();

            Console.WriteLine("Stack after clearing:");
            while (!myStack.IsEmpty())
            {
                Console.WriteLine(myStack.Pop());
            }
        }
    }
}
