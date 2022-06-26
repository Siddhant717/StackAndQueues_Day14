using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(3);
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine(queue.ToString());                                   //It display 56 30 70
            Console.WriteLine("Dequeue method removed " + queue.Dequeue());        //It removes 56
            Console.WriteLine(queue.ToString());                                   // It display 30 and 70
            Console.WriteLine("Dequeue method removed " + queue.Dequeue());        // It removes 30
            Console.WriteLine(queue.ToString());                                   // It display 70
            Console.WriteLine("Dequeue method removed " + queue.Dequeue());        //It removes 70
            Console.WriteLine(queue.ToString());                                   // It Display empty queue
        }
    }
}
