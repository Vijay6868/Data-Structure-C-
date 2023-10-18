using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_1547108_VIJAY_KUMAR
{
    class Queue<T>
    {
        private class Node
        {
            public T Data { get; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node front; // Reference to the front node of the queue
        private Node rear; // Reference to the rear node of the queue

        public int Count { get; private set; } // Number of items in the queue

        public Queue()
        {
            front = null;
            rear = null;
            Count = 0;
        }

        public void Enqueue(T item)
        {
            Node newNode = new Node(item);

            if (rear == null)
            {
                // If the queue is empty, set both front and rear to the new node
                front = newNode;
                rear = newNode;
            }
            else
            {
                // Otherwise, add the new node to the rear of the queue
                rear.Next = newNode;
                rear = newNode;
            }

            Count++;
        }

        public T Dequeue()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T dequeuedItem = front.Data;
            front = front.Next;

            if (front == null)
            {
                // If front becomes null after dequeuing, the queue is now empty
                rear = null;
            }

            Count--;
            return dequeuedItem;
        }

        public T Peek()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            // Return the data of the front node without dequeuing it
            return front.Data;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }
    }
}
