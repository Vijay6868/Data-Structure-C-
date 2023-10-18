using System;

namespace LAB3_1547108_VIJAY_KUMAR
{
    class Test
    {
        /// <summary>
        /// driver code
        /// </summary>
      
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            while (true)
            {
                Console.WriteLine("Enter 'e' to enqueue, 'd' to dequeue, 'p' to peek, 'q' to quit:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "e":
                        Console.WriteLine("Enter the item to enqueue:");
                        if (int.TryParse(Console.ReadLine(), out int item))
                        {
                            queue.Enqueue(item);
                            Console.WriteLine("Item enqueued.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter an integer.");
                        }
                        break;
                    case "d":
                        try
                        {
                            int dequeuedItem = queue.Dequeue();
                            Console.WriteLine("Dequeued item: " + dequeuedItem);
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        break;
                    case "p":
                        try
                        {
                            int frontItem = queue.Peek();
                            Console.WriteLine("Front item: " + frontItem);
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        break;
                    case "q":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }



                Console.WriteLine("Queue count: " + queue.Count);
                Console.WriteLine();
            }
        }
    }
}
