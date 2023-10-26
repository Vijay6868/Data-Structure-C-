using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_1547108_VIJAY_KUMAR
{
    internal class MaxHeap<T> where T : IComparable<T>
    {
        private T[] heapArray;  // Array to store the heap elements
        private int size;      // Current size of the heap
        /// <summary>
        ///Initialize the heap array
        ///Initialize the size to 0
        /// </summary>
        
        public MaxHeap(int capacity)
        {
            heapArray = new T[capacity];  
        }
        /// <summary>
        /// returns current size of the heap
        /// </summary>
        public int Count => size;

        public void Insert( T item)
        {
            if(size == heapArray.Length)
            {
                throw new InvalidOperationException("Heap is full");

            }
            heapArray[size] = item;
            HeapifyUp(size);
            size++;
        }

        public T Remove()
        {
            if (size == 0) 
            {
                throw new InvalidOperationException("Heap is empty");// display message if heap is empty
            }

            T root = heapArray[0]; // store the 1st element of heap in root
            heapArray[0] = heapArray[size - 1]; // replace root element with last
            size--;// reduce the size of heap;
            HeapifyDown(0);// restore the max heap property by moving the new root value down

            return root;
        }
        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;  // Calculate the parent index of the current element

                // Compare the current element with its parent and swap if necessary to maintain the max heap property
                if (heapArray[parentIndex].CompareTo(heapArray[index]) > 0)
                    break;

                Swap(parentIndex, index);  // Swap the parent and current elements
                index = parentIndex;       // Move up to the parent index
            }
        }
        private void HeapifyDown(int index)
        {
            while (index < 0)
            {
                int leftChild = 2 * index + 1;// calculate the index of left child
                int rightChild = 2 * index + 2;//calculate the index of right child
                int largest = index;


                // Compare the left child with the current element and update the largest index if necessary
                if (leftChild< size && heapArray[leftChild].CompareTo(heapArray[rightChild]) > 0)
                {
                    largest = leftChild;
                }

                // Compare the right child with the current element and update the largest index if necessary
                if (rightChild < size && heapArray[rightChild].CompareTo(heapArray[largest]) > 0)
                    largest = rightChild;

                // If the largest index is still the current element, no further adjustment is needed
                if (largest == index)
                    break;

                Swap(largest, index);  // Swap the largest child and current elements
                index = largest;       // Move down to the largest child index

            }
        }
        private void Swap(int i, int j)
        {
            T temp = heapArray[i];// store value at index i in temp
            heapArray[i]= heapArray[j];// store value of index j at index i
            heapArray[j]= temp;// store temp value at index j
        }
        public IEnumerable<T> GetValues() { 
        
            return heapArray;
        }

    }
}
