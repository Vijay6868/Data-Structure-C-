using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_VIJAY_KUMAR_1547108
{
    class MyStack<T>
    {
        private T[] items;
        private int top;

        public MyStack(int storage)
        {
            items = new T[storage];
            top = -1;
        }

        public void Push(T item) // add element to the stack    
        {
            if (top == items.Length - 1)
            {
                throw new InvalidOperationException("Stack reached it's capacity.");
            }

            items[++top] = item;
        }
        /// <summary>
        /// removes last element to stack
        /// if stack empty prints approapraite message
        /// </summary>
        
        public T Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("No items in stack, stack is empty");
            }

            return items[top--];
        }
        /// <summary>
        /// display last value in the stack.
        /// if stack empty prints approapraite message
        /// </summary>
        /// <returns></returns>
        public T Peek()// 
        {
            if (top == -1)
            {
                throw new InvalidOperationException("No items in stack, stack is empty");
            }

            return items[top];
        }
        /// <summary>
        ///  Return true if the stack is empty (top is -1)
        /// </summary>
        
        public bool IsEmpty()
        {
            return top == -1;
        }
        /// <summary>
        /// Reset the top index to -1 to clear the stack
        /// </summary>
        public void Clear()
        {
            top = -1;
        }
     /*
     * This method allows the user to interactively input commands to manipulate the stack.
     * Available commands: 'add', 'pop', 'clear', 'peek', 'finish'.
     * 'add' - prompts the user to enter a value to push onto the stack.
     * 'pop' - removes the top item from the stack and displays it.
     * 'clear' - clears the stack.
     * 'peek' - displays the top item of the stack without removing it.
     * 'finish' - exits the input loop.
     */
        public void UserInput()
        {
            Console.WriteLine("Commands: 'add', 'pop', 'clear', 'peek', 'finsh'");

            while (true)
            {
                Console.WriteLine("Enter a command:");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        Console.WriteLine("Enter a value to push onto the stack:");
                        string input = Console.ReadLine();
                        if (TryParseValue(input, out T value))
                        {
                            Push(value);
                            Console.WriteLine("Value added to the stack.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid value.");
                        }
                        break;

                    case "pop":
                        try
                        {
                            T del = Pop();
                            Console.WriteLine("Removed item: " + del);
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Stack is empty. Unable to remove item.");
                        }
                        break;

                    case "clear":
                        Clear();
                        Console.WriteLine("Stack cleared.");
                        break;

                    case "peek":
                        try
                        {
                            T lastItem = Peek();
                            Console.WriteLine("Top item: " + lastItem);
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Stack is empty.No last item to dislplay");
                        }
                        break;

                    case "finsh":
                        return;

                    default:
                        Console.WriteLine("Invalid command, Try Again");
                        break;
                }
            }
        }
        /// <summary>
        /// method tries to parse the user input string into the specific data type of stack
        /// Returns true if the conversion is successful, and assigns the converted value to the 'value' parameter.
        /// Returns false if the conversion fails.
        /// </summary>

        private bool TryParseValue(string input, out T value)
        {
            value = default(T);

            try
            {
                value = (T)Convert.ChangeType(input, typeof(T));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

