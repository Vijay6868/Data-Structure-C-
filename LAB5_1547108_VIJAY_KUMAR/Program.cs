namespace LAB5_1547108_VIJAY_KUMAR
    // 1547108 VIJAY KUMAR LAB5 (HEAP) SUBMISSION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> MaxHeapp Demonstration <<<\n\n" +
                "RANDOM SIZE OF HEAP # testing N size of Heapn\n");
            int size = genRandom();// generating random array size
            MaxHeap<int> mx = new MaxHeap<int>(size); // creating object mx of MaxHeap class giving random size

            Console.WriteLine("ISERTING VALUES RANDOMLY BELOW # testing 'ADD function\n");
            for(int i = 0; i < size; i++)// inserting values randomly
            {
                int randomValue = genRandom();
               
                mx.Insert(randomValue);
            }
            foreach (int element in mx.GetValues())
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("REMOVING MAX VALUE OF HEAP AND RETURNING NOW # testing 'REMOVE function\n");
            Console.WriteLine(mx.Remove());// removing max value in mx and printing on console.

            Console.WriteLine("VALUES AFTER 'REMOVE function'");
            foreach (int element in mx.GetValues())
            {
                Console.WriteLine(element);
            }
        }
        /// <summary>
        /// genertes value randomly b/w 1 and 1000
        /// </summary>
        /// <returns></returns>
        private static int genRandom()
        {
            Random rn = new Random();
            int num = rn.Next(1, 1000);
            return num;
        }
    }
   
}